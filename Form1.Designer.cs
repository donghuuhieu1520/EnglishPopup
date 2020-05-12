namespace EnglishPopup
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMeaning = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPron = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxExample = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preferencesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.popupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowApp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.wordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.myWordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.popupCustomizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Word";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(89, 29);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(264, 20);
            this.textBoxWord.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Noun",
            "Verb",
            "Adj",
            "Idiom",
            "Phrasal verb",
            "Collocation",
            "Other..."});
            this.comboBoxType.Location = new System.Drawing.Point(89, 63);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meaning";
            // 
            // textBoxMeaning
            // 
            this.textBoxMeaning.Location = new System.Drawing.Point(90, 131);
            this.textBoxMeaning.Name = "textBoxMeaning";
            this.textBoxMeaning.Size = new System.Drawing.Size(264, 20);
            this.textBoxMeaning.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pron";
            // 
            // textBoxPron
            // 
            this.textBoxPron.Location = new System.Drawing.Point(89, 97);
            this.textBoxPron.Name = "textBoxPron";
            this.textBoxPron.Size = new System.Drawing.Size(264, 20);
            this.textBoxPron.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(21, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Example";
            // 
            // richTextBoxExample
            // 
            this.richTextBoxExample.Location = new System.Drawing.Point(89, 171);
            this.richTextBoxExample.Name = "richTextBoxExample";
            this.richTextBoxExample.Size = new System.Drawing.Size(264, 96);
            this.richTextBoxExample.TabIndex = 5;
            this.richTextBoxExample.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxExample);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxWord);
            this.groupBox1.Controls.Add(this.textBoxPron);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.textBoxMeaning);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 288);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new word";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(154, 336);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAddClickHandler);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(328, 336);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.exitEnglishPop);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem2,
            this.wordsToolStripMenuItem3,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(416, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preferencesToolStripMenuItem2
            // 
            this.preferencesToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popupToolStripMenuItem1});
            this.preferencesToolStripMenuItem2.Name = "preferencesToolStripMenuItem2";
            this.preferencesToolStripMenuItem2.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem2.Text = "Preferences";
            // 
            // popupToolStripMenuItem1
            // 
            this.popupToolStripMenuItem1.Name = "popupToolStripMenuItem1";
            this.popupToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.popupToolStripMenuItem1.Text = "Popup...";
            this.popupToolStripMenuItem1.Click += new System.EventHandler(this.popupToolStripMenuItemClickedHandler);
            // 
            // wordsToolStripMenuItem3
            // 
            this.wordsToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllToolStripMenuItem1});
            this.wordsToolStripMenuItem3.Name = "wordsToolStripMenuItem3";
            this.wordsToolStripMenuItem3.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem3.Text = "Words";
            // 
            // showAllToolStripMenuItem1
            // 
            this.showAllToolStripMenuItem1.Name = "showAllToolStripMenuItem1";
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.showAllToolStripMenuItem1.Text = "Show All...";
            this.showAllToolStripMenuItem1.Click += new System.EventHandler(this.myWordsToolStripMenuItemClickHandler);
            // 
            // wordsToolStripMenuItem
            // 
            this.wordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myWordsToolStripMenuItem,
            this.addNewWordToolStripMenuItem});
            this.wordsToolStripMenuItem.Name = "wordsToolStripMenuItem";
            this.wordsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem.Text = "Words";
            // 
            // myWordsToolStripMenuItem
            // 
            this.myWordsToolStripMenuItem.Name = "myWordsToolStripMenuItem";
            this.myWordsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.myWordsToolStripMenuItem.Text = "My words...";
            this.myWordsToolStripMenuItem.Click += new System.EventHandler(this.myWordsToolStripMenuItemClickHandler);
            // 
            // addNewWordToolStripMenuItem
            // 
            this.addNewWordToolStripMenuItem.Name = "addNewWordToolStripMenuItem";
            this.addNewWordToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addNewWordToolStripMenuItem.Text = "Add new word";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popupToolStripMenuItem});
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // popupToolStripMenuItem
            // 
            this.popupToolStripMenuItem.Name = "popupToolStripMenuItem";
            this.popupToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.popupToolStripMenuItem.Text = "Popup...";
            this.popupToolStripMenuItem.Click += new System.EventHandler(this.popupToolStripMenuItemClickedHandler);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(235, 336);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(87, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start Popup";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartClickedHandler);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "EnglishPop";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.showApplication);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowApp,
            this.toolStripMenuItemExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // toolStripMenuItemShowApp
            // 
            this.toolStripMenuItemShowApp.Name = "toolStripMenuItemShowApp";
            this.toolStripMenuItemShowApp.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemShowApp.Text = "Show application";
            this.toolStripMenuItemShowApp.Click += new System.EventHandler(this.showApplication);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.ExitApp);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timerHandler);
            // 
            // wordsToolStripMenuItem1
            // 
            this.wordsToolStripMenuItem1.Name = "wordsToolStripMenuItem1";
            this.wordsToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem1.Text = "Words";
            // 
            // myWordsToolStripMenuItem1
            // 
            this.myWordsToolStripMenuItem1.Name = "myWordsToolStripMenuItem1";
            this.myWordsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.myWordsToolStripMenuItem1.Text = "My words...";
            this.myWordsToolStripMenuItem1.Click += new System.EventHandler(this.myWordsToolStripMenuItemClickHandler);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(80, 20);
            this.preferencesToolStripMenuItem1.Text = "Preferences";
            // 
            // popupCustomizerToolStripMenuItem
            // 
            this.popupCustomizerToolStripMenuItem.Name = "popupCustomizerToolStripMenuItem";
            this.popupCustomizerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.popupCustomizerToolStripMenuItem.Text = "Popup customizer...";
            this.popupCustomizerToolStripMenuItem.Click += new System.EventHandler(this.popupToolStripMenuItemClickedHandler);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.applicationToolStripMenuItem.Text = "Application...";
            // 
            // wordsToolStripMenuItem2
            // 
            this.wordsToolStripMenuItem2.Name = "wordsToolStripMenuItem2";
            this.wordsToolStripMenuItem2.Size = new System.Drawing.Size(53, 20);
            this.wordsToolStripMenuItem2.Text = "Words";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAllToolStripMenuItem.Text = "Show all...";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.myWordsToolStripMenuItemClickHandler);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.showAbout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 371);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishPop";
            this.Load += new System.EventHandler(this.loadConfigs);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMeaning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPron;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxExample;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowApp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem myWordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem popupCustomizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem popupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wordsToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

