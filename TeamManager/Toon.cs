using Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TeamManager
{
    [Serializable]
    public class Toon
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string ClassName { get; set; }

        [XmlAttribute]
        public string SpecializationName { get; set; }

        [XmlAttribute]
        public string AccountName { get; set; }

        [XmlAttribute]
        public string RealmName { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class FTLOptions
    {
        [XmlAttribute]
        public bool UseInFTL { get; set; }

        [XmlAttribute]
        public bool UseLShift { get; set; }

        [XmlAttribute]
        public bool UseLCtrl { get; set; }

        [XmlAttribute]
        public bool UseLAlt { get; set; }

        [XmlAttribute]
        public bool UseRShift { get; set; }

        [XmlAttribute]
        public bool UseRCtrl { get; set; }

        [XmlAttribute]
        public bool UseRAlt { get; set; }

        public string BuildFTLKeys()
        {
            List<string> keys = new List<string>();

            keys.Add(UseLShift ? "lshift" : string.Empty);
            keys.Add(UseLCtrl ? "lctrl" : string.Empty);
            keys.Add(UseLAlt ? "lalt" : string.Empty);
            keys.Add(UseRShift ? "rshift" : string.Empty);
            keys.Add(UseRCtrl ? "rctrl" : string.Empty);
            keys.Add(UseRAlt ? "ralt" : string.Empty);

            return string.Join(" ", keys.Where(w => !string.IsNullOrWhiteSpace(w)));
        }
    }

    [Serializable]
    public class TeamToon : Toon
    {
        public MBConstants.ToonClasses ToonClass { get; set; }
        public MBConstants.ClassSpecializations ToonSpec { get; set; }

        public FTLOptions FTLOptions { get; set; }

        [XmlIgnore]
        public Account ActualAccount { get; set; }

        public TeamToon()
        {
            FTLOptions = new FTLOptions();
        }

        public TeamToon(Toon other)
        {
            Name = other.Name;
            ClassName = other.ClassName;
            SpecializationName = other.SpecializationName;
            AccountName = other.AccountName;
            RealmName = other.RealmName;

            FTLOptions = new FTLOptions();
        }
    }
}