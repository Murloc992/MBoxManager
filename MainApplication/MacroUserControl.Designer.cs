namespace MainApplication
{
    partial class MacroUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MacroCategoryListBox = new System.Windows.Forms.ListBox();
            this.MainMacroGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateCategoryButton = new System.Windows.Forms.Button();
            this.TeamToonsListBox = new System.Windows.Forms.ListBox();
            this.MacroListBox = new System.Windows.Forms.ListBox();
            this.AddNewMacroButton = new System.Windows.Forms.Button();
            this.RemoveMacroButton = new System.Windows.Forms.Button();
            this.MacroNameEditBox = new System.Windows.Forms.TextBox();
            this.MacroKeybindEditBox = new System.Windows.Forms.TextBox();
            this.MacroTextEditBox = new System.Windows.Forms.TextBox();
            this.MacroNameLabel = new System.Windows.Forms.Label();
            this.MacroKeybindLabel = new System.Windows.Forms.Label();
            this.MacroTextLabel = new System.Windows.Forms.Label();
            this.MainMacroGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MacroCategoryListBox
            // 
            this.MacroCategoryListBox.FormattingEnabled = true;
            this.MacroCategoryListBox.Location = new System.Drawing.Point(6, 19);
            this.MacroCategoryListBox.Name = "MacroCategoryListBox";
            this.MacroCategoryListBox.Size = new System.Drawing.Size(134, 173);
            this.MacroCategoryListBox.TabIndex = 0;
            // 
            // MainMacroGroupBox
            // 
            this.MainMacroGroupBox.Controls.Add(this.MacroTextLabel);
            this.MainMacroGroupBox.Controls.Add(this.MacroKeybindLabel);
            this.MainMacroGroupBox.Controls.Add(this.MacroNameLabel);
            this.MainMacroGroupBox.Controls.Add(this.MacroTextEditBox);
            this.MainMacroGroupBox.Controls.Add(this.MacroKeybindEditBox);
            this.MainMacroGroupBox.Controls.Add(this.MacroNameEditBox);
            this.MainMacroGroupBox.Controls.Add(this.RemoveMacroButton);
            this.MainMacroGroupBox.Controls.Add(this.AddNewMacroButton);
            this.MainMacroGroupBox.Controls.Add(this.MacroListBox);
            this.MainMacroGroupBox.Controls.Add(this.CreateCategoryButton);
            this.MainMacroGroupBox.Controls.Add(this.TeamToonsListBox);
            this.MainMacroGroupBox.Controls.Add(this.MacroCategoryListBox);
            this.MainMacroGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MainMacroGroupBox.Name = "MainMacroGroupBox";
            this.MainMacroGroupBox.Size = new System.Drawing.Size(970, 658);
            this.MainMacroGroupBox.TabIndex = 1;
            this.MainMacroGroupBox.TabStop = false;
            this.MainMacroGroupBox.Text = "Macros n Stuff";
            // 
            // CreateCategoryButton
            // 
            this.CreateCategoryButton.Location = new System.Drawing.Point(6, 198);
            this.CreateCategoryButton.Name = "CreateCategoryButton";
            this.CreateCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.CreateCategoryButton.TabIndex = 2;
            this.CreateCategoryButton.Text = "Create";
            this.CreateCategoryButton.UseVisualStyleBackColor = true;
            this.CreateCategoryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeamToonsListBox
            // 
            this.TeamToonsListBox.FormattingEnabled = true;
            this.TeamToonsListBox.Location = new System.Drawing.Point(146, 19);
            this.TeamToonsListBox.Name = "TeamToonsListBox";
            this.TeamToonsListBox.Size = new System.Drawing.Size(132, 173);
            this.TeamToonsListBox.TabIndex = 1;
            // 
            // MacroListBox
            // 
            this.MacroListBox.FormattingEnabled = true;
            this.MacroListBox.Location = new System.Drawing.Point(285, 20);
            this.MacroListBox.Name = "MacroListBox";
            this.MacroListBox.Size = new System.Drawing.Size(120, 173);
            this.MacroListBox.TabIndex = 3;
            // 
            // AddNewMacroButton
            // 
            this.AddNewMacroButton.Location = new System.Drawing.Point(285, 197);
            this.AddNewMacroButton.Name = "AddNewMacroButton";
            this.AddNewMacroButton.Size = new System.Drawing.Size(52, 23);
            this.AddNewMacroButton.TabIndex = 4;
            this.AddNewMacroButton.Text = "Add";
            this.AddNewMacroButton.UseVisualStyleBackColor = true;
            // 
            // RemoveMacroButton
            // 
            this.RemoveMacroButton.Location = new System.Drawing.Point(343, 197);
            this.RemoveMacroButton.Name = "RemoveMacroButton";
            this.RemoveMacroButton.Size = new System.Drawing.Size(62, 23);
            this.RemoveMacroButton.TabIndex = 5;
            this.RemoveMacroButton.Text = "Remove";
            this.RemoveMacroButton.UseVisualStyleBackColor = true;
            // 
            // MacroNameEditBox
            // 
            this.MacroNameEditBox.Location = new System.Drawing.Point(528, 20);
            this.MacroNameEditBox.Name = "MacroNameEditBox";
            this.MacroNameEditBox.Size = new System.Drawing.Size(100, 20);
            this.MacroNameEditBox.TabIndex = 6;
            // 
            // MacroKeybindEditBox
            // 
            this.MacroKeybindEditBox.Location = new System.Drawing.Point(528, 47);
            this.MacroKeybindEditBox.Name = "MacroKeybindEditBox";
            this.MacroKeybindEditBox.Size = new System.Drawing.Size(100, 20);
            this.MacroKeybindEditBox.TabIndex = 7;
            // 
            // MacroTextEditBox
            // 
            this.MacroTextEditBox.Location = new System.Drawing.Point(528, 74);
            this.MacroTextEditBox.Multiline = true;
            this.MacroTextEditBox.Name = "MacroTextEditBox";
            this.MacroTextEditBox.Size = new System.Drawing.Size(436, 119);
            this.MacroTextEditBox.TabIndex = 8;
            // 
            // MacroNameLabel
            // 
            this.MacroNameLabel.AutoSize = true;
            this.MacroNameLabel.Location = new System.Drawing.Point(487, 23);
            this.MacroNameLabel.Name = "MacroNameLabel";
            this.MacroNameLabel.Size = new System.Drawing.Size(38, 13);
            this.MacroNameLabel.TabIndex = 9;
            this.MacroNameLabel.Text = "Name:";
            // 
            // MacroKeybindLabel
            // 
            this.MacroKeybindLabel.AutoSize = true;
            this.MacroKeybindLabel.Location = new System.Drawing.Point(474, 50);
            this.MacroKeybindLabel.Name = "MacroKeybindLabel";
            this.MacroKeybindLabel.Size = new System.Drawing.Size(48, 13);
            this.MacroKeybindLabel.TabIndex = 10;
            this.MacroKeybindLabel.Text = "Keybind:";
            // 
            // MacroTextLabel
            // 
            this.MacroTextLabel.AutoSize = true;
            this.MacroTextLabel.Location = new System.Drawing.Point(487, 77);
            this.MacroTextLabel.Name = "MacroTextLabel";
            this.MacroTextLabel.Size = new System.Drawing.Size(31, 13);
            this.MacroTextLabel.TabIndex = 11;
            this.MacroTextLabel.Text = "Text:";
            // 
            // MacroUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainMacroGroupBox);
            this.Name = "MacroUserControl";
            this.Size = new System.Drawing.Size(976, 664);
            this.MainMacroGroupBox.ResumeLayout(false);
            this.MainMacroGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MacroCategoryListBox;
        private System.Windows.Forms.GroupBox MainMacroGroupBox;
        private System.Windows.Forms.Button CreateCategoryButton;
        private System.Windows.Forms.ListBox TeamToonsListBox;
        private System.Windows.Forms.ListBox MacroListBox;
        private System.Windows.Forms.Label MacroTextLabel;
        private System.Windows.Forms.Label MacroKeybindLabel;
        private System.Windows.Forms.Label MacroNameLabel;
        private System.Windows.Forms.TextBox MacroTextEditBox;
        private System.Windows.Forms.TextBox MacroKeybindEditBox;
        private System.Windows.Forms.TextBox MacroNameEditBox;
        private System.Windows.Forms.Button RemoveMacroButton;
        private System.Windows.Forms.Button AddNewMacroButton;
    }
}
