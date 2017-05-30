namespace MainApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TeamTab = new System.Windows.Forms.TabPage();
            this.TeamsGroupBox = new System.Windows.Forms.GroupBox();
            this.RenameTeamButton = new System.Windows.Forms.Button();
            this.CopyTeamButton = new System.Windows.Forms.Button();
            this.TeamSelectComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteTeamButton = new System.Windows.Forms.Button();
            this.CreateTeamButton = new System.Windows.Forms.Button();
            this.ToonManagerBox = new System.Windows.Forms.GroupBox();
            this.SetAccPasswordButton = new System.Windows.Forms.Button();
            this.TeamMemberOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.BuildMacros = new System.Windows.Forms.Button();
            this.TempBuildHKN = new System.Windows.Forms.Button();
            this.FTLOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.FTLKeyRAlt = new System.Windows.Forms.CheckBox();
            this.FTLKeyRCtrl = new System.Windows.Forms.CheckBox();
            this.FTLKeyRShift = new System.Windows.Forms.CheckBox();
            this.FTLKeyLAlt = new System.Windows.Forms.CheckBox();
            this.FTLKeyLCtrl = new System.Windows.Forms.CheckBox();
            this.FTLKeyLShift = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FTLOptionsUseInFTLCheckbox = new System.Windows.Forms.CheckBox();
            this.TeamMemberInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.MemberInfoIsMasterOfTeam = new System.Windows.Forms.CheckBox();
            this.MemberInfoNicknameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MemberInfoClassComboBox = new System.Windows.Forms.ComboBox();
            this.MemberInfoSpecializationComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveFromTeamButton = new System.Windows.Forms.Button();
            this.AddToTeamButton = new System.Windows.Forms.Button();
            this.TeamCompositionGroupBox = new System.Windows.Forms.GroupBox();
            this.CurrentTeamToonList = new System.Windows.Forms.ListBox();
            this.DetectedToonsGroupBox = new System.Windows.Forms.GroupBox();
            this.WarningLabelLogin = new System.Windows.Forms.Label();
            this.AccountTree = new System.Windows.Forms.TreeView();
            this.MacroTab = new System.Windows.Forms.TabPage();
            this.MacroUserControl = new MainApplication.MacroUserControl();
            this.HotkeyTab = new System.Windows.Forms.TabPage();
            this.HKNTab = new System.Windows.Forms.TabPage();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rESETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setWoWDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHKNDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reInstallJAMBAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.BuildAddon = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TeamTab.SuspendLayout();
            this.TeamsGroupBox.SuspendLayout();
            this.ToonManagerBox.SuspendLayout();
            this.TeamMemberOptionsGroupBox.SuspendLayout();
            this.FTLOptionsGroupBox.SuspendLayout();
            this.TeamMemberInfoGroupBox.SuspendLayout();
            this.TeamCompositionGroupBox.SuspendLayout();
            this.DetectedToonsGroupBox.SuspendLayout();
            this.MacroTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TeamTab);
            this.TabControl.Controls.Add(this.MacroTab);
            this.TabControl.Controls.Add(this.HotkeyTab);
            this.TabControl.Controls.Add(this.HKNTab);
            this.TabControl.Location = new System.Drawing.Point(12, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(984, 690);
            this.TabControl.TabIndex = 0;
            // 
            // TeamTab
            // 
            this.TeamTab.AutoScroll = true;
            this.TeamTab.Controls.Add(this.TeamsGroupBox);
            this.TeamTab.Controls.Add(this.ToonManagerBox);
            this.TeamTab.Location = new System.Drawing.Point(4, 22);
            this.TeamTab.Name = "TeamTab";
            this.TeamTab.Padding = new System.Windows.Forms.Padding(3);
            this.TeamTab.Size = new System.Drawing.Size(976, 664);
            this.TeamTab.TabIndex = 0;
            this.TeamTab.Text = "TeamBuilder";
            this.TeamTab.UseVisualStyleBackColor = true;
            // 
            // TeamsGroupBox
            // 
            this.TeamsGroupBox.Controls.Add(this.RenameTeamButton);
            this.TeamsGroupBox.Controls.Add(this.CopyTeamButton);
            this.TeamsGroupBox.Controls.Add(this.TeamSelectComboBox);
            this.TeamsGroupBox.Controls.Add(this.DeleteTeamButton);
            this.TeamsGroupBox.Controls.Add(this.CreateTeamButton);
            this.TeamsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.TeamsGroupBox.Name = "TeamsGroupBox";
            this.TeamsGroupBox.Size = new System.Drawing.Size(964, 50);
            this.TeamsGroupBox.TabIndex = 5;
            this.TeamsGroupBox.TabStop = false;
            this.TeamsGroupBox.Text = "Teams";
            // 
            // RenameTeamButton
            // 
            this.RenameTeamButton.Location = new System.Drawing.Point(523, 17);
            this.RenameTeamButton.Name = "RenameTeamButton";
            this.RenameTeamButton.Size = new System.Drawing.Size(75, 23);
            this.RenameTeamButton.TabIndex = 6;
            this.RenameTeamButton.Text = "Rename";
            this.RenameTeamButton.UseVisualStyleBackColor = true;
            // 
            // CopyTeamButton
            // 
            this.CopyTeamButton.Location = new System.Drawing.Point(442, 17);
            this.CopyTeamButton.Name = "CopyTeamButton";
            this.CopyTeamButton.Size = new System.Drawing.Size(75, 23);
            this.CopyTeamButton.TabIndex = 5;
            this.CopyTeamButton.Text = "Copy...";
            this.CopyTeamButton.UseVisualStyleBackColor = true;
            // 
            // TeamSelectComboBox
            // 
            this.TeamSelectComboBox.FormattingEnabled = true;
            this.TeamSelectComboBox.Location = new System.Drawing.Point(6, 18);
            this.TeamSelectComboBox.Name = "TeamSelectComboBox";
            this.TeamSelectComboBox.Size = new System.Drawing.Size(209, 21);
            this.TeamSelectComboBox.TabIndex = 1;
            this.TeamSelectComboBox.SelectedIndexChanged += new System.EventHandler(this.TeamSelectComboBox_SelectedIndexChanged);
            // 
            // DeleteTeamButton
            // 
            this.DeleteTeamButton.Location = new System.Drawing.Point(361, 17);
            this.DeleteTeamButton.Name = "DeleteTeamButton";
            this.DeleteTeamButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteTeamButton.TabIndex = 4;
            this.DeleteTeamButton.Text = "Delete";
            this.DeleteTeamButton.UseVisualStyleBackColor = true;
            this.DeleteTeamButton.Click += new System.EventHandler(this.DeleteTeamButton_Click);
            // 
            // CreateTeamButton
            // 
            this.CreateTeamButton.Location = new System.Drawing.Point(239, 17);
            this.CreateTeamButton.Name = "CreateTeamButton";
            this.CreateTeamButton.Size = new System.Drawing.Size(116, 23);
            this.CreateTeamButton.TabIndex = 3;
            this.CreateTeamButton.Text = "Create a team";
            this.CreateTeamButton.UseVisualStyleBackColor = true;
            this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
            // 
            // ToonManagerBox
            // 
            this.ToonManagerBox.Controls.Add(this.SetAccPasswordButton);
            this.ToonManagerBox.Controls.Add(this.TeamMemberOptionsGroupBox);
            this.ToonManagerBox.Controls.Add(this.RemoveFromTeamButton);
            this.ToonManagerBox.Controls.Add(this.AddToTeamButton);
            this.ToonManagerBox.Controls.Add(this.TeamCompositionGroupBox);
            this.ToonManagerBox.Controls.Add(this.DetectedToonsGroupBox);
            this.ToonManagerBox.Enabled = false;
            this.ToonManagerBox.Location = new System.Drawing.Point(6, 62);
            this.ToonManagerBox.Name = "ToonManagerBox";
            this.ToonManagerBox.Size = new System.Drawing.Size(963, 596);
            this.ToonManagerBox.TabIndex = 0;
            this.ToonManagerBox.TabStop = false;
            this.ToonManagerBox.Text = "Toon Management";
            // 
            // SetAccPasswordButton
            // 
            this.SetAccPasswordButton.ForeColor = System.Drawing.Color.Red;
            this.SetAccPasswordButton.Location = new System.Drawing.Point(6, 332);
            this.SetAccPasswordButton.Name = "SetAccPasswordButton";
            this.SetAccPasswordButton.Size = new System.Drawing.Size(212, 23);
            this.SetAccPasswordButton.TabIndex = 4;
            this.SetAccPasswordButton.Text = "Set Account Password";
            this.SetAccPasswordButton.UseVisualStyleBackColor = true;
            this.SetAccPasswordButton.Click += new System.EventHandler(this.SetAccPasswordButton_Click);
            // 
            // TeamMemberOptionsGroupBox
            // 
            this.TeamMemberOptionsGroupBox.Controls.Add(this.BuildAddon);
            this.TeamMemberOptionsGroupBox.Controls.Add(this.BuildMacros);
            this.TeamMemberOptionsGroupBox.Controls.Add(this.TempBuildHKN);
            this.TeamMemberOptionsGroupBox.Controls.Add(this.FTLOptionsGroupBox);
            this.TeamMemberOptionsGroupBox.Controls.Add(this.TeamMemberInfoGroupBox);
            this.TeamMemberOptionsGroupBox.Enabled = false;
            this.TeamMemberOptionsGroupBox.Location = new System.Drawing.Point(517, 19);
            this.TeamMemberOptionsGroupBox.Name = "TeamMemberOptionsGroupBox";
            this.TeamMemberOptionsGroupBox.Size = new System.Drawing.Size(440, 307);
            this.TeamMemberOptionsGroupBox.TabIndex = 3;
            this.TeamMemberOptionsGroupBox.TabStop = false;
            this.TeamMemberOptionsGroupBox.Text = "Team Member Options";
            // 
            // BuildMacros
            // 
            this.BuildMacros.Location = new System.Drawing.Point(160, 129);
            this.BuildMacros.Name = "BuildMacros";
            this.BuildMacros.Size = new System.Drawing.Size(141, 23);
            this.BuildMacros.TabIndex = 3;
            this.BuildMacros.Text = "TestBuildMacros";
            this.BuildMacros.UseVisualStyleBackColor = true;
            this.BuildMacros.Click += new System.EventHandler(this.BuildMacros_Click);
            // 
            // TempBuildHKN
            // 
            this.TempBuildHKN.Location = new System.Drawing.Point(160, 99);
            this.TempBuildHKN.Name = "TempBuildHKN";
            this.TempBuildHKN.Size = new System.Drawing.Size(75, 23);
            this.TempBuildHKN.TabIndex = 2;
            this.TempBuildHKN.Text = "Build HKN";
            this.TempBuildHKN.UseVisualStyleBackColor = true;
            this.TempBuildHKN.Click += new System.EventHandler(this.TempBuildHKN_Click);
            // 
            // FTLOptionsGroupBox
            // 
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyRAlt);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyRCtrl);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyRShift);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyLAlt);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyLCtrl);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLKeyLShift);
            this.FTLOptionsGroupBox.Controls.Add(this.label2);
            this.FTLOptionsGroupBox.Controls.Add(this.FTLOptionsUseInFTLCheckbox);
            this.FTLOptionsGroupBox.Location = new System.Drawing.Point(7, 98);
            this.FTLOptionsGroupBox.Name = "FTLOptionsGroupBox";
            this.FTLOptionsGroupBox.Size = new System.Drawing.Size(146, 203);
            this.FTLOptionsGroupBox.TabIndex = 1;
            this.FTLOptionsGroupBox.TabStop = false;
            this.FTLOptionsGroupBox.Text = "FTL Options";
            this.FTLOptionsGroupBox.Enter += new System.EventHandler(this.FTLOptionsGroupBox_Enter);
            // 
            // FTLKeyRAlt
            // 
            this.FTLKeyRAlt.AutoSize = true;
            this.FTLKeyRAlt.Location = new System.Drawing.Point(9, 172);
            this.FTLKeyRAlt.Name = "FTLKeyRAlt";
            this.FTLKeyRAlt.Size = new System.Drawing.Size(46, 17);
            this.FTLKeyRAlt.TabIndex = 8;
            this.FTLKeyRAlt.Text = "RAlt";
            this.FTLKeyRAlt.UseVisualStyleBackColor = true;
            // 
            // FTLKeyRCtrl
            // 
            this.FTLKeyRCtrl.AutoSize = true;
            this.FTLKeyRCtrl.Location = new System.Drawing.Point(9, 149);
            this.FTLKeyRCtrl.Name = "FTLKeyRCtrl";
            this.FTLKeyRCtrl.Size = new System.Drawing.Size(49, 17);
            this.FTLKeyRCtrl.TabIndex = 7;
            this.FTLKeyRCtrl.Text = "RCtrl";
            this.FTLKeyRCtrl.UseVisualStyleBackColor = true;
            // 
            // FTLKeyRShift
            // 
            this.FTLKeyRShift.AutoSize = true;
            this.FTLKeyRShift.Location = new System.Drawing.Point(9, 126);
            this.FTLKeyRShift.Name = "FTLKeyRShift";
            this.FTLKeyRShift.Size = new System.Drawing.Size(55, 17);
            this.FTLKeyRShift.TabIndex = 6;
            this.FTLKeyRShift.Text = "RShift";
            this.FTLKeyRShift.UseVisualStyleBackColor = true;
            // 
            // FTLKeyLAlt
            // 
            this.FTLKeyLAlt.AutoSize = true;
            this.FTLKeyLAlt.Location = new System.Drawing.Point(9, 103);
            this.FTLKeyLAlt.Name = "FTLKeyLAlt";
            this.FTLKeyLAlt.Size = new System.Drawing.Size(44, 17);
            this.FTLKeyLAlt.TabIndex = 5;
            this.FTLKeyLAlt.Text = "LAlt";
            this.FTLKeyLAlt.UseVisualStyleBackColor = true;
            // 
            // FTLKeyLCtrl
            // 
            this.FTLKeyLCtrl.AutoSize = true;
            this.FTLKeyLCtrl.Location = new System.Drawing.Point(9, 80);
            this.FTLKeyLCtrl.Name = "FTLKeyLCtrl";
            this.FTLKeyLCtrl.Size = new System.Drawing.Size(47, 17);
            this.FTLKeyLCtrl.TabIndex = 4;
            this.FTLKeyLCtrl.Text = "LCtrl";
            this.FTLKeyLCtrl.UseVisualStyleBackColor = true;
            // 
            // FTLKeyLShift
            // 
            this.FTLKeyLShift.AutoSize = true;
            this.FTLKeyLShift.Location = new System.Drawing.Point(9, 57);
            this.FTLKeyLShift.Name = "FTLKeyLShift";
            this.FTLKeyLShift.Size = new System.Drawing.Size(53, 17);
            this.FTLKeyLShift.TabIndex = 3;
            this.FTLKeyLShift.Text = "LShift";
            this.FTLKeyLShift.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FTL Keys to use:";
            // 
            // FTLOptionsUseInFTLCheckbox
            // 
            this.FTLOptionsUseInFTLCheckbox.AutoSize = true;
            this.FTLOptionsUseInFTLCheckbox.Location = new System.Drawing.Point(9, 20);
            this.FTLOptionsUseInFTLCheckbox.Name = "FTLOptionsUseInFTLCheckbox";
            this.FTLOptionsUseInFTLCheckbox.Size = new System.Drawing.Size(78, 17);
            this.FTLOptionsUseInFTLCheckbox.TabIndex = 1;
            this.FTLOptionsUseInFTLCheckbox.Text = "Use in FTL";
            this.FTLOptionsUseInFTLCheckbox.UseVisualStyleBackColor = true;
            this.FTLOptionsUseInFTLCheckbox.CheckedChanged += new System.EventHandler(this.FTLOptionsUseInFTLCheckbox_CheckedChanged);
            // 
            // TeamMemberInfoGroupBox
            // 
            this.TeamMemberInfoGroupBox.Controls.Add(this.MemberInfoIsMasterOfTeam);
            this.TeamMemberInfoGroupBox.Controls.Add(this.MemberInfoNicknameTextbox);
            this.TeamMemberInfoGroupBox.Controls.Add(this.label1);
            this.TeamMemberInfoGroupBox.Controls.Add(this.MemberInfoClassComboBox);
            this.TeamMemberInfoGroupBox.Controls.Add(this.MemberInfoSpecializationComboBox);
            this.TeamMemberInfoGroupBox.Location = new System.Drawing.Point(6, 20);
            this.TeamMemberInfoGroupBox.Name = "TeamMemberInfoGroupBox";
            this.TeamMemberInfoGroupBox.Size = new System.Drawing.Size(428, 72);
            this.TeamMemberInfoGroupBox.TabIndex = 0;
            this.TeamMemberInfoGroupBox.TabStop = false;
            this.TeamMemberInfoGroupBox.Text = "Member info";
            // 
            // MemberInfoIsMasterOfTeam
            // 
            this.MemberInfoIsMasterOfTeam.AutoSize = true;
            this.MemberInfoIsMasterOfTeam.Location = new System.Drawing.Point(10, 49);
            this.MemberInfoIsMasterOfTeam.Name = "MemberInfoIsMasterOfTeam";
            this.MemberInfoIsMasterOfTeam.Size = new System.Drawing.Size(125, 17);
            this.MemberInfoIsMasterOfTeam.TabIndex = 3;
            this.MemberInfoIsMasterOfTeam.Text = "Is Master of the team";
            this.MemberInfoIsMasterOfTeam.UseVisualStyleBackColor = true;
            this.MemberInfoIsMasterOfTeam.CheckedChanged += new System.EventHandler(this.MemberInfoIsMasterOfTeam_CheckedChanged);
            // 
            // MemberInfoNicknameTextbox
            // 
            this.MemberInfoNicknameTextbox.Enabled = false;
            this.MemberInfoNicknameTextbox.Location = new System.Drawing.Point(68, 19);
            this.MemberInfoNicknameTextbox.Name = "MemberInfoNicknameTextbox";
            this.MemberInfoNicknameTextbox.Size = new System.Drawing.Size(100, 20);
            this.MemberInfoNicknameTextbox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nickname:";
            // 
            // MemberInfoClassComboBox
            // 
            this.MemberInfoClassComboBox.FormattingEnabled = true;
            this.MemberInfoClassComboBox.Location = new System.Drawing.Point(174, 19);
            this.MemberInfoClassComboBox.Name = "MemberInfoClassComboBox";
            this.MemberInfoClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.MemberInfoClassComboBox.TabIndex = 1;
            this.MemberInfoClassComboBox.Text = "Class";
            this.MemberInfoClassComboBox.SelectedIndexChanged += new System.EventHandler(this.MemberInfoClassComboBox_SelectedIndexChanged);
            // 
            // MemberInfoSpecializationComboBox
            // 
            this.MemberInfoSpecializationComboBox.FormattingEnabled = true;
            this.MemberInfoSpecializationComboBox.Location = new System.Drawing.Point(301, 19);
            this.MemberInfoSpecializationComboBox.Name = "MemberInfoSpecializationComboBox";
            this.MemberInfoSpecializationComboBox.Size = new System.Drawing.Size(121, 21);
            this.MemberInfoSpecializationComboBox.TabIndex = 0;
            this.MemberInfoSpecializationComboBox.Text = "Specialization";
            this.MemberInfoSpecializationComboBox.SelectedIndexChanged += new System.EventHandler(this.MemberInfoSpecializationComboBox_SelectedIndexChanged);
            // 
            // RemoveFromTeamButton
            // 
            this.RemoveFromTeamButton.Location = new System.Drawing.Point(224, 166);
            this.RemoveFromTeamButton.Name = "RemoveFromTeamButton";
            this.RemoveFromTeamButton.Size = new System.Drawing.Size(35, 23);
            this.RemoveFromTeamButton.TabIndex = 2;
            this.RemoveFromTeamButton.Text = "<<";
            this.RemoveFromTeamButton.UseVisualStyleBackColor = true;
            this.RemoveFromTeamButton.Click += new System.EventHandler(this.RemoveFromTeamButton_Click);
            // 
            // AddToTeamButton
            // 
            this.AddToTeamButton.Location = new System.Drawing.Point(224, 137);
            this.AddToTeamButton.Name = "AddToTeamButton";
            this.AddToTeamButton.Size = new System.Drawing.Size(35, 23);
            this.AddToTeamButton.TabIndex = 1;
            this.AddToTeamButton.Text = ">>";
            this.AddToTeamButton.UseVisualStyleBackColor = true;
            this.AddToTeamButton.Click += new System.EventHandler(this.AddToTeamButton_Click);
            // 
            // TeamCompositionGroupBox
            // 
            this.TeamCompositionGroupBox.Controls.Add(this.CurrentTeamToonList);
            this.TeamCompositionGroupBox.Location = new System.Drawing.Point(265, 19);
            this.TeamCompositionGroupBox.Name = "TeamCompositionGroupBox";
            this.TeamCompositionGroupBox.Size = new System.Drawing.Size(212, 307);
            this.TeamCompositionGroupBox.TabIndex = 1;
            this.TeamCompositionGroupBox.TabStop = false;
            this.TeamCompositionGroupBox.Text = "Team Composition";
            // 
            // CurrentTeamToonList
            // 
            this.CurrentTeamToonList.FormattingEnabled = true;
            this.CurrentTeamToonList.Location = new System.Drawing.Point(7, 20);
            this.CurrentTeamToonList.Name = "CurrentTeamToonList";
            this.CurrentTeamToonList.Size = new System.Drawing.Size(199, 251);
            this.CurrentTeamToonList.TabIndex = 0;
            this.CurrentTeamToonList.SelectedIndexChanged += new System.EventHandler(this.CurrentTeamToonList_SelectedIndexChanged);
            this.CurrentTeamToonList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentTeamToonList_KeyPress);
            // 
            // DetectedToonsGroupBox
            // 
            this.DetectedToonsGroupBox.Controls.Add(this.WarningLabelLogin);
            this.DetectedToonsGroupBox.Controls.Add(this.AccountTree);
            this.DetectedToonsGroupBox.Location = new System.Drawing.Point(6, 19);
            this.DetectedToonsGroupBox.Name = "DetectedToonsGroupBox";
            this.DetectedToonsGroupBox.Size = new System.Drawing.Size(212, 307);
            this.DetectedToonsGroupBox.TabIndex = 0;
            this.DetectedToonsGroupBox.TabStop = false;
            this.DetectedToonsGroupBox.Text = "Detected Toons";
            // 
            // WarningLabelLogin
            // 
            this.WarningLabelLogin.AutoSize = true;
            this.WarningLabelLogin.Location = new System.Drawing.Point(6, 275);
            this.WarningLabelLogin.MaximumSize = new System.Drawing.Size(200, 0);
            this.WarningLabelLogin.Name = "WarningLabelLogin";
            this.WarningLabelLogin.Size = new System.Drawing.Size(183, 26);
            this.WarningLabelLogin.TabIndex = 1;
            this.WarningLabelLogin.Text = "Make sure you have logged in to the accounts and toons at least once!";
            // 
            // AccountTree
            // 
            this.AccountTree.Location = new System.Drawing.Point(6, 19);
            this.AccountTree.Name = "AccountTree";
            this.AccountTree.Size = new System.Drawing.Size(200, 253);
            this.AccountTree.TabIndex = 0;
            this.AccountTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AccountTree_MouseDoubleClick);
            // 
            // MacroTab
            // 
            this.MacroTab.Controls.Add(this.MacroUserControl);
            this.MacroTab.Location = new System.Drawing.Point(4, 22);
            this.MacroTab.Name = "MacroTab";
            this.MacroTab.Padding = new System.Windows.Forms.Padding(3);
            this.MacroTab.Size = new System.Drawing.Size(976, 664);
            this.MacroTab.TabIndex = 1;
            this.MacroTab.Text = "Macros";
            this.MacroTab.UseVisualStyleBackColor = true;
            // 
            // MacroUserControl
            // 
            this.MacroUserControl.Location = new System.Drawing.Point(0, 0);
            this.MacroUserControl.Name = "MacroUserControl";
            this.MacroUserControl.Size = new System.Drawing.Size(976, 664);
            this.MacroUserControl.TabIndex = 0;
            // 
            // HotkeyTab
            // 
            this.HotkeyTab.Location = new System.Drawing.Point(4, 22);
            this.HotkeyTab.Name = "HotkeyTab";
            this.HotkeyTab.Padding = new System.Windows.Forms.Padding(3);
            this.HotkeyTab.Size = new System.Drawing.Size(976, 664);
            this.HotkeyTab.TabIndex = 2;
            this.HotkeyTab.Text = "Hotkeys";
            this.HotkeyTab.UseVisualStyleBackColor = true;
            // 
            // HKNTab
            // 
            this.HKNTab.Location = new System.Drawing.Point(4, 22);
            this.HKNTab.Name = "HKNTab";
            this.HKNTab.Padding = new System.Windows.Forms.Padding(3);
            this.HKNTab.Size = new System.Drawing.Size(976, 664);
            this.HKNTab.TabIndex = 3;
            this.HKNTab.Text = "HKN";
            this.HKNTab.UseVisualStyleBackColor = true;
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.rESETToolStripMenuItem,
            this.setWoWDirectoryToolStripMenuItem,
            this.setHKNDirectoryToolStripMenuItem,
            this.reInstallJAMBAToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // rESETToolStripMenuItem
            // 
            this.rESETToolStripMenuItem.Name = "rESETToolStripMenuItem";
            this.rESETToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.rESETToolStripMenuItem.Text = "RESET";
            this.rESETToolStripMenuItem.Click += new System.EventHandler(this.rESETToolStripMenuItem_Click);
            // 
            // setWoWDirectoryToolStripMenuItem
            // 
            this.setWoWDirectoryToolStripMenuItem.Name = "setWoWDirectoryToolStripMenuItem";
            this.setWoWDirectoryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setWoWDirectoryToolStripMenuItem.Text = "Set WoW Directory";
            // 
            // setHKNDirectoryToolStripMenuItem
            // 
            this.setHKNDirectoryToolStripMenuItem.Name = "setHKNDirectoryToolStripMenuItem";
            this.setHKNDirectoryToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.setHKNDirectoryToolStripMenuItem.Text = "Set HKN Directory";
            // 
            // reInstallJAMBAToolStripMenuItem
            // 
            this.reInstallJAMBAToolStripMenuItem.Name = "reInstallJAMBAToolStripMenuItem";
            this.reInstallJAMBAToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.reInstallJAMBAToolStripMenuItem.Text = "(Re)Install JAMBA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // BuildAddon
            // 
            this.BuildAddon.Location = new System.Drawing.Point(160, 159);
            this.BuildAddon.Name = "BuildAddon";
            this.BuildAddon.Size = new System.Drawing.Size(141, 23);
            this.BuildAddon.TabIndex = 4;
            this.BuildAddon.Text = "Test Build Addon";
            this.BuildAddon.UseVisualStyleBackColor = true;
            this.BuildAddon.Click += new System.EventHandler(this.BuildAddon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MBoxManager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.TeamTab.ResumeLayout(false);
            this.TeamsGroupBox.ResumeLayout(false);
            this.ToonManagerBox.ResumeLayout(false);
            this.TeamMemberOptionsGroupBox.ResumeLayout(false);
            this.FTLOptionsGroupBox.ResumeLayout(false);
            this.FTLOptionsGroupBox.PerformLayout();
            this.TeamMemberInfoGroupBox.ResumeLayout(false);
            this.TeamMemberInfoGroupBox.PerformLayout();
            this.TeamCompositionGroupBox.ResumeLayout(false);
            this.DetectedToonsGroupBox.ResumeLayout(false);
            this.DetectedToonsGroupBox.PerformLayout();
            this.MacroTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TeamTab;
        private System.Windows.Forms.TabPage MacroTab;
        private System.Windows.Forms.TabPage HotkeyTab;
        private System.Windows.Forms.GroupBox ToonManagerBox;
        private System.Windows.Forms.GroupBox TeamsGroupBox;
        private System.Windows.Forms.ComboBox TeamSelectComboBox;
        private System.Windows.Forms.Button DeleteTeamButton;
        private System.Windows.Forms.Button CreateTeamButton;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button CopyTeamButton;
        private System.Windows.Forms.ToolStripMenuItem rESETToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.TabPage HKNTab;
        private System.Windows.Forms.ToolStripMenuItem setWoWDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHKNDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reInstallJAMBAToolStripMenuItem;
        private System.Windows.Forms.GroupBox TeamCompositionGroupBox;
        private System.Windows.Forms.ListBox CurrentTeamToonList;
        private System.Windows.Forms.GroupBox DetectedToonsGroupBox;
        private System.Windows.Forms.Label WarningLabelLogin;
        private System.Windows.Forms.TreeView AccountTree;
        private System.Windows.Forms.Button RemoveFromTeamButton;
        private System.Windows.Forms.Button AddToTeamButton;
        private System.Windows.Forms.GroupBox TeamMemberOptionsGroupBox;
        private System.Windows.Forms.GroupBox TeamMemberInfoGroupBox;
        private System.Windows.Forms.ComboBox MemberInfoClassComboBox;
        private System.Windows.Forms.ComboBox MemberInfoSpecializationComboBox;
        private System.Windows.Forms.GroupBox FTLOptionsGroupBox;
        private System.Windows.Forms.TextBox MemberInfoNicknameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RenameTeamButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox FTLOptionsUseInFTLCheckbox;
        private System.Windows.Forms.CheckBox MemberInfoIsMasterOfTeam;
        private MacroUserControl MacroUserControl;
        private System.Windows.Forms.Button SetAccPasswordButton;
        private System.Windows.Forms.CheckBox FTLKeyRAlt;
        private System.Windows.Forms.CheckBox FTLKeyRCtrl;
        private System.Windows.Forms.CheckBox FTLKeyRShift;
        private System.Windows.Forms.CheckBox FTLKeyLAlt;
        private System.Windows.Forms.CheckBox FTLKeyLCtrl;
        private System.Windows.Forms.CheckBox FTLKeyLShift;
        private System.Windows.Forms.Button TempBuildHKN;
        private System.Windows.Forms.Button BuildMacros;
        private System.Windows.Forms.Button BuildAddon;
    }
}

