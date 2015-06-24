﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
