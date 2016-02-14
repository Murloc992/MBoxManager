using Constants;
using Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using TeamManager;

namespace SettingsManager
{
    [Serializable]
    public class Settings
    {
        public string WowPath { get; set; }
        public string HKNPath { get; set; }
    }

    public class MBSettingsManager
    {
        public string WorkingDirectory { get; set; }
        public Settings mainSettings { get; set; }
        public bool FirstRun;

        public MBSettingsManager()
        {
            WorkingDirectory = Directory.GetCurrentDirectory();
            mainSettings = new Settings();
        }

        public bool LoadConfig()
        {
            try
            {
                var settingsFileDir = Path.Combine(WorkingDirectory, MBConstants.Settings.Directories.SettingFileDir);
                var settingsFilePath = Path.Combine(settingsFileDir, MBConstants.Settings.Files.SettingsFileName);

                FirstRun = !File.Exists(settingsFilePath);

                if (FirstRun) //initial scanning and serialization
                {
                    string wowPath;
                    GetSettingsPath("Select WoW directory", "wow.exe", out wowPath);
                    mainSettings.WowPath = wowPath;

                    string hknPath;
                    GetSettingsPath("Select HotKeyNet directory", "hotkeynet.exe", out hknPath);
                    mainSettings.HKNPath = hknPath;

                    WriteConfig(MBConstants.ConfigFiles.Application, mainSettings);
                }
                else //deserialize the fuck out of it
                {
                    mainSettings = LoadConfig(MBConstants.ConfigFiles.Application) as Settings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void GetSettingsPath(string description, string pathValidation, out string pathOutput)
        {
            bool valid = false;
            pathOutput = null;
            while (!valid)
            {
                var dialog = new FolderBrowserDialog { Description = description };
                DialogResult result = dialog.ShowDialog(new Form() { TopMost = true, TopLevel = true });
                if (result == DialogResult.OK)
                {
                    var path = dialog.SelectedPath;
                    if (Directory.EnumerateFiles(path, pathValidation).Any())
                    {
                        valid = true;
                        pathOutput = path;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            if (!valid)
            {
                throw new Exception("I would really recommend selecting a valid path in order to use this app.");
            }
        }

        public MBAccountList GenerateAccountsList()
        {
            return new MBAccountList
            {
                Accounts = FindAccounts(Path.Combine(mainSettings.WowPath, "WTF", "Account"))
            };
        }

        private List<Account> FindAccounts(string WTFAccountsPath)
        {
            var ret = new List<Account>();

            var accountDirs = Directory.EnumerateDirectories(WTFAccountsPath);

            foreach (var accountDir in accountDirs)
            {
                var account = new Account
                {
                    Name = accountDir.Split('\\').Last()
                };
                account.Realms = FindRealms(account, accountDir);

                ret.Add(account);
            }

            return ret;
        }

        private List<Realm> FindRealms(Account currentAccount, string accountPath)
        {
            var ret = new List<Realm>();

            var realmDirs = Directory.EnumerateDirectories(accountPath).Where(w => !w.Contains("SavedVariables"));

            foreach (var realmDir in realmDirs)
            {
                var realm = new Realm
                {
                    Name = realmDir.Split('\\').Last()
                };
                realm.Toons = FindToons(currentAccount, realm, realmDir);

                ret.Add(realm);
            }

            return ret;
        }

        private List<Toon> FindToons(Account currentAccount, Realm currentRealm, string realmPath)
        {
            var toonDirs = Directory.EnumerateDirectories(realmPath);

            return toonDirs.Select(toonDir => new Toon
            {
                Name = toonDir.Split('\\').Last(),
                AccountName = currentAccount.Name,
                RealmName = currentRealm.Name
            }).ToList();
        }

        public object LoadConfig(MBConstants.ConfigFiles configFileType)
        {
            switch (configFileType)
            {
                case MBConstants.ConfigFiles.Application:
                    return DeserializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.SettingsFileName, typeof(Settings));

                case MBConstants.ConfigFiles.Accounts:
                    return DeserializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.AccountsFileName, typeof(MBAccountList));

                case MBConstants.ConfigFiles.Teams:
                    return DeserializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.TeamsFileName, typeof(MBTeamList));
            }
            return null;
        }

        public void WriteConfig(MBConstants.ConfigFiles configFileType, object toWrite)
        {
            switch (configFileType)
            {
                case MBConstants.ConfigFiles.Application:
                    {
                        toWrite.GetType().TypeCheckWithException(typeof(Settings));
                        SerializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.SettingsFileName, toWrite);
                    }
                    break;

                case MBConstants.ConfigFiles.Accounts:
                    {
                        toWrite.GetType().TypeCheckWithException(typeof(MBAccountList));
                        SerializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.AccountsFileName, toWrite);
                    }
                    break;

                case MBConstants.ConfigFiles.Teams:
                    {
                        toWrite.GetType().TypeCheckWithException(typeof(MBTeamList));
                        SerializeConfigFile(MBConstants.Settings.Directories.SettingFileDir, MBConstants.Settings.Files.TeamsFileName, toWrite);
                    }
                    break;
            }
        }

        private object DeserializeConfigFile(string directory, string file, Type type)
        {
            var dirPath = Path.Combine(WorkingDirectory, directory);
            var filePath = Path.Combine(dirPath, file);

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
                return null;
            }

            object ret;
            XmlSerializer xmlSerializer = new XmlSerializer(type);
            XmlTextReader xmlReader = new XmlTextReader(filePath);
            try
            {
                ret = xmlSerializer.Deserialize(xmlReader);
            }
            catch (Exception)
            {
                xmlReader.Close();
                return null;
            }
            xmlReader.Close();

            return ret;
        }

        private void SerializeConfigFile(string dir, string filename, object toWrite)
        {
            var desiredDir = Path.Combine(WorkingDirectory, dir);
            if (!Directory.Exists(desiredDir))
            {
                Directory.CreateDirectory(desiredDir);
            }

            XmlSerializer xmlSerializer = new XmlSerializer(toWrite.GetType());
            XmlTextWriter xmlWriter = new XmlTextWriter(Path.Combine(desiredDir, filename), Encoding.UTF8)
            {
                Formatting = Formatting.Indented,
                Indentation = 4
            };

            xmlSerializer.Serialize(xmlWriter, toWrite);
            xmlWriter.Close();
        }
    }
}