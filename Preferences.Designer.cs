namespace EnglishPopup
{
    partial class Preferences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preferences));
            this.buttonSave = new MetroFramework.Controls.MetroButton();
            this.buttonExit = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.checkBoxRandomOrder = new MetroFramework.Controls.MetroToggle();
            this.checkBoxSound = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.numericUpDownStill = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(250, 327);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 38);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSaveClickedHandler);
            // 
            // buttonExit
            // 
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(362, 327);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(106, 38);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.buttonExitClickedHandler);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.checkBoxRandomOrder);
            this.metroPanel1.Controls.Add(this.checkBoxSound);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.numericUpDownStill);
            this.metroPanel1.Controls.Add(this.numericUpDownInterval);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(445, 234);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // checkBoxRandomOrder
            // 
            this.checkBoxRandomOrder.AutoSize = true;
            this.checkBoxRandomOrder.Location = new System.Drawing.Point(135, 153);
            this.checkBoxRandomOrder.Name = "checkBoxRandomOrder";
            this.checkBoxRandomOrder.Size = new System.Drawing.Size(80, 17);
            this.checkBoxRandomOrder.TabIndex = 27;
            this.checkBoxRandomOrder.Text = "Off";
            this.checkBoxRandomOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRandomOrder.UseVisualStyleBackColor = true;
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(135, 116);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(80, 17);
            this.checkBoxSound.TabIndex = 26;
            this.checkBoxSound.Text = "Off";
            this.checkBoxSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(354, 78);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Seconds";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(354, 39);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(54, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Minutes";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(61, 151);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Random";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(74, 113);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Sound";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(79, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Delay";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(68, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Interval";
            // 
            // numericUpDownStill
            // 
            this.numericUpDownStill.Location = new System.Drawing.Point(135, 77);
            this.numericUpDownStill.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDownStill.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStill.Name = "numericUpDownStill";
            this.numericUpDownStill.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownStill.TabIndex = 19;
            this.numericUpDownStill.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(135, 38);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(198, 20);
            this.numericUpDownInterval.TabIndex = 18;
            this.numericUpDownInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Preferences
            // 
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(485, 374);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Preferences";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.preferenceFormOnLoadHandler);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton buttonSave;
        private MetroFramework.Controls.MetroButton buttonExit;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroToggle checkBoxRandomOrder;
        private MetroFramework.Controls.MetroToggle checkBoxSound;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.NumericUpDown numericUpDownStill;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
    }
}