namespace EnglishPopup
{
    partial class MyWords
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyWords));
            this.dataGridViewMyWords = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.columnOrdinalNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPron = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMeaning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnExample = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnUpdatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyWords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMyWords
            // 
            this.dataGridViewMyWords.AllowUserToAddRows = false;
            this.dataGridViewMyWords.AllowUserToOrderColumns = true;
            this.dataGridViewMyWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMyWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnOrdinalNumber,
            this.columnWord,
            this.columnType,
            this.columnPron,
            this.columnMeaning,
            this.columnExample,
            this.columnCreatedAt,
            this.columnUpdatedAt});
            this.dataGridViewMyWords.Location = new System.Drawing.Point(24, 82);
            this.dataGridViewMyWords.Name = "dataGridViewMyWords";
            this.dataGridViewMyWords.Size = new System.Drawing.Size(623, 238);
            this.dataGridViewMyWords.TabIndex = 0;
            this.dataGridViewMyWords.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.cellBeginEditHandler);
            this.dataGridViewMyWords.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellEndEditHandler);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(572, 334);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdateClickHandler);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "All",
            "Noun",
            "Verb",
            "Adj",
            "Idiom",
            "Phrasal verb",
            "Collocation",
            "Other..."});
            this.comboBoxType.Location = new System.Drawing.Point(15, 29);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 3;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(152, 30);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerFrom.TabIndex = 4;
            this.dateTimePickerFrom.Value = new System.DateTime(2000, 5, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "To";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(251, 30);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerTo.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 63);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Location = new System.Drawing.Point(412, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 63);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(17, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(135, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(594, 8);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(53, 33);
            this.buttonFind.TabIndex = 12;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFindClickedHandler);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(594, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(53, 20);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClearClickedHandler);
            // 
            // columnOrdinalNumber
            // 
            this.columnOrdinalNumber.DataPropertyName = "OrdinalNumber";
            this.columnOrdinalNumber.HeaderText = "No.";
            this.columnOrdinalNumber.Name = "columnOrdinalNumber";
            this.columnOrdinalNumber.ReadOnly = true;
            // 
            // columnWord
            // 
            this.columnWord.DataPropertyName = "MyWord";
            this.columnWord.HeaderText = "Word";
            this.columnWord.Name = "columnWord";
            // 
            // columnType
            // 
            this.columnType.DataPropertyName = "Type";
            this.columnType.HeaderText = "Type";
            this.columnType.Name = "columnType";
            this.columnType.Width = 70;
            // 
            // columnPron
            // 
            this.columnPron.DataPropertyName = "Pron";
            this.columnPron.HeaderText = "Pron";
            this.columnPron.Name = "columnPron";
            // 
            // columnMeaning
            // 
            this.columnMeaning.DataPropertyName = "Meaning";
            this.columnMeaning.HeaderText = "Meaning";
            this.columnMeaning.Name = "columnMeaning";
            this.columnMeaning.Width = 150;
            // 
            // columnExample
            // 
            this.columnExample.DataPropertyName = "Example";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.columnExample.DefaultCellStyle = dataGridViewCellStyle2;
            this.columnExample.HeaderText = "Example";
            this.columnExample.Name = "columnExample";
            this.columnExample.Width = 160;
            // 
            // columnCreatedAt
            // 
            this.columnCreatedAt.DataPropertyName = "CreatedAt";
            this.columnCreatedAt.HeaderText = "Created At";
            this.columnCreatedAt.Name = "columnCreatedAt";
            this.columnCreatedAt.ReadOnly = true;
            // 
            // columnUpdatedAt
            // 
            this.columnUpdatedAt.DataPropertyName = "UpdatedAt";
            this.columnUpdatedAt.HeaderText = "Updated At";
            this.columnUpdatedAt.Name = "columnUpdatedAt";
            this.columnUpdatedAt.ReadOnly = true;
            // 
            // MyWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 370);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewMyWords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyWords";
            this.Load += new System.EventHandler(this.loadAllWords);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMyWords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMyWords;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnOrdinalNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPron;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMeaning;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnExample;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnUpdatedAt;
    }
}