using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Constants;

namespace TeamManager
{
    [Serializable]
    public class Toon
    {
        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Class { get; set; }
        [XmlAttribute]
        public string Specialization { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    [Serializable]
    public class TeamToon : Toon
    {
        public MBConstants.ToonClasses ToonClass { get; set; }
        public MBConstants.ClassSpecializations ToonSpec { get; set; }
        public bool FTLToon { get; set; }
        public TeamToon()
        {
            
        }
        public TeamToon(Toon other)
        {
            Name = other.Name;
            Class = other.Class;
            Specialization = other.Specialization;
        }
    }
}
