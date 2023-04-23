
namespace SearchShortcut
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setNewKeywordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.askOnClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOnAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOnClickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreTermsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.termsTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.termsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.enginesTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.enginesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.keywordTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.keywordToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.textFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.performSearchButton = new System.Windows.Forms.Button();
            this.searchTermLabel = new System.Windows.Forms.Label();
            this.searchTermAddButton = new System.Windows.Forms.Button();
            this.searchEnginesAddButton = new System.Windows.Forms.Button();
            this.searchEnginesLabel = new System.Windows.Forms.Label();
            this.searchTermsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEnginesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.searchTermTextBox = new System.Windows.Forms.TextBox();
            this.searchEnginesTextBox = new System.Windows.Forms.TextBox();
            this.textFileSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.checkedListBoxContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.minimizeToolStripMenuItem,
                                    this.fileToolStripMenuItem,
                                    this.toolsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(395, 24);
            this.mainMenuStrip.TabIndex = 33;
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.minimizeToolStripMenuItem.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem,
                                    this.openToolStripMenuItem,
                                    this.toolStripSeparator,
                                    this.saveToolStripMenuItem,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnSaveToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.customizeToolStripMenuItem,
                                    this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.setNewKeywordToolStripMenuItem,
                                    this.targetBrowserToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // setNewKeywordToolStripMenuItem
            // 
            this.setNewKeywordToolStripMenuItem.Name = "setNewKeywordToolStripMenuItem";
            this.setNewKeywordToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.setNewKeywordToolStripMenuItem.Text = "&Set new keyword";
            this.setNewKeywordToolStripMenuItem.Click += new System.EventHandler(this.OnSetNewKeywordToolStripMenuItemClick);
            // 
            // targetBrowserToolStripMenuItem
            // 
            this.targetBrowserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.chromeToolStripMenuItem,
                                    this.defaultToolStripMenuItem});
            this.targetBrowserToolStripMenuItem.Name = "targetBrowserToolStripMenuItem";
            this.targetBrowserToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.targetBrowserToolStripMenuItem.Text = "&Target browser";
            this.targetBrowserToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnTargetBrowserToolStripMenuItemDropDownItemClicked);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Checked = true;
            this.chromeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.chromeToolStripMenuItem.Text = "&Chrome";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultToolStripMenuItem.Text = "&Default";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.askOnClearToolStripMenuItem,
                                    this.checkOnAddToolStripMenuItem,
                                    this.checkOnClickToolStripMenuItem,
                                    this.restoreTermsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // askOnClearToolStripMenuItem
            // 
            this.askOnClearToolStripMenuItem.Checked = true;
            this.askOnClearToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.askOnClearToolStripMenuItem.Name = "askOnClearToolStripMenuItem";
            this.askOnClearToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.askOnClearToolStripMenuItem.Text = "&Ask on clear";
            // 
            // checkOnAddToolStripMenuItem
            // 
            this.checkOnAddToolStripMenuItem.Checked = true;
            this.checkOnAddToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOnAddToolStripMenuItem.Name = "checkOnAddToolStripMenuItem";
            this.checkOnAddToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.checkOnAddToolStripMenuItem.Text = "&Check on add";
            // 
            // checkOnClickToolStripMenuItem
            // 
            this.checkOnClickToolStripMenuItem.Checked = true;
            this.checkOnClickToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkOnClickToolStripMenuItem.Name = "checkOnClickToolStripMenuItem";
            this.checkOnClickToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.checkOnClickToolStripMenuItem.Text = "&Check on click";
            // 
            // restoreTermsToolStripMenuItem
            // 
            this.restoreTermsToolStripMenuItem.Checked = true;
            this.restoreTermsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.restoreTermsToolStripMenuItem.Name = "restoreTermsToolStripMenuItem";
            this.restoreTermsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.restoreTermsToolStripMenuItem.Text = "&Restore terms";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.termsTextToolStripStatusLabel,
                                    this.termsToolStripStatusLabel,
                                    this.enginesTextToolStripStatusLabel,
                                    this.enginesToolStripStatusLabel,
                                    this.keywordTextToolStripStatusLabel,
                                    this.keywordToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 428);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(395, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 32;
            // 
            // termsTextToolStripStatusLabel
            // 
            this.termsTextToolStripStatusLabel.Name = "termsTextToolStripStatusLabel";
            this.termsTextToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.termsTextToolStripStatusLabel.Text = "Terms:";
            // 
            // termsToolStripStatusLabel
            // 
            this.termsToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termsToolStripStatusLabel.Name = "termsToolStripStatusLabel";
            this.termsToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.termsToolStripStatusLabel.Text = "0";
            // 
            // enginesTextToolStripStatusLabel
            // 
            this.enginesTextToolStripStatusLabel.Name = "enginesTextToolStripStatusLabel";
            this.enginesTextToolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.enginesTextToolStripStatusLabel.Text = "Engines:";
            // 
            // enginesToolStripStatusLabel
            // 
            this.enginesToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enginesToolStripStatusLabel.Name = "enginesToolStripStatusLabel";
            this.enginesToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.enginesToolStripStatusLabel.Text = "0";
            // 
            // keywordTextToolStripStatusLabel
            // 
            this.keywordTextToolStripStatusLabel.Name = "keywordTextToolStripStatusLabel";
            this.keywordTextToolStripStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.keywordTextToolStripStatusLabel.Text = "Keyword:";
            // 
            // keywordToolStripStatusLabel
            // 
            this.keywordToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordToolStripStatusLabel.Name = "keywordToolStripStatusLabel";
            this.keywordToolStripStatusLabel.Size = new System.Drawing.Size(81, 17);
            this.keywordToolStripStatusLabel.Text = "publicdomain";
            // 
            // textFileOpenFileDialog
            // 
            this.textFileOpenFileDialog.DefaultExt = "txt";
            this.textFileOpenFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.mainTableLayoutPanel.Controls.Add(this.performSearchButton, 0, 6);
            this.mainTableLayoutPanel.Controls.Add(this.searchTermLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.searchTermAddButton, 1, 1);
            this.mainTableLayoutPanel.Controls.Add(this.searchEnginesAddButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.searchEnginesLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.searchTermsCheckedListBox, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.searchEnginesCheckedListBox, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.searchTermTextBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.searchEnginesTextBox, 0, 4);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 7;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(395, 404);
            this.mainTableLayoutPanel.TabIndex = 34;
            // 
            // performSearchButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.performSearchButton, 2);
            this.performSearchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.performSearchButton.Location = new System.Drawing.Point(3, 357);
            this.performSearchButton.Name = "performSearchButton";
            this.performSearchButton.Size = new System.Drawing.Size(389, 44);
            this.performSearchButton.TabIndex = 8;
            this.performSearchButton.Text = "&Perform search";
            this.performSearchButton.UseVisualStyleBackColor = true;
            this.performSearchButton.Click += new System.EventHandler(this.OnPerformSearchButtonClick);
            // 
            // searchTermLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.searchTermLabel, 2);
            this.searchTermLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTermLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTermLabel.Location = new System.Drawing.Point(3, 0);
            this.searchTermLabel.Name = "searchTermLabel";
            this.searchTermLabel.Size = new System.Drawing.Size(389, 20);
            this.searchTermLabel.TabIndex = 0;
            this.searchTermLabel.Text = "&Search terms:";
            this.searchTermLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTermAddButton
            // 
            this.searchTermAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTermAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchTermAddButton.Location = new System.Drawing.Point(343, 23);
            this.searchTermAddButton.Name = "searchTermAddButton";
            this.searchTermAddButton.Size = new System.Drawing.Size(49, 29);
            this.searchTermAddButton.TabIndex = 2;
            this.searchTermAddButton.Text = "&Add";
            this.searchTermAddButton.UseVisualStyleBackColor = true;
            this.searchTermAddButton.Click += new System.EventHandler(this.OnSearchTermAddButtonClick);
            // 
            // searchEnginesAddButton
            // 
            this.searchEnginesAddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchEnginesAddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchEnginesAddButton.Location = new System.Drawing.Point(343, 200);
            this.searchEnginesAddButton.Name = "searchEnginesAddButton";
            this.searchEnginesAddButton.Size = new System.Drawing.Size(49, 29);
            this.searchEnginesAddButton.TabIndex = 6;
            this.searchEnginesAddButton.Text = "&Add";
            this.searchEnginesAddButton.UseVisualStyleBackColor = true;
            this.searchEnginesAddButton.Click += new System.EventHandler(this.OnSearchEnginesAddButtonClick);
            // 
            // searchEnginesLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.searchEnginesLabel, 2);
            this.searchEnginesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchEnginesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEnginesLabel.Location = new System.Drawing.Point(3, 177);
            this.searchEnginesLabel.Name = "searchEnginesLabel";
            this.searchEnginesLabel.Size = new System.Drawing.Size(389, 20);
            this.searchEnginesLabel.TabIndex = 4;
            this.searchEnginesLabel.Text = "&Search engines:";
            this.searchEnginesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchTermsCheckedListBox
            // 
            this.searchTermsCheckedListBox.CheckOnClick = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.searchTermsCheckedListBox, 2);
            this.searchTermsCheckedListBox.ContextMenuStrip = this.checkedListBoxContextMenuStrip;
            this.searchTermsCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTermsCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTermsCheckedListBox.FormattingEnabled = true;
            this.searchTermsCheckedListBox.IntegralHeight = false;
            this.searchTermsCheckedListBox.Location = new System.Drawing.Point(3, 58);
            this.searchTermsCheckedListBox.Name = "searchTermsCheckedListBox";
            this.searchTermsCheckedListBox.Size = new System.Drawing.Size(389, 116);
            this.searchTermsCheckedListBox.Sorted = true;
            this.searchTermsCheckedListBox.TabIndex = 3;
            this.searchTermsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnSearchTermCheckedListBoxItemCheck);
            this.searchTermsCheckedListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnSearchTermCheckedListBoxPreviewKeyDown);
            // 
            // checkedListBoxContextMenuStrip
            // 
            this.checkedListBoxContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.deleteToolStripMenuItem,
                                    this.editToolStripMenuItem,
                                    this.clearToolStripMenuItem});
            this.checkedListBoxContextMenuStrip.Name = "checkedListBoxContextMenuStrip";
            this.checkedListBoxContextMenuStrip.Size = new System.Drawing.Size(108, 70);
            this.checkedListBoxContextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnCheckedListBoxContextMenuStripItemClicked);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.clearToolStripMenuItem.Text = "&Clear";
            // 
            // searchEnginesCheckedListBox
            // 
            this.searchEnginesCheckedListBox.CheckOnClick = true;
            this.mainTableLayoutPanel.SetColumnSpan(this.searchEnginesCheckedListBox, 2);
            this.searchEnginesCheckedListBox.ContextMenuStrip = this.checkedListBoxContextMenuStrip;
            this.searchEnginesCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchEnginesCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEnginesCheckedListBox.FormattingEnabled = true;
            this.searchEnginesCheckedListBox.IntegralHeight = false;
            this.searchEnginesCheckedListBox.Location = new System.Drawing.Point(3, 235);
            this.searchEnginesCheckedListBox.Name = "searchEnginesCheckedListBox";
            this.searchEnginesCheckedListBox.Size = new System.Drawing.Size(389, 116);
            this.searchEnginesCheckedListBox.Sorted = true;
            this.searchEnginesCheckedListBox.TabIndex = 7;
            this.searchEnginesCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnSearchEnginesCheckedListBoxItemCheck);
            this.searchEnginesCheckedListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnSearchEnginesCheckedListBoxPreviewKeyDown);
            // 
            // searchTermTextBox
            // 
            this.searchTermTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTermTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTermTextBox.Location = new System.Drawing.Point(3, 23);
            this.searchTermTextBox.Name = "searchTermTextBox";
            this.searchTermTextBox.Size = new System.Drawing.Size(334, 26);
            this.searchTermTextBox.TabIndex = 1;
            this.searchTermTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchTermTextBoxKeyDown);
            // 
            // searchEnginesTextBox
            // 
            this.searchEnginesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchEnginesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEnginesTextBox.Location = new System.Drawing.Point(3, 200);
            this.searchEnginesTextBox.Name = "searchEnginesTextBox";
            this.searchEnginesTextBox.Size = new System.Drawing.Size(334, 26);
            this.searchEnginesTextBox.TabIndex = 5;
            this.searchEnginesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchEnginesTextBoxKeyDown);
            // 
            // textFileSaveFileDialog
            // 
            this.textFileSaveFileDialog.DefaultExt = "txt";
            this.textFileSaveFileDialog.Filter = "TXT Files|*.txt|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 450);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchShortcut";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.mainTableLayoutPanel.PerformLayout();
            this.checkedListBoxContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem restoreTermsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOnAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOnClickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem askOnClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip checkedListBoxContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetBrowserToolStripMenuItem;
        private System.Windows.Forms.TextBox searchEnginesTextBox;
        private System.Windows.Forms.TextBox searchTermTextBox;
        private System.Windows.Forms.CheckedListBox searchEnginesCheckedListBox;
        private System.Windows.Forms.CheckedListBox searchTermsCheckedListBox;
        private System.Windows.Forms.Label searchEnginesLabel;
        private System.Windows.Forms.Button searchEnginesAddButton;
        private System.Windows.Forms.Button searchTermAddButton;
        private System.Windows.Forms.Button performSearchButton;
        private System.Windows.Forms.Label searchTermLabel;
        private System.Windows.Forms.SaveFileDialog textFileSaveFileDialog;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.OpenFileDialog textFileOpenFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel keywordToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel keywordTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel enginesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel enginesTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel termsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel termsTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setNewKeywordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
