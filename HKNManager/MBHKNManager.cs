﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using TeamManager;

namespace HKNManager
{
    public class MBHKNManager
    {
        private Team _teamToBuild;
        private StringBuilder scriptBuilder;
        private string _wowPath;
        private string _hknPath;
        private List<string> labels;

        public MBHKNManager(Team teamToBuild, string HKNPath, string wowPath)
        {
            _wowPath = wowPath;
            _hknPath = HKNPath;
            _teamToBuild = teamToBuild;

            scriptBuilder = new StringBuilder();

            scriptBuilder.AppendLine("//------------------------------------------------------------------------");
            scriptBuilder.AppendLine("// This script is autogenerated by Murloc Box Manager HKN Script Generator");
            scriptBuilder.AppendLine("//------------------------------------------------------------------------");
            scriptBuilder.AppendLine();

            BuildSendingLabels();
            BuildWoWLaunchingCommand();
            BuildBuiltinCommands();
            Save();
        }

        public void RestartHKN()
        {
            var kill = Process.Start("taskkill", "/IM hotkeynet.exe");
            kill.WaitForExit();
            Process.Start(string.Format("{0}\\hotkeynet.exe", _hknPath), "HKN.xml");
        }

        private void BuildSendingLabels()
        {
            labels = new List<string>();
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                scriptBuilder.AppendFormat("<Label w{0} Local SendWinM \"WoW{0}\">\n", i + 1);
                labels.Add(string.Format("w{0}", i + 1));
            }
            scriptBuilder.AppendLine();
        }

        private void BuildWoWLaunchingCommand()
        {
            scriptBuilder.AppendLine("<Command LaunchAndRenameAll>");
            scriptBuilder.AppendLine("\t<SendPC Local>");
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                scriptBuilder.AppendFormat("\t\t<Run \"{0}\\wow.exe\">\n", _wowPath);
            }

            scriptBuilder.AppendLine();
            scriptBuilder.AppendLine("\t\t<WaitForWin \"World of Warcraft\" 20000>");
            scriptBuilder.AppendLine();
            scriptBuilder.AppendLine("\t\t<Wait 5000>");
            scriptBuilder.AppendLine();

            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                scriptBuilder.AppendLine("\t\t<TargetWin \"World of Warcraft\">");
                scriptBuilder.AppendFormat("\t\t\t<RenameTargetWin \"WoW{0}\">\n", i + 1);
                scriptBuilder.AppendLine("\t\t\t<RemoveWinFrame>");
                scriptBuilder.AppendLine();
            }
            scriptBuilder.AppendLine();
        }

        private void BuildBuiltinCommands()
        {
            LoginCommands();
            BuildResizing();
            LaunchCommand();
            FTLCommands();
        }

        private void BuildScreenSetup()
        {
        }

        private void BuildFTL()
        {
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
            }
        }

        public void Save()
        {
            var script = scriptBuilder.ToString();
            File.WriteAllText("HKN.xml", script);
        }

        private void LoginCommands()
        {
            scriptBuilder.AppendLine("<Command AccInfo>");
            scriptBuilder.AppendLine("\t<TargetWin %1%>");
            scriptBuilder.AppendLine("\t<SetFocusWin>");
            scriptBuilder.AppendLine("\t<SendWin %1%>");
            scriptBuilder.AppendLine("\t\t<Text %2%><Wait 50><Key Tab><Wait 50>");
            scriptBuilder.AppendLine("\t\t<Text %3%><Wait 50><Key Enter><Wait 50>");
            scriptBuilder.AppendLine();

            scriptBuilder.AppendLine("<Command AccInfoNoLogin>");
            scriptBuilder.AppendLine("\t<TargetWin %1%>");
            scriptBuilder.AppendLine("\t<SetFocusWin>");
            scriptBuilder.AppendLine("\t<SendWin %1%>");
            scriptBuilder.AppendLine("\t\t<Text %2%><Wait 50><Key Tab><Wait 50>");
            scriptBuilder.AppendLine();

            scriptBuilder.AppendLine("<Command LoginWows>\n\t<SendPC Local>");

            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                var toon = _teamToBuild.ToonsInTeam[i];

                if (!string.IsNullOrWhiteSpace(toon.ActualAccount.Pass))
                    scriptBuilder.AppendFormat("\t\t<AccInfo \"WoW{0}\" \"{1}\" \"{2}\">\n", i + 1, toon.ActualAccount.Name, toon.ActualAccount.Pass);
                else
                    scriptBuilder.AppendFormat("\t\t<AccInfoNoLogin \"WoW{0}\" \"{1}\">\n", i + 1, toon.ActualAccount.Name);
            }

            scriptBuilder.AppendLine();
        }

        private void LaunchCommand()
        {
            scriptBuilder.AppendLine("<Hotkey LALT LCTRL L>");
            scriptBuilder.Append("\t<LaunchAndRenameAll");
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                scriptBuilder.AppendFormat(" \"WoW{0}\"", i + 1);
            }
            scriptBuilder.Append(">");
            scriptBuilder.AppendLine();

            scriptBuilder.Append("\t<ResizeWows");
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                scriptBuilder.AppendFormat(" \"WoW{0}\"", i + 1);
            }
            scriptBuilder.Append(">");
            scriptBuilder.AppendLine();

            scriptBuilder.AppendLine("\t<Wait 1000>");
            scriptBuilder.AppendLine("\t<LoginWows>");
            scriptBuilder.AppendLine("\t<TargetWin \"WoW1\">");
            scriptBuilder.AppendLine("\t<SetFocusWin>");
            scriptBuilder.AppendLine();
        }

        private void FTLCommands()
        {
            //-----------------------------------------------------------
            // Main FTL Template
            //-----------------------------------------------------------
            // %1% : Master Key
            // %2% : Slave Key
            // %3% : Modifier
            // %4% : SlavesToSend
            scriptBuilder.AppendLine("<Template SendMasterAndSlave>");
            scriptBuilder.AppendLine("\t<SendFocusWin>");
            scriptBuilder.AppendLine("\t\t<Key %1%>");
            scriptBuilder.AppendLine("\t<SendLabel %4%>");
            scriptBuilder.AppendLine("\t\t<Key %3% %2%>");
            scriptBuilder.AppendLine("<EndTemplate>");
            scriptBuilder.AppendLine();

            //-----------------------------------------------------------

            //-----------------------------------------------------------
            // LeaderLess Sending Template
            //-----------------------------------------------------------
            // %1% : master key
            // %2% : slave key
            // %3% : modifier
            // %4% : Active window
            // %5% : Slave Windows
            scriptBuilder.AppendLine("<Template SendLeaderless>");
            scriptBuilder.AppendLine("\t<If ActiveWinIs %4%>");
            scriptBuilder.AppendLine("\t\t<ApplyTemplate SendMasterAndSlave %1% %2% %3% %5%>");
            scriptBuilder.AppendLine("<EndTemplate>");
            scriptBuilder.AppendLine();

            //-----------------------------------------------------------

            //-----------------------------------------------------------
            // FTL Key Template
            //-----------------------------------------------------------
            // %1% : master-key
            // %2% : slave-key
            scriptBuilder.AppendLine("<Template FTL>");
            scriptBuilder.AppendLine("\t<Hotkey %1%>");
            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                var slaveLabels = labels.Where(w => w != string.Format("w{0}", i + 1));
                string slaveLabelsCombined = string.Join(",", slaveLabels);
                var toon = _teamToBuild.ToonsInTeam[i];
                scriptBuilder.AppendFormat("\t\t<ApplyTemplate SendLeaderless %1% %2% \"{0}\" \"WoW{1}\" \"{2}\">", toon.FTLOptions.BuildFTLKeys(), i + 1, slaveLabelsCombined);
                scriptBuilder.AppendLine();
            }
            scriptBuilder.AppendLine("<EndTemplate>");
            scriptBuilder.AppendLine();

            //-----------------------------------------------------------
        }

        private void BuildResizing()
        {
            scriptBuilder.AppendLine("<Command ResizeWows>");
            scriptBuilder.AppendLine("\t<SendPC Local>");

            var toonCount = _teamToBuild.ToonsInTeam.Count - 1;

            var sqrtToonCount = Math.Sqrt(toonCount);
            var rows = Math.Floor(sqrtToonCount);
            var columns = Math.Ceiling(sqrtToonCount);

            var cols = 0;

            var divX = (int)Math.Floor(1920 / columns);
            var divY = (int)Math.Floor(1040 / rows);

            var colCounter = 0;

            for (var i = 0; i < _teamToBuild.ToonsInTeam.Count; i++)
            {
                if (colCounter >= 1000)
                {
                    cols++;
                    colCounter = 0;
                }

                scriptBuilder.AppendFormat("\t\t<TargetWin %{0}%>\n", i + 1);
                if (i == 0)
                    scriptBuilder.AppendFormat("\t\t\t<SetWinRect {0} {1} {2} {3}>\n", 0, 0, 1920, 1040);
                else
                {
                    scriptBuilder.AppendFormat("\t\t\t<SetWinRect {0} {1} {2} {3}>\n", 1920 + cols * divX, colCounter, divX, divY);
                    colCounter += divY;
                }
            }
            scriptBuilder.AppendLine("\t\t<TargetWin %1%>");
            scriptBuilder.AppendLine("\t<SetFocusWin>");
            scriptBuilder.AppendLine("\t<SetActiveWin>");

            scriptBuilder.AppendLine();
        }
    }
}