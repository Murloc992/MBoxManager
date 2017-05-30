using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManager;

namespace MacroManager
{
    //macro template:
    //MACRO 6 "asd" INV_Misc_QuestionMark
    // /script DEFAULT_CHAT_FRAME:AddMessage(GetMouseFocus():GetName() );
    //END
    public class MBMacroManager
    {
        public List<Macro> GlobalMacros { get; private set; }
        public Dictionary<string, Macro> TeamMacros { get; set; }
        public Dictionary<string, Macro> ToonMacros { get; set; }

        public MBMacroManager()
        {
            GlobalMacros = new List<Macro>();
            TeamMacros = new Dictionary<string, Macro>();
            ToonMacros = new Dictionary<string, Macro>();
            InitGlobalMacros();
        }

        void AddTeamMacro(Team team, Macro macro)
        {
            TeamMacros.Add(team.Name, macro);
        }

        void AddToonMacro(Toon toon,Macro macro)
        {
            ToonMacros.Add(toon.Name, macro);
        }

        void InitGlobalMacros()
        {
            GlobalMacros.Add(new Macro
            {
                Name = "MBFollow",
                Icon = "INV_Misc_QuestionMark",
                MacroText = "/stopmacro [nomod]\n/click MBTargetButton\n/follow\n/targetlasttarget"
            });
            GlobalMacros.Add(new Macro
            {
                Name = "MBAssist",
                Icon = "INV_Misc_QuestionMark",
                MacroText = "/stopmacro [nomod]\n/click MBTargetButton\n/assist"
            });
            GlobalMacros.Add(new Macro
            {
                Name = "MBLogout",
                Icon = "INV_Misc_QuestionMark",
                MacroText = "/camp"
            });
            GlobalMacros.Add(new Macro
            {
                Name = "MBLoot",
                Icon = "INV_Misc_QuestionMark",
                MacroText = "/click LootButton1"
            });
            GlobalMacros.Add(new Macro
            {
                Name = "MBResetView",
                Icon = "INV_Misc_QuestionMark",
                MacroText = "/script SetView(4);SetView(4);"
            });
        }

        public void SaveMacros(Team t)
        {
            int macroId = 1;
            var teamMacros = TeamMacros.Where(w => w.Key == t.Name).Select(s => s.Value).ToList();
            foreach (var toon in t.ToonsInTeam)
            {
                var toonMacros = ToonMacros.Where(w => w.Key == toon.Name).Select(s => s.Value).ToList();
                var macroFilePath = Path.Combine(toon.ActualAccount.Path, toon.RealmName, toon.Name, "macros-cache.txt");
                if (File.Exists(macroFilePath))
                {
                    File.WriteAllText(macroFilePath, String.Empty);
                }
                else
                {
                    var file = File.Create(macroFilePath);
                    file.Close();
                }

                using (StreamWriter sw = File.AppendText(macroFilePath))
                {
                    foreach (var globalMacro in GlobalMacros)
                    {
                        WriteMacro(sw, macroId, globalMacro);
                        macroId++;
                    }
                    foreach (var teamMacro in teamMacros)
                    {
                        WriteMacro(sw, macroId, teamMacro);
                        macroId++;
                    }
                    foreach (var toonMacro in toonMacros)
                    {
                        WriteMacro(sw, macroId, toonMacro);
                        macroId++;
                    }
                } 
            }
        }

        void WriteMacro(StreamWriter sw,int macroId,Macro macro)
        {
            sw.WriteLine($"MACRO {macroId} {macro.Name} {macro.Icon}");
            sw.WriteLine($"{macro.MacroText}");
            sw.WriteLine($"END");
        }
    }
}
