using System.Collections.Generic;

namespace TeamManager
{
    public class Team
    {
        private readonly IDictionary<string, Toon> _toonsInTeam;

        public Team()
        {
            _toonsInTeam = new Dictionary<string, Toon>();
        }

        public void AddToon(Toon toon)
        {
            if (!ContainsToon(toon.Name))
            {
                _toonsInTeam.Add(new KeyValuePair<string, Toon>(toon.Name, toon));
            }
        }

        public Toon GetToon(string name)
        {
            return ContainsToon(name) ? _toonsInTeam[name] : null;
        }

        public bool ContainsToon(string name)
        {
            return _toonsInTeam.ContainsKey(name);
        }
    }
}
