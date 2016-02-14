using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Constants
{
    public static class MBConstants
    {
        public enum ToonClasses : int
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

        public enum ClassSpecializations : int
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

        public static class ToonDescriptor
        {
            public static Dictionary<ToonClasses, string> Classes = new Dictionary<ToonClasses, string>
            {
                {ToonClasses.DeathKnight,"Death Knight"},
                {ToonClasses.Druid,"Druid"},
                {ToonClasses.Hunter,"Hunter"},
                {ToonClasses.Mage,"Mage"},
                {ToonClasses.Paladin,"Paladin"},
                {ToonClasses.Priest,"Priest"},
                {ToonClasses.Rogue,"Rogue"},
                {ToonClasses.Shaman,"Shaman"},
                {ToonClasses.Warlock,"Warlock"},
                {ToonClasses.Warrior,"Warrior"}
            };

            public static Dictionary<ToonClasses, Dictionary<ClassSpecializations, string>> Specializations = new Dictionary<ToonClasses, Dictionary<ClassSpecializations, string>>
            {
                {
                    ToonClasses.DeathKnight, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Blood,"Blood"},
                        {ClassSpecializations.Frost,"Frost"},
                        {ClassSpecializations.Unholy,"Unholy"}
                    }
                },
                {
                    ToonClasses.Druid, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Balance,"Balance"},
                        {ClassSpecializations.Feral,"Feral"},
                        {ClassSpecializations.Restoration,"Restoration"}
                    }
                },
                {
                    ToonClasses.Hunter, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Beastmaster,"Beastmaster"},
                        {ClassSpecializations.Marksmanship,"Marksmanship"},
                        {ClassSpecializations.Survival,"Survival"}
                    }
                },
                {
                    ToonClasses.Mage, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Arcane,"Arcane"},
                        {ClassSpecializations.Frost,"Frost"},
                        {ClassSpecializations.Fire,"Fire"}
                    }
                },
                {
                    ToonClasses.Paladin, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Holy,"Holy"},
                        {ClassSpecializations.Protection,"Protection"},
                        {ClassSpecializations.Retribution,"Retribution"}
                    }
                },
                {
                    ToonClasses.Priest, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Discipline,"Discipline"},
                        {ClassSpecializations.Holy,"Holy"},
                        {ClassSpecializations.Shadow,"Shadow"}
                    }
                },
                {
                    ToonClasses.Rogue, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Assasination,"Assasination"},
                        {ClassSpecializations.Combat,"Combat"},
                        {ClassSpecializations.Subtlety,"Subtlety"}
                    }
                },
                {
                    ToonClasses.Shaman, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Elemental,"Elemental"},
                        {ClassSpecializations.Enhancement,"Enhancement"},
                        {ClassSpecializations.Restoration,"Restoration"}
                    }
                },
                {
                    ToonClasses.Warlock, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Affliction,"Affliction"},
                        {ClassSpecializations.Demonology,"Demonology"},
                        {ClassSpecializations.Destruction,"Destruction"}
                    }
                },
                {
                    ToonClasses.Warrior, new Dictionary<ClassSpecializations, string>
                    {
                        {ClassSpecializations.Arms,"Arms"},
                        {ClassSpecializations.Fury,"Fury"},
                        {ClassSpecializations.Protection,"Protection"}
                    }
                }
            };
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