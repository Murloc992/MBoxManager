using System;
using System.Collections.Generic;
using System.Security;
using TeamManager;

namespace SettingsManager
{
    [Serializable]
    public class Account
    {
        public string AccountName { get; set; }
        public SecureString AccountPass { get; set; }
        public string AccountRealm { get; set; }
        public IList<string> Toons { get; set; } 
    }

    [Serializable]
    public class Settings
    {
        public string WowPath { get; set; }
        public string HKNPath { get; set; }

        public IList<Account> Accounts { get; set; } 
        public IList<Team> Teams { get; set; }
        public IList<Toon> Toons { get; set; }
    }

    public class SettingsManager
    {
        public bool FirstRun;
    }
}
