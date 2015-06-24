using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{

    public enum ToonClasses
    {
        DeathKnight,
    }

    public enum ToonSpecializations
    {
        Frost,
        Unholy,
        Blood,


    }

    public class ToonSpecialization
    {

    }

    public class ToonClass
    {
        string Name;
        string Icon;
        List<ToonSpecialization> Specializations;
    }

    public class Spell
    {
        string Name;
        string Icon;
        bool Specialized;
    }

    public static class Templates
    {

    }

    public static class MBConstants
    {
        public enum ConfigFiles
        {
            Application,
            Accounts,
            Teams,
            Macros,
            HotKeyNet,
            Jamba
        }

        public enum DatabaseFiles
        {
            ClassesAndSpells
        }

        public static class HotKeyNet
        {

        }

        public static class Jamba
        {

        }

        public static class Settings
        {
            public static class Directories
            {
                public const string SettingFileDir = "Settings";
                public const string MacroFileDir = "Macro";
                public const string DatabaseFileDir = "Database";
            }

            public static class Files
            {
                public const string SettingsFileName = "Settings.mbs";
                public const string GameSettingsFileName = "GameSettings.mbs";
                public const string AccountsFileName = "Accounts.mbs";
                public const string TeamsFileName = "Teams.mbs";
                public const string MacroFileName = "Macro.mbs";
                public const string ClassesAndSpellsDatabaseFileName = "ClassesAndSpells.dbs";
            }
        }
    }
}
