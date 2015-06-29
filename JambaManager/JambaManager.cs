using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace JambaManager
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

        public string BuildString()
        {
            var sb = new StringBuilder();

            sb.Append("[");

            if (DifferentiateSides)
            {
                bool prevModifierBuilt;
                bool modifierBuilt;

                var lctrl = BuildModifier(LCtrl, "lctrl");
                modifierBuilt = !string.IsNullOrWhiteSpace(lctrl);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(lctrl);
                }

                var lalt = BuildModifier(LAlt, "lalt");
                modifierBuilt = !string.IsNullOrWhiteSpace(lalt);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(lalt);
                }

                var lshift = BuildModifier(LShift, "lshift");
                modifierBuilt = !string.IsNullOrWhiteSpace(lshift);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(lshift);
                }

                var rctrl = BuildModifier(RCtrl, "rctrl");
                modifierBuilt = !string.IsNullOrWhiteSpace(rctrl);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(rctrl);
                }

                var ralt = BuildModifier(RAlt, "ralt");
                modifierBuilt = !string.IsNullOrWhiteSpace(ralt);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(ralt);
                }

                var rshift = BuildModifier(RShift, "rshift");
                modifierBuilt = !string.IsNullOrWhiteSpace(rshift);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                if (modifierBuilt)
                {
                    sb.Append(rshift);
                }
            }
            else
            {
                bool prevModifierBuilt;
                bool modifierBuilt;

                var ctrl = BuildModifier(LCtrl ?? RCtrl, "ctrl");
                modifierBuilt = !string.IsNullOrWhiteSpace(ctrl);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(ctrl);
                }

                var alt = BuildModifier(LAlt ?? RAlt, "alt");
                modifierBuilt = !string.IsNullOrWhiteSpace(alt);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                prevModifierBuilt = modifierBuilt;
                if (modifierBuilt)
                {
                    sb.Append(alt);
                }

                var shift = BuildModifier(LShift ?? RShift, "shift");
                modifierBuilt = !string.IsNullOrWhiteSpace(shift);
                sb.Append(prevModifierBuilt && modifierBuilt ? "," : string.Empty);
                if (modifierBuilt)
                {
                    sb.Append(shift);
                }
            }

            sb.Append("]");

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

    public class ItemUse
    {
        public string ItemName { get; set; }
    }

    public class SingleCast
    {
        public string SpellName { get; set; }
    }

    public class CastSequence
    {
        public IList<string> SpellNames { get; set; }
        public string ResetString { get; set; }
    }

    public class ItemEquip
    {

    }

    public class Macro
    {
        public string Name { get; set; }
        public string ClickName { get; set; }

        public MacroModifier StopMacroModifier { get; set; }

        public IList<ItemUse> ItemUses { get; set; }
        public IList<ItemEquip> ItemEquips { get; set; }
        public IList<SingleCast> SingleCasts { get; set; }
        public IList<CastSequence> CastSequences { get; set; }

        public string BuildMacro()
        {
            StringBuilder macroBuilder = new StringBuilder();

            macroBuilder.Append(StopMacroModifier != null ? string.Format("/stopmacro {0}", StopMacroModifier.BuildString()) : string.Empty);

            foreach (var itemUse in ItemUses)
            {
                macroBuilder.Append(itemUse.BuildString());
            }

            return string.Empty;
        }
    }

    public class JambaManager
    {

    }
}
