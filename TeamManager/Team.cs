using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TeamManager
{
    [Serializable]
    public class Team
    {
        [XmlAttribute]
        public string Name { get; set; }
        public List<TeamToon> ToonsInTeam { get; set; }

        public Team()
        {
            ToonsInTeam = new List<TeamToon>();
        }

        public void AddToon(Toon toon)
        {
            if (!ContainsToon(toon.Name))
            {
                ToonsInTeam.Add(new TeamToon(toon));
            }
        }

        public void RemoveToon(string toonName)
        {
            if (ContainsToon(toonName))
            {
                ToonsInTeam.Remove(GetToon(toonName));
            }
        }

        public bool ContainsToon(string toonName)
        {
            return ToonsInTeam.Any(a => a.Name.Equals(toonName));
        }

        public TeamToon GetToon(string toonName)
        {
            return ToonsInTeam.First(f => f.Name.Equals(toonName));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
