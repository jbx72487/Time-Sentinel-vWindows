namespace Time_Sentinel_v1
{
    partial class MainSettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSettingsDialog));
            this.cancelButton = new System.Windows.Forms.Button();
            this.okayButton = new System.Windows.Forms.Button();
            this.advancedTab = new System.Windows.Forms.TabPage();
            this.hackerWarningLabel = new System.Windows.Forms.Label();
            this.hackerWarningExplainLabel = new System.Windows.Forms.Label();
            this.unblockEventsGroupBox = new System.Windows.Forms.GroupBox();
            this.unblockNeverRadioButton = new System.Windows.Forms.RadioButton();
            this.unblockPswdRadioButton = new System.Windows.Forms.RadioButton();
            this.unblockMathRadioButton = new System.Windows.Forms.RadioButton();
            this.unblockBtnRadioButton = new System.Windows.Forms.RadioButton();
            this.unblockPswdPanel = new System.Windows.Forms.Panel();
            this.pswd1Label = new System.Windows.Forms.Label();
            this.pswd1TextBox = new System.Windows.Forms.TextBox();
            this.pswd2Label = new System.Windows.Forms.Label();
            this.pswd2TextBox = new System.Windows.Forms.TextBox();
            this.hackerOptionsLabel = new System.Windows.Forms.Label();
            this.unblockEventsLabel = new System.Windows.Forms.Label();
            this.hackerOptionsButton = new System.Windows.Forms.Button();
            this.basicTab = new System.Windows.Forms.TabPage();
            this.timeLimitGroupBox = new System.Windows.Forms.GroupBox();
            this.limitEventExplainLabel = new System.Windows.Forms.Label();
            this.limitEventRadioButton = new System.Windows.Forms.RadioButton();
            this.limitTimePanel = new System.Windows.Forms.Panel();
            this.limitTimeHrsLabel = new System.Windows.Forms.Label();
            this.limitTimeMinsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitTimeHrsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.limitTimeMinsLabel = new System.Windows.Forms.Label();
            this.limitTimeRadioButton = new System.Windows.Forms.RadioButton();
            this.timeLimitLabel = new System.Windows.Forms.Label();
            this.restrictionLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.levelAppsRadioButton = new System.Windows.Forms.RadioButton();
            this.levelAppsPanel = new System.Windows.Forms.Panel();
            this.msnCheckBox = new System.Windows.Forms.CheckBox();
            this.thunderbirdCheckBox = new System.Windows.Forms.CheckBox();
            this.outlookCheckBox = new System.Windows.Forms.CheckBox();
            this.safariCheckBox = new System.Windows.Forms.CheckBox();
            this.chromeCheckBox = new System.Windows.Forms.CheckBox();
            this.iexplorerCheckBox = new System.Windows.Forms.CheckBox();
            this.gtalkCheckBox = new System.Windows.Forms.CheckBox();
            this.aimCheckBox = new System.Windows.Forms.CheckBox();
            this.firefoxCheckBox = new System.Windows.Forms.CheckBox();
            this.restrictionLevelLabel = new System.Windows.Forms.Label();
            this.settingsTabControl = new System.Windows.Forms.TabControl();
            this.advancedTab.SuspendLayout();
            this.unblockEventsGroupBox.SuspendLayout();
            this.unblockPswdPanel.SuspendLayout();
            this.basicTab.SuspendLayout();
            this.timeLimitGroupBox.SuspendLayout();
            this.limitTimePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitTimeMinsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitTimeHrsNumericUpDown)).BeginInit();
            this.restrictionLevelGroupBox.SuspendLayout();
            this.levelAppsPanel.SuspendLayout();
            this.settingsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(261, 422);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(106, 24);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(93, 422);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(106, 24);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "Okay";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // advancedTab
            // 
            this.advancedTab.Controls.Add(this.hackerWarningLabel);
            this.advancedTab.Controls.Add(this.hackerWarningExplainLabel);
            this.advancedTab.Controls.Add(this.unblockEventsGroupBox);
            this.advancedTab.Controls.Add(this.hackerOptionsLabel);
            this.advancedTab.Controls.Add(this.unblockEventsLabel);
            this.advancedTab.Controls.Add(this.hackerOptionsButton);
            this.advancedTab.Location = new System.Drawing.Point(4, 24);
            this.advancedTab.Name = "advancedTab";
            this.advancedTab.Padding = new System.Windows.Forms.Padding(3);
            this.advancedTab.Size = new System.Drawing.Size(435, 383);
            this.advancedTab.TabIndex = 2;
            this.advancedTab.Text = "Advanced";
            this.advancedTab.UseVisualStyleBackColor = true;
            // 
            // hackerWarningLabel
            // 
            this.hackerWarningLabel.AutoSize = true;
            this.hackerWarningLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hackerWarningLabel.Location = new System.Drawing.Point(62, 246);
            this.hackerWarningLabel.Name = "hackerWarningLabel";
            this.hackerWarningLabel.Size = new System.Drawing.Size(64, 18);
            this.hackerWarningLabel.TabIndex = 39;
            this.hackerWarningLabel.Text = "Warning:";
            // 
            // hackerWarningExplainLabel
            // 
            this.hackerWarningExplainLabel.Location = new System.Drawing.Point(86, 271);
            this.hackerWarningExplainLabel.Name = "hackerWarningExplainLabel";
            this.hackerWarningExplainLabel.Size = new System.Drawing.Size(277, 34);
            this.hackerWarningExplainLabel.TabIndex = 38;
            this.hackerWarningExplainLabel.Text = "Modifying these options without fully understanding them is discouraged.";
            // 
            // unblockEventsGroupBox
            // 
            this.unblockEventsGroupBox.Controls.Add(this.unblockNeverRadioButton);
            this.unblockEventsGroupBox.Controls.Add(this.unblockPswdRadioButton);
            this.unblockEventsGroupBox.Controls.Add(this.unblockMathRadioButton);
            this.unblockEventsGroupBox.Controls.Add(this.unblockBtnRadioButton);
            this.unblockEventsGroupBox.Controls.Add(this.unblockPswdPanel);
            this.unblockEventsGroupBox.Location = new System.Drawing.Point(30, 36);
            this.unblockEventsGroupBox.Name = "unblockEventsGroupBox";
            this.unblockEventsGroupBox.Size = new System.Drawing.Size(384, 172);
            this.unblockEventsGroupBox.TabIndex = 33;
            this.unblockEventsGroupBox.TabStop = false;
            this.unblockEventsGroupBox.Text = "Reenable access before time expires if:";
            // 
            // unblockNeverRadioButton
            // 
            this.unblockNeverRadioButton.AutoSize = true;
            this.unblockNeverRadioButton.Checked = true;
            this.unblockNeverRadioButton.Location = new System.Drawing.Point(22, 146);
            this.unblockNeverRadioButton.Name = "unblockNeverRadioButton";
            this.unblockNeverRadioButton.Size = new System.Drawing.Size(56, 19);
            this.unblockNeverRadioButton.TabIndex = 30;
            this.unblockNeverRadioButton.TabStop = true;
            this.unblockNeverRadioButton.Text = "Never";
            this.unblockNeverRadioButton.UseVisualStyleBackColor = true;
            // 
            // unblockPswdRadioButton
            // 
            this.unblockPswdRadioButton.Location = new System.Drawing.Point(22, 74);
            this.unblockPswdRadioButton.Name = "unblockPswdRadioButton";
            this.unblockPswdRadioButton.Size = new System.Drawing.Size(347, 19);
            this.unblockPswdRadioButton.TabIndex = 29;
            this.unblockPswdRadioButton.Text = "The password (set here) is entered";
            this.unblockPswdRadioButton.UseVisualStyleBackColor = true;
            this.unblockPswdRadioButton.CheckedChanged += new System.EventHandler(this.unblockPswd_CheckedChanged);
            // 
            // unblockMathRadioButton
            // 
            this.unblockMathRadioButton.Location = new System.Drawing.Point(22, 48);
            this.unblockMathRadioButton.Name = "unblockMathRadioButton";
            this.unblockMathRadioButton.Size = new System.Drawing.Size(347, 19);
            this.unblockMathRadioButton.TabIndex = 28;
            this.unblockMathRadioButton.Text = "Multiple two-digit multiplication problems are completed";
            this.unblockMathRadioButton.UseVisualStyleBackColor = true;
            // 
            // unblockBtnRadioButton
            // 
            this.unblockBtnRadioButton.AutoSize = true;
            this.unblockBtnRadioButton.Location = new System.Drawing.Point(22, 22);
            this.unblockBtnRadioButton.Name = "unblockBtnRadioButton";
            this.unblockBtnRadioButton.Size = new System.Drawing.Size(267, 19);
            this.unblockBtnRadioButton.TabIndex = 27;
            this.unblockBtnRadioButton.Text = "A series of confirmation buttons are pressed";
            this.unblockBtnRadioButton.UseVisualStyleBackColor = true;
            // 
            // unblockPswdPanel
            // 
            this.unblockPswdPanel.Controls.Add(this.pswd1Label);
            this.unblockPswdPanel.Controls.Add(this.pswd1TextBox);
            this.unblockPswdPanel.Controls.Add(this.pswd2Label);
            this.unblockPswdPanel.Controls.Add(this.pswd2TextBox);
            this.unblockPswdPanel.Enabled = false;
            this.unblockPswdPanel.Location = new System.Drawing.Point(59, 96);
            this.unblockPswdPanel.Name = "unblockPswdPanel";
            this.unblockPswdPanel.Size = new System.Drawing.Size(216, 49);
            this.unblockPswdPanel.TabIndex = 33;
            // 
            // pswd1Label
            // 
            this.pswd1Label.AutoSize = true;
            this.pswd1Label.Location = new System.Drawing.Point(-3, 4);
            this.pswd1Label.Name = "pswd1Label";
            this.pswd1Label.Size = new System.Drawing.Size(64, 15);
            this.pswd1Label.TabIndex = 35;
            this.pswd1Label.Text = "Password:";
            // 
            // pswd1TextBox
            // 
            this.pswd1TextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd1TextBox.Location = new System.Drawing.Point(65, 3);
            this.pswd1TextBox.MaxLength = 20;
            this.pswd1TextBox.Name = "pswd1TextBox";
            this.pswd1TextBox.PasswordChar = '*';
            this.pswd1TextBox.Size = new System.Drawing.Size(148, 21);
            this.pswd1TextBox.TabIndex = 34;
            // 
            // pswd2Label
            // 
            this.pswd2Label.AutoSize = true;
            this.pswd2Label.Location = new System.Drawing.Point(-3, 26);
            this.pswd2Label.Name = "pswd2Label";
            this.pswd2Label.Size = new System.Drawing.Size(46, 15);
            this.pswd2Label.TabIndex = 36;
            this.pswd2Label.Text = "Retype:";
            // 
            // pswd2TextBox
            // 
            this.pswd2TextBox.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd2TextBox.Location = new System.Drawing.Point(65, 25);
            this.pswd2TextBox.MaxLength = 20;
            this.pswd2TextBox.Name = "pswd2TextBox";
            this.pswd2TextBox.PasswordChar = '*';
            this.pswd2TextBox.Size = new System.Drawing.Size(148, 21);
            this.pswd2TextBox.TabIndex = 33;
            // 
            // hackerOptionsLabel
            // 
            this.hackerOptionsLabel.AutoSize = true;
            this.hackerOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hackerOptionsLabel.Location = new System.Drawing.Point(10, 222);
            this.hackerOptionsLabel.Name = "hackerOptionsLabel";
            this.hackerOptionsLabel.Size = new System.Drawing.Size(95, 13);
            this.hackerOptionsLabel.TabIndex = 32;
            this.hackerOptionsLabel.Text = "Hacker Options";
            // 
            // unblockEventsLabel
            // 
            this.unblockEventsLabel.AutoSize = true;
            this.unblockEventsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unblockEventsLabel.Location = new System.Drawing.Point(10, 17);
            this.unblockEventsLabel.Name = "unblockEventsLabel";
            this.unblockEventsLabel.Size = new System.Drawing.Size(97, 13);
            this.unblockEventsLabel.TabIndex = 32;
            this.unblockEventsLabel.Text = "Unblock Events";
            // 
            // hackerOptionsButton
            // 
            this.hackerOptionsButton.Location = new System.Drawing.Point(89, 316);
            this.hackerOptionsButton.Name = "hackerOptionsButton";
            this.hackerOptionsButton.Size = new System.Drawing.Size(126, 27);
            this.hackerOptionsButton.TabIndex = 1;
            this.hackerOptionsButton.Text = "Edit Hacker Options";
            this.hackerOptionsButton.UseVisualStyleBackColor = true;
            this.hackerOptionsButton.Click += new System.EventHandler(this.btnShowHacker_Click);
            // 
            // basicTab
            // 
            this.basicTab.Controls.Add(this.timeLimitGroupBox);
            this.basicTab.Controls.Add(this.timeLimitLabel);
            this.basicTab.Controls.Add(this.restrictionLevelGroupBox);
            this.basicTab.Controls.Add(this.restrictionLevelLabel);
            this.basicTab.Location = new System.Drawing.Point(4, 24);
            this.basicTab.Name = "basicTab";
            this.basicTab.Padding = new System.Windows.Forms.Padding(3);
            this.basicTab.Size = new System.Drawing.Size(435, 383);
            this.basicTab.TabIndex = 0;
            this.basicTab.Text = "Basic";
            this.basicTab.UseVisualStyleBackColor = true;
            // 
            // timeLimitGroupBox
            // 
            this.timeLimitGroupBox.Controls.Add(this.limitEventExplainLabel);
            this.timeLimitGroupBox.Controls.Add(this.limitEventRadioButton);
            this.timeLimitGroupBox.Controls.Add(this.limitTimePanel);
            this.timeLimitGroupBox.Controls.Add(this.limitTimeRadioButton);
            this.timeLimitGroupBox.Location = new System.Drawing.Point(30, 242);
            this.timeLimitGroupBox.Name = "timeLimitGroupBox";
            this.timeLimitGroupBox.Size = new System.Drawing.Size(384, 127);
            this.timeLimitGroupBox.TabIndex = 31;
            this.timeLimitGroupBox.TabStop = false;
            this.timeLimitGroupBox.Text = "Disable access until:";
            // 
            // limitEventExplainLabel
            // 
            this.limitEventExplainLabel.Location = new System.Drawing.Point(59, 96);
            this.limitEventExplainLabel.Name = "limitEventExplainLabel";
            this.limitEventExplainLabel.Size = new System.Drawing.Size(200, 21);
            this.limitEventExplainLabel.TabIndex = 29;
            this.limitEventExplainLabel.Text = "(choose event in \"Advanced\" tab)";
            // 
            // limitEventRadioButton
            // 
            this.limitEventRadioButton.AutoSize = true;
            this.limitEventRadioButton.Location = new System.Drawing.Point(22, 74);
            this.limitEventRadioButton.Name = "limitEventRadioButton";
            this.limitEventRadioButton.Size = new System.Drawing.Size(214, 19);
            this.limitEventRadioButton.TabIndex = 28;
            this.limitEventRadioButton.TabStop = true;
            this.limitEventRadioButton.Text = "A designated unblock event occurs";
            this.limitEventRadioButton.UseVisualStyleBackColor = true;
            this.limitEventRadioButton.CheckedChanged += new System.EventHandler(this.limitEvent_CheckedChanged);
            // 
            // limitTimePanel
            // 
            this.limitTimePanel.Controls.Add(this.limitTimeHrsLabel);
            this.limitTimePanel.Controls.Add(this.limitTimeMinsNumericUpDown);
            this.limitTimePanel.Controls.Add(this.limitTimeHrsNumericUpDown);
            this.limitTimePanel.Controls.Add(this.limitTimeMinsLabel);
            this.limitTimePanel.Location = new System.Drawing.Point(59, 38);
            this.limitTimePanel.Name = "limitTimePanel";
            this.limitTimePanel.Size = new System.Drawing.Size(177, 35);
            this.limitTimePanel.TabIndex = 30;
            // 
            // limitTimeHrsLabel
            // 
            this.limitTimeHrsLabel.AutoSize = true;
            this.limitTimeHrsLabel.Location = new System.Drawing.Point(39, 9);
            this.limitTimeHrsLabel.Name = "limitTimeHrsLabel";
            this.limitTimeHrsLabel.Size = new System.Drawing.Size(39, 15);
            this.limitTimeHrsLabel.TabIndex = 22;
            this.limitTimeHrsLabel.Text = "hours";
            // 
            // limitTimeMinsNumericUpDown
            // 
            this.limitTimeMinsNumericUpDown.Location = new System.Drawing.Point(82, 7);
            this.limitTimeMinsNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.limitTimeMinsNumericUpDown.Name = "limitTimeMinsNumericUpDown";
            this.limitTimeMinsNumericUpDown.Size = new System.Drawing.Size(35, 23);
            this.limitTimeMinsNumericUpDown.TabIndex = 24;
            this.limitTimeMinsNumericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // limitTimeHrsNumericUpDown
            // 
            this.limitTimeHrsNumericUpDown.Location = new System.Drawing.Point(3, 7);
            this.limitTimeHrsNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.limitTimeHrsNumericUpDown.Name = "limitTimeHrsNumericUpDown";
            this.limitTimeHrsNumericUpDown.Size = new System.Drawing.Size(36, 23);
            this.limitTimeHrsNumericUpDown.TabIndex = 23;
            // 
            // limitTimeMinsLabel
            // 
            this.limitTimeMinsLabel.AutoSize = true;
            this.limitTimeMinsLabel.Location = new System.Drawing.Point(120, 9);
            this.limitTimeMinsLabel.Name = "limitTimeMinsLabel";
            this.limitTimeMinsLabel.Size = new System.Drawing.Size(51, 15);
            this.limitTimeMinsLabel.TabIndex = 21;
            this.limitTimeMinsLabel.Text = "minutes";
            // 
            // limitTimeRadioButton
            // 
            this.limitTimeRadioButton.AutoSize = true;
            this.limitTimeRadioButton.Checked = true;
            this.limitTimeRadioButton.Location = new System.Drawing.Point(22, 20);
            this.limitTimeRadioButton.Name = "limitTimeRadioButton";
            this.limitTimeRadioButton.Size = new System.Drawing.Size(210, 19);
            this.limitTimeRadioButton.TabIndex = 27;
            this.limitTimeRadioButton.TabStop = true;
            this.limitTimeRadioButton.Text = "The following time period expires.";
            this.limitTimeRadioButton.UseVisualStyleBackColor = true;
            this.limitTimeRadioButton.CheckedChanged += new System.EventHandler(this.limitTime_CheckedChanged);
            // 
            // timeLimitLabel
            // 
            this.timeLimitLabel.AutoSize = true;
            this.timeLimitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitLabel.Location = new System.Drawing.Point(10, 222);
            this.timeLimitLabel.Name = "timeLimitLabel";
            this.timeLimitLabel.Size = new System.Drawing.Size(64, 13);
            this.timeLimitLabel.TabIndex = 16;
            this.timeLimitLabel.Text = "Time Limit";
            // 
            // restrictionLevelGroupBox
            // 
            this.restrictionLevelGroupBox.Controls.Add(this.levelAppsRadioButton);
            this.restrictionLevelGroupBox.Controls.Add(this.levelAppsPanel);
            this.restrictionLevelGroupBox.Location = new System.Drawing.Point(30, 36);
            this.restrictionLevelGroupBox.Name = "restrictionLevelGroupBox";
            this.restrictionLevelGroupBox.Size = new System.Drawing.Size(384, 172);
            this.restrictionLevelGroupBox.TabIndex = 30;
            this.restrictionLevelGroupBox.TabStop = false;
            this.restrictionLevelGroupBox.Text = "Disable access to:";
            // 
            // levelAppsRadioButton
            // 
            this.levelAppsRadioButton.AutoSize = true;
            this.levelAppsRadioButton.Checked = true;
            this.levelAppsRadioButton.Location = new System.Drawing.Point(22, 22);
            this.levelAppsRadioButton.Name = "levelAppsRadioButton";
            this.levelAppsRadioButton.Size = new System.Drawing.Size(220, 19);
            this.levelAppsRadioButton.TabIndex = 26;
            this.levelAppsRadioButton.TabStop = true;
            this.levelAppsRadioButton.Text = "Certain internet-based applications";
            this.levelAppsRadioButton.UseVisualStyleBackColor = true;
            this.levelAppsRadioButton.CheckedChanged += new System.EventHandler(this.levelApp_CheckedChanged);
            // 
            // levelAppsPanel
            // 
            this.levelAppsPanel.Controls.Add(this.msnCheckBox);
            this.levelAppsPanel.Controls.Add(this.thunderbirdCheckBox);
            this.levelAppsPanel.Controls.Add(this.outlookCheckBox);
            this.levelAppsPanel.Controls.Add(this.safariCheckBox);
            this.levelAppsPanel.Controls.Add(this.chromeCheckBox);
            this.levelAppsPanel.Controls.Add(this.iexplorerCheckBox);
            this.levelAppsPanel.Controls.Add(this.gtalkCheckBox);
            this.levelAppsPanel.Controls.Add(this.aimCheckBox);
            this.levelAppsPanel.Controls.Add(this.firefoxCheckBox);
            this.levelAppsPanel.Font = new System.Drawing.Font("Calibri", 8.75F);
            this.levelAppsPanel.Location = new System.Drawing.Point(45, 38);
            this.levelAppsPanel.Name = "levelAppsPanel";
            this.levelAppsPanel.Size = new System.Drawing.Size(269, 129);
            this.levelAppsPanel.TabIndex = 34;
            // 
            // msnCheckBox
            // 
            this.msnCheckBox.AutoSize = true;
            this.msnCheckBox.Location = new System.Drawing.Point(137, 33);
            this.msnCheckBox.Name = "msnCheckBox";
            this.msnCheckBox.Size = new System.Drawing.Size(113, 18);
            this.msnCheckBox.TabIndex = 7;
            this.msnCheckBox.Text = "MSN Messenger";
            this.msnCheckBox.UseVisualStyleBackColor = true;
            // 
            // thunderbirdCheckBox
            // 
            this.thunderbirdCheckBox.AutoSize = true;
            this.thunderbirdCheckBox.Location = new System.Drawing.Point(137, 81);
            this.thunderbirdCheckBox.Name = "thunderbirdCheckBox";
            this.thunderbirdCheckBox.Size = new System.Drawing.Size(93, 18);
            this.thunderbirdCheckBox.TabIndex = 6;
            this.thunderbirdCheckBox.Text = "Thunderbird";
            this.thunderbirdCheckBox.UseVisualStyleBackColor = true;
            // 
            // outlookCheckBox
            // 
            this.outlookCheckBox.AutoSize = true;
            this.outlookCheckBox.Location = new System.Drawing.Point(137, 9);
            this.outlookCheckBox.Name = "outlookCheckBox";
            this.outlookCheckBox.Size = new System.Drawing.Size(122, 18);
            this.outlookCheckBox.TabIndex = 9;
            this.outlookCheckBox.Text = "Microsoft Outlook";
            this.outlookCheckBox.UseVisualStyleBackColor = true;
            // 
            // safariCheckBox
            // 
            this.safariCheckBox.AutoSize = true;
            this.safariCheckBox.Location = new System.Drawing.Point(137, 57);
            this.safariCheckBox.Name = "safariCheckBox";
            this.safariCheckBox.Size = new System.Drawing.Size(58, 18);
            this.safariCheckBox.TabIndex = 8;
            this.safariCheckBox.Text = "Safari";
            this.safariCheckBox.UseVisualStyleBackColor = true;
            // 
            // chromeCheckBox
            // 
            this.chromeCheckBox.AutoSize = true;
            this.chromeCheckBox.Location = new System.Drawing.Point(17, 57);
            this.chromeCheckBox.Name = "chromeCheckBox";
            this.chromeCheckBox.Size = new System.Drawing.Size(109, 18);
            this.chromeCheckBox.TabIndex = 5;
            this.chromeCheckBox.Text = "Google Chrome";
            this.chromeCheckBox.UseVisualStyleBackColor = true;
            // 
            // iexplorerCheckBox
            // 
            this.iexplorerCheckBox.AutoSize = true;
            this.iexplorerCheckBox.Location = new System.Drawing.Point(17, 105);
            this.iexplorerCheckBox.Name = "iexplorerCheckBox";
            this.iexplorerCheckBox.Size = new System.Drawing.Size(117, 18);
            this.iexplorerCheckBox.TabIndex = 2;
            this.iexplorerCheckBox.Text = "Internet Explorer";
            this.iexplorerCheckBox.UseVisualStyleBackColor = true;
            // 
            // gtalkCheckBox
            // 
            this.gtalkCheckBox.AutoSize = true;
            this.gtalkCheckBox.Location = new System.Drawing.Point(17, 81);
            this.gtalkCheckBox.Name = "gtalkCheckBox";
            this.gtalkCheckBox.Size = new System.Drawing.Size(90, 18);
            this.gtalkCheckBox.TabIndex = 1;
            this.gtalkCheckBox.Text = "Google Talk";
            this.gtalkCheckBox.UseVisualStyleBackColor = true;
            // 
            // aimCheckBox
            // 
            this.aimCheckBox.AutoSize = true;
            this.aimCheckBox.Location = new System.Drawing.Point(17, 9);
            this.aimCheckBox.Name = "aimCheckBox";
            this.aimCheckBox.Size = new System.Drawing.Size(47, 18);
            this.aimCheckBox.TabIndex = 4;
            this.aimCheckBox.Text = "AIM";
            this.aimCheckBox.UseVisualStyleBackColor = true;
            // 
            // firefoxCheckBox
            // 
            this.firefoxCheckBox.AutoSize = true;
            this.firefoxCheckBox.Location = new System.Drawing.Point(17, 33);
            this.firefoxCheckBox.Name = "firefoxCheckBox";
            this.firefoxCheckBox.Size = new System.Drawing.Size(63, 18);
            this.firefoxCheckBox.TabIndex = 3;
            this.firefoxCheckBox.Text = "Firefox";
            this.firefoxCheckBox.UseVisualStyleBackColor = true;
            // 
            // restrictionLevelLabel
            // 
            this.restrictionLevelLabel.AutoSize = true;
            this.restrictionLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restrictionLevelLabel.Location = new System.Drawing.Point(10, 17);
            this.restrictionLevelLabel.Name = "restrictionLevelLabel";
            this.restrictionLevelLabel.Size = new System.Drawing.Size(103, 13);
            this.restrictionLevelLabel.TabIndex = 15;
            this.restrictionLevelLabel.Text = "Restriction Level";
            // 
            // settingsTabControl
            // 
            this.settingsTabControl.Controls.Add(this.basicTab);
            this.settingsTabControl.Controls.Add(this.advancedTab);
            this.settingsTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingsTabControl.Name = "settingsTabControl";
            this.settingsTabControl.SelectedIndex = 0;
            this.settingsTabControl.Size = new System.Drawing.Size(443, 411);
            this.settingsTabControl.TabIndex = 2;
            // 
            // MainSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(443, 458);
            this.Controls.Add(this.settingsTabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okayButton);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainSettingsDialog";
            this.Text = "Time Sentinel - Settings";
            this.advancedTab.ResumeLayout(false);
            this.advancedTab.PerformLayout();
            this.unblockEventsGroupBox.ResumeLayout(false);
            this.unblockEventsGroupBox.PerformLayout();
            this.unblockPswdPanel.ResumeLayout(false);
            this.unblockPswdPanel.PerformLayout();
            this.basicTab.ResumeLayout(false);
            this.basicTab.PerformLayout();
            this.timeLimitGroupBox.ResumeLayout(false);
            this.timeLimitGroupBox.PerformLayout();
            this.limitTimePanel.ResumeLayout(false);
            this.limitTimePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitTimeMinsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.limitTimeHrsNumericUpDown)).EndInit();
            this.restrictionLevelGroupBox.ResumeLayout(false);
            this.restrictionLevelGroupBox.PerformLayout();
            this.levelAppsPanel.ResumeLayout(false);
            this.levelAppsPanel.PerformLayout();
            this.settingsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.TabControl settingsTabControl;
        private System.Windows.Forms.TabPage basicTab;
        private System.Windows.Forms.GroupBox timeLimitGroupBox;
        private System.Windows.Forms.Label limitEventExplainLabel;
        private System.Windows.Forms.RadioButton limitEventRadioButton;
        private System.Windows.Forms.RadioButton limitTimeRadioButton;
        private System.Windows.Forms.Label timeLimitLabel;
        private System.Windows.Forms.TabPage advancedTab;
        private System.Windows.Forms.GroupBox unblockEventsGroupBox;
        private System.Windows.Forms.RadioButton unblockNeverRadioButton;
        private System.Windows.Forms.RadioButton unblockPswdRadioButton;
        private System.Windows.Forms.RadioButton unblockMathRadioButton;
        private System.Windows.Forms.RadioButton unblockBtnRadioButton;
        private System.Windows.Forms.Label hackerOptionsLabel;
        private System.Windows.Forms.GroupBox restrictionLevelGroupBox;
        private System.Windows.Forms.RadioButton levelAppsRadioButton;
        private System.Windows.Forms.Label restrictionLevelLabel;
        private System.Windows.Forms.Label unblockEventsLabel;
        private System.Windows.Forms.Button hackerOptionsButton;
        private System.Windows.Forms.Label hackerWarningLabel;
        private System.Windows.Forms.Label hackerWarningExplainLabel;
        private System.Windows.Forms.Panel levelAppsPanel;
        private System.Windows.Forms.Panel limitTimePanel;
        private System.Windows.Forms.Panel unblockPswdPanel;
        private System.Windows.Forms.Label limitTimeHrsLabel;
        private System.Windows.Forms.NumericUpDown limitTimeMinsNumericUpDown;
        private System.Windows.Forms.NumericUpDown limitTimeHrsNumericUpDown;
        private System.Windows.Forms.Label limitTimeMinsLabel;
        private System.Windows.Forms.CheckBox msnCheckBox;
        private System.Windows.Forms.CheckBox thunderbirdCheckBox;
        private System.Windows.Forms.CheckBox outlookCheckBox;
        private System.Windows.Forms.CheckBox safariCheckBox;
        private System.Windows.Forms.CheckBox chromeCheckBox;
        private System.Windows.Forms.CheckBox iexplorerCheckBox;
        private System.Windows.Forms.CheckBox gtalkCheckBox;
        private System.Windows.Forms.CheckBox aimCheckBox;
        private System.Windows.Forms.CheckBox firefoxCheckBox;
        private System.Windows.Forms.Label pswd1Label;
        private System.Windows.Forms.TextBox pswd1TextBox;
        private System.Windows.Forms.Label pswd2Label;
        private System.Windows.Forms.TextBox pswd2TextBox;

        
    }
}

