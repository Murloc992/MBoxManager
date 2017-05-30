using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TeamManager;

namespace MacroManager
{
    [Serializable]
    public class ModifierKey
    {
        [XmlAttribute]
        public string DisplayName { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public bool? Value { get; set; }
    }

    public class MacroModifier
    {
        public bool? LCtrl { get; set; }
        public bool? LAlt { get; set; }
        public bool? LShift { get; set; }
        public bool? RCtrl { get; set; }
        public bool? RAlt { get; set; }
        public bool? RShift { get; set; }

        public bool DifferentiateSides { get; set; }

        public static List<ModifierKey> DifferentialModifierKeys = new List<ModifierKey>
        {
            new ModifierKey {DisplayName = "Left Control", Name = "lctrl"}
        };

        public static MacroModifier CreateFromFTL(FTLOptions options)
        {
            var modifier = new MacroModifier();
            modifier.DifferentiateSides = true;
            modifier.LCtrl = options.UseLCtrl == true ? (bool?)true : null;
            modifier.LAlt = options.UseLAlt == true ? (bool?)true : null;
            modifier.LShift = options.UseLShift == true ? (bool?)true : null;
            modifier.RCtrl = options.UseRCtrl == true ? (bool?)true : null;
            modifier.RAlt = options.UseRAlt == true ? (bool?)true : null;
            modifier.RShift = options.UseRShift == true ? (bool?)true : null;

            return modifier;
        }

        public bool Empty()
        {
            return LCtrl == null && LAlt == null && LShift == null && RCtrl == null && RAlt == null && RShift == null;
        }

        public string BuildString(bool brackets = false)
        {
            var sb = new StringBuilder();

            string modifierString = string.Empty;

            List<string> modifiers = new List<string>();

            if (DifferentiateSides)
            {
                modifiers.Add(BuildModifier(LCtrl, "lctrl"));
                modifiers.Add(BuildModifier(LAlt, "lalt"));
                modifiers.Add(BuildModifier(LShift, "lshift"));
                modifiers.Add(BuildModifier(RCtrl, "rctrl"));
                modifiers.Add(BuildModifier(RAlt, "ralt"));
                modifiers.Add(BuildModifier(RShift, "rshift"));
            }
            else
            {
                modifiers.Add(BuildModifier(LCtrl ?? RCtrl, "ctrl"));
                modifiers.Add(BuildModifier(LAlt ?? RAlt, "alt"));
                modifiers.Add(BuildModifier(LShift ?? RShift, "shift"));
            }

            modifierString = string.Join(",", modifiers.Where(w => !string.IsNullOrWhiteSpace(w)));

            if (!string.IsNullOrWhiteSpace(modifierString))
            {
                if (brackets)
                    sb.Append("[");
                sb.Append(modifierString);
                if (brackets)
                    sb.Append("]");
            }

            return sb.ToString();
        }

        private string BuildModifier(bool? modifier, string modName)
        {
            string ret = string.Empty;

            if (!modifier.HasValue) return ret;

            var pos = modifier.Value ? "mod" : "nomod";
            ret = string.Format("{0}:{1}", pos, modName);

            return ret;
        }
    }

    public class Target
    {
        public string TargetName { get; set; }
        public MacroModifier Modifier { get; set; }
    }

    public class ItemUse
    {
        public string ItemName { get; set; }
        public Target MacroTarget { get; set; }
        public MacroModifier Modifier { get; set; }
    }

    public class SpellCast
    {
        public string SpellName { get; set; }
        public Target MacroTarget { get; set; }
        public MacroModifier Modifier { get; set; }
    }

    public class CastSequence
    {
        public IList<SpellCast> Spells { get; set; }
        public string ResetString { get; set; }
    }

    public class Macro
    {
        public string Name { get; set; }
        public string ClickName { get; set; }
        public string Icon { get; set; }
        public string MacroText { get; set; }

        public MacroModifier StopMacroModifier { get; set; }

        public IList<Target> TargetNames { get; set; }
        public IList<ItemUse> ItemUses { get; set; }
        public IList<SpellCast> SingleCasts { get; set; }
        public IList<CastSequence> CastSequences { get; set; }

        public void BuildTargetMacro()
        {
            StringBuilder macroBuilder = new StringBuilder();

            macroBuilder.Append(StopMacroModifier != null ? string.Format("/stopmacro {0}", StopMacroModifier.BuildString()) : string.Empty);

            if(TargetNames.Any())
            {
                macroBuilder.Append("/target ");
                if(TargetNames.Count>1)
                {
                    foreach (var target in TargetNames)
                    {
                        if (target.Modifier.Empty())
                        {
                            continue;
                        }
                        else
                        {
                            macroBuilder.AppendFormat("[{0},target={1}]", target.Modifier.BuildString(), target.TargetName);
                        }
                    }
                }
                else
                {
                    macroBuilder.Append(TargetNames.First().TargetName);
                }
            }

            MacroText = macroBuilder.ToString();
        }

        public void PopulateTargets(Team team)
        {
            TargetNames = team.ToonsInTeam.Select(s => new Target { Modifier = MacroModifier.CreateFromFTL(s.FTLOptions), TargetName = s.Name }).ToList();
        }
    }
}
