using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public static class MBConstants
    {
        public enum ToonClasses
        {
            DeathKnight,
            Druid,
            Hunter,
            Mage,
            Paladin,
            Priest,
            Rogue,
            Shaman,
            Warlock,
            Warrior
        }

        public enum ClassSpecializations
        {
            Affliction,
            Arcane,
            Arms,
            Assasination,
            Balance,
            Beastmaster,
            Blood,
            Combat,
            Demonology,
            Destruction,
            Discipline,
            Elemental,
            Enhancement,
            Feral,
            Fire,
            Frost,
            Fury,
            Holy,
            Marksmanship,
            Protection,
            Restoration,
            Retribution,
            Shadow,
            Subtlety,
            Survival,
            Unholy
        }

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
