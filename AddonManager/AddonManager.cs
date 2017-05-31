using MacroManager;
using System.IO;
using System.Text;
using TeamManager;

namespace AddonManager
{
    public class MBAddonManager
    {
        string _interfaceDirectoryPath;
        string _addonDir;
        string _addonFilePath;
        MBMacroManager _macroManager;

        public MBAddonManager(string wowpath, MBMacroManager macroManager)
        {
            _interfaceDirectoryPath = Path.Combine(wowpath, "Interface", "Addons");
            _addonDir = Path.Combine(_interfaceDirectoryPath, "MBoxManager");
            _addonFilePath = Path.Combine(_addonDir, "MBoxManager.lua");
            _macroManager = macroManager;

            if (!Directory.Exists(_addonDir))
            {
                Directory.CreateDirectory(_addonDir);
                CreateAddonInitialFiles();
            }
        }

        void ClearAddonFile()
        {
            File.WriteAllText(_addonFilePath, string.Empty);
        }

        void CreateAddonInitialFiles()
        {
            var tocPath = Path.Combine(_addonDir, "MBoxManager.toc");

            var toc = File.Create(tocPath); toc.Close();
            var addonfile = File.Create(_addonFilePath); addonfile.Close();

            using (StreamWriter sw = File.AppendText(tocPath))
            {
                sw.WriteLine("## Interface: 20400");
                sw.WriteLine("## Title: Murloc's Box Manager");
                sw.WriteLine("## Version: 1.0.0");
                sw.WriteLine("## Author: Murloc992, 2017");
                sw.WriteLine("## Notes: Poor mans ISBoxer.");
                sw.WriteLine("");
                sw.WriteLine("MBoxManager.lua");
            }
        }

        void UpdateAddonTeam(Team activeTeam)
        {

        }

        //bars:
        //placement macro example for addon:
        // /script PickupMacro("bb1"); PlaceAction("1");ClearCursor();
        //normal bars: 24 slots
        //right: 25-36
        //left: 37-48
        //bottom right: 49-60
        //bottom left: 61-72
        //ActionButtonX
        //MultiBarBottomLeftButtonX
        //MultiBarBottomRightButtonX
        //MultiBarLeftButtonX
        //MultiBarRightButtonX

        public void CreateTargetMacroButton(Team activeTeam)
        {
            ClearAddonFile();

            using (StreamWriter sw = File.AppendText(_addonFilePath))
            {
                StringBuilder sb = new StringBuilder();
                CreateAddonHeader(sb);

                BeginFunction(sb, "OnInitialize");
                AddFunctionCall(sb, "CreateFollowButton");
                WriteEnd(sb);
                sb.AppendLine();


                BeginFunction(sb, "CreateFollowButton");
                var macro = new Macro();
                macro.BuildFTLTargetMacro(activeTeam);
                macro.SetHotKey("F", false);
                CreateMacroActionButton(sb, "MBTargetButton", macro.MacroText);
                if (macro.HotKey != null && !macro.HotKey.Disabled)
                    AddBinding(sb, "MBTargetButton", $"{macro.HotKey.HotKey}");
                WriteEnd(sb);
                sb.AppendLine();

                BeginFunction(sb, "OnLogin");
                CreateMacroMove(sb, "MBFollow", (int)Constants.MBConstants.ActionBarSlots.ActionBar1.Slot1);
                CreateMacroMove(sb, "MBAssist", (int)Constants.MBConstants.ActionBarSlots.ActionBar1.Slot2);
                CreateMacroMove(sb, "MBLogout", (int)Constants.MBConstants.ActionBarSlots.ActionBar1.Slot3);
                CreateMacroMove(sb, "MBLoot", (int)Constants.MBConstants.ActionBarSlots.ActionBar1.Slot4);
                CreateMacroMove(sb, "MBResetView", (int)Constants.MBConstants.ActionBarSlots.ActionBar1.Slot5);
                WriteEnd(sb);
                sb.AppendLine();

                RegisterEvents(sb);

                var result = sb.ToString();
                sw.Write(result);
            }

        }

        void BuildStockMacros(Team activeTeam)
        {

        }

        void CreateActionButton(StringBuilder sb, string actionButtonName, string actionButtonType, bool hide = true)
        {
            sb.AppendLine($"\t{actionButtonName} = CreateFrame(\"Button\",\"{actionButtonName}\",nil,\"SecureActionButtonTemplate\");");
            sb.AppendLine($"\t{actionButtonName}:SetAttribute(\"type\",\"{actionButtonType}\");");
            if (hide)
                sb.AppendLine($"\t{actionButtonName}:Hide();");
        }

        void AddBinding(StringBuilder sb, string actionButtonName, string key)
        {
            sb.AppendLine($"\tSetOverrideBinding({actionButtonName},false,\"{key}\",\"CLICK {actionButtonName}:LeftButton\");");
        }

        void AddAttribute(StringBuilder sb, string actionButtonName, string attributeName, string attributeProperty)
        {
            sb.AppendLine($"\t{actionButtonName}:SetAttribute(\"{attributeName}\",\"{attributeProperty}\");");
        }

        void CreateMacroActionButton(StringBuilder sb, string actionButtonName, string macro)
        {
            CreateActionButton(sb, actionButtonName, "macro");
            AddAttribute(sb, actionButtonName, "macrotext", macro);
        }

        void AddFunctionCall(StringBuilder sb, string functionName)
        {
            sb.AppendLine($"\tMBoxManager:{functionName}()");
        }

        void CreateAddonHeader(StringBuilder sb)
        {
            sb.AppendLine("MBoxManager = LibStub(\"AceAddon-3.0\"):NewAddon(\"MBoxManager\",\"AceEvent-3.0\")");
        }

        void RegisterEvents(StringBuilder sb)
        {
            sb.AppendLine("MBoxManager:RegisterEvent(\"PLAYER_LOGIN\",\"OnLogin\")");
        }

        void BeginFunction(StringBuilder sb, string functionName)
        {
            sb.AppendLine($"function MBoxManager:{functionName}()");
        }

        void WriteEnd(StringBuilder sb)
        {
            sb.AppendLine("end");
        }

        void CreateMacroMove(StringBuilder sb, string macroName, int slot)
        {
            sb.AppendLine($"\tif GetActionText({slot})~=\"{macroName}\" then");
            sb.AppendLine($"\t\tPickupMacro(\"{macroName}\");");
            sb.AppendLine($"\t\tPlaceAction({slot});");
            sb.AppendLine("\t\tClearCursor();");
            sb.AppendLine($"\t\tChatFrame1:AddMessage(\"Replaced {macroName} on ActionSlot{slot}\");");
            sb.AppendLine("\tend");
        }
    }
}
