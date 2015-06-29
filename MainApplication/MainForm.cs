using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Constants;
using Extensions;
using JambaManager;
using SettingsManager;
using TeamManager;

namespace MainApplication
{
    public partial class MainForm : Form
    {
        private MBSettingsManager _settingsManager;
        private MBTeamManager _teamManager;
        public MainForm()
        {
            InitializeComponent();
        }
        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = MessageBox.Show("Do you want to quit?", "Quit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return res;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == DialogResult.OK)
            {
                _settingsManager.WriteConfig(MBConstants.ConfigFiles.Application, _settingsManager.mainSettings);
                _settingsManager.WriteConfig(MBConstants.ConfigFiles.Accounts, _teamManager.AccountList);
                _settingsManager.WriteConfig(MBConstants.ConfigFiles.Teams, _teamManager.TeamList);

                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MacroModifier mm = new MacroModifier { DifferentiateSides = false, LAlt = true, LCtrl = false, LShift = true };
            var str = mm.BuildString();

            //Initialize the application and it's modules
            //create a settings manager
            _settingsManager = new MBSettingsManager();
            //load the application config
            var success = _settingsManager.LoadConfig();

            if (!success)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                MBAccountList accountList = _settingsManager.GenerateAccountsList();
                _settingsManager.WriteConfig(MBConstants.ConfigFiles.Accounts, accountList);

                //create a team manager

                _teamManager = new MBTeamManager(accountList, _settingsManager.LoadConfig(MBConstants.ConfigFiles.Teams) as MBTeamList);

                CreateAccountTreeView();
            RefreshTeams();
            }
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TextInputForm testDialog = new TextInputForm();

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {
                var txt = testDialog.Text;
                var teamName = txt.OnlyLettersAndDigits();

                if (string.IsNullOrEmpty(teamName)) return;

                _teamManager.CreateTeam(teamName);

                var team = _teamManager.GetTeam(teamName);
                _teamManager.SetCurrentTeam(team);
                RefreshTeams();

                CreateAccountTreeView();
                RefreshToonManager();
            }
        }

        private void RefreshTeams()
        {
            TeamSelectComboBox.DisplayMember = "Name";
            TeamSelectComboBox.DataSource = new BindingSource(_teamManager.TeamList.Teams, null);
            TeamSelectComboBox.SelectedItem = _teamManager.TeamList.ActiveTeam;
        }

        private void RefreshCurrentTeam()
        {
            CurrentTeamToonList.DisplayMember = "Name";
            CurrentTeamToonList.DataSource = new BindingSource(_teamManager.TeamList.ActiveTeam.ToonsInTeam, null);
        }

        private void CreateAccountTreeView(bool forceRefresh = false)
        {
            if (AccountTree.Nodes.Count == 0 || forceRefresh)
            {
                if (forceRefresh)
                {
                    AccountTree.Nodes.Clear();
                }

                foreach (var account in _teamManager.AccountList.Accounts)
                {
                    var node = new TreeNode(account.Name);
                    foreach (var realm in account.Realms)
                    {
                        var realmNode = new TreeNode(realm.Name);
                        foreach (var toon in realm.Toons)
                        {
                            realmNode.Nodes.Add(toon.Name);
                        }
                        node.Nodes.Add(realmNode);
                    }
                    AccountTree.Nodes.Add(node);
                }
            }
        }

        private void AddToTeamButton_Click(object sender, EventArgs e)
        {
            AddToonToTeam(AccountTree.SelectedNode);
        }

        private void TeamSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var combobox = sender as ComboBox;
            if (combobox != null)
            {
                if (_teamManager.TeamList.ActiveTeam == null)
                {
                    CreateAccountTreeView();
                }

                var currentTeam = combobox.SelectedItem as Team;

                if (currentTeam == null) return;

                _teamManager.SetCurrentTeam(currentTeam);
                RefreshCurrentTeam();
                RefreshToonManager();
            }
        }

        private void RefreshToonManager()
        {
            ToonManagerBox.Enabled = _teamManager.TeamList != null && _teamManager.TeamList.ActiveTeam != null;
        }

        private void AccountTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddToonToTeam(AccountTree.SelectedNode);
        }

        private void AddToonToTeam(TreeNode selectedNode)
        {
            if (selectedNode == null) return;

            var splitted = selectedNode.FullPath.Split('\\');
            var splitCount = splitted.Length;
            if (splitCount < 3) // Accout/Realm/Toon
            {
                return;
            }

            var accountName = splitted[0];
            var realmName = splitted[1];
            var toonName = splitted[2];

            var toon = _teamManager.AccountList.Accounts.First(f => f.Name.Equals(accountName)).Realms.First(f => f.Name.Equals(realmName)).Toons.First(f => f.Name.Equals(toonName));

            _teamManager.TeamList.ActiveTeam.AddToon(toon);
            RefreshCurrentTeam();
        }

        private void CurrentTeamToonList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals('\b') && CurrentTeamToonList.SelectedIndex != -1)
            {
                _teamManager.TeamList.ActiveTeam.RemoveToon(CurrentTeamToonList.SelectedItem.ToString());
                RefreshCurrentTeam();
                if (CurrentTeamToonList.Items.Count > 0)
                {
                    CurrentTeamToonList.SelectedIndex = 0;
                }
            }
        }

        private void DeleteTeamButton_Click(object sender, EventArgs e)
        {

        }

        private void CurrentTeamToonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentTeamToonList.SelectedIndex != -1)
            {
                var toonName = CurrentTeamToonList.SelectedItem.ToString();
                LoadToonInfo(toonName);
            }
        }

        private void LoadToonInfo(string toonName)
        {
            TeamMemberOptionsGroupBox.Enabled = _teamManager.TeamList.ActiveTeam.ContainsToon(toonName);
            MemberInfoNicknameTextbox.Text = toonName;

            var toon = _teamManager.TeamList.ActiveTeam.GetToon(toonName);

            MemberInfoIsMasterOfTeam.DataBindings.Clear();
            MemberInfoIsMasterOfTeam.DataBindings.Add(new Binding("Checked", toon, "FTLToon"));

            MemberInfoClassComboBox.DisplayMember = "Value";
            MemberInfoClassComboBox.ValueMember = "Key";
            MemberInfoClassComboBox.DataSource = new BindingSource(MBConstants.ToonDescriptor.Classes, null);
        }

        private void MemberInfoClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MemberInfoClassComboBox.SelectedIndex != -1)
            {
                var currentClass = (MBConstants.ToonClasses)MemberInfoClassComboBox.SelectedValue;

                MemberInfoSpecializationComboBox.DataSource = new BindingSource(MBConstants.ToonDescriptor.Specializations[currentClass], null);
                MemberInfoSpecializationComboBox.DisplayMember = "Value";
                MemberInfoSpecializationComboBox.ValueMember = "Key";
            }
        }

        private void MemberInfoSpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RemoveFromTeamButton_Click(object sender, EventArgs e)
        {

        }
    }
}
