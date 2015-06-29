using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace TeamManager
{
    [Serializable]
    public class MBAccountList
    {
        public List<Account> Accounts { get; set; }

        public MBAccountList()
        {
            Accounts = new List<Account>();
        }
    }

    [Serializable]
    public class MBTeamList
    {
        public List<Team> Teams { get; set; }
        [XmlAttribute]
        public string ActiveTeamName { get; set; }
        [XmlIgnore]
        public Team ActiveTeam
        {
            get
            {
                return Teams.FirstOrDefault(f => f.Name.Equals(ActiveTeamName));
            }
        }

        public MBTeamList()
        {
            Teams = new List<Team>();
            ActiveTeamName = string.Empty;
        }
    }

    public class MBTeamManager
    {
        public MBAccountList AccountList { get; set; }
        public MBTeamList TeamList { get; set; }

        public MBTeamManager(MBAccountList accountList, MBTeamList teamList)
        {
            AccountList = accountList ?? new MBAccountList();
            TeamList = teamList ?? new MBTeamList();
        }

        public void CreateTeam(string name)
        {
            if (!TeamExists(name))
            {
                TeamList.Teams.Add(new Team { Name = name });
            }
        }

        public Team GetTeam(string name)
        {
            if (!TeamExists(name)) return TeamList.ActiveTeam;

            return TeamList.Teams.First(f => f.Name.Equals(name));
        }

        public void SetCurrentTeam(Team team)
        {
            if (!TeamExists(team) || TeamList.ActiveTeam == team) return;

            TeamList.ActiveTeamName = team.Name;
        }

        public bool TeamExists(Team team)
        {
            return TeamExists(team.Name);
        }

        public bool TeamExists(string teamName)
        {
            return TeamList.Teams.Any(a => a.Name.Equals(teamName));
        }
    }
}
