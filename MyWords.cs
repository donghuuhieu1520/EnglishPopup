using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using EnglishPopup.util;

namespace EnglishPopup
{
    public partial class MyWords : MetroFramework.Forms.MetroForm
    {
        private INIFile inif;
        private AppConfig conf;
        private BindingList<Word> words;
        private BindingSource source;
        private List<Word> beforeModifiedWords;
        private List<Word> afterModifiedWords;
        private List<Word> selectedWords;

        public MyWords()
        {
            inif = new INIFile(AppConfig.PATH);
            words = new BindingList<Word>();
            beforeModifiedWords = new List<Word>();
            afterModifiedWords = new List<Word>();
            selectedWords = new List<Word>();
            InitializeComponent();
        }

        private void loadAllWords(object sender, EventArgs e)
        {
            conf = AppConfig.Load(inif);

            for (int i = 1; i <= conf.WordsQuantity; i++)
            {
                Word w = Word.Load(inif, i);
                w.Example = w.Example.Replace("\\n", "\n");
                words.Add(w);
            }

            source = new BindingSource(words, null);
            dataGridViewMyWords.DataSource = source;
        }


        private void cellEndEditHandler(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridViewMyWords.Rows[e.RowIndex];
            Word modifiedWord = (Word)row.DataBoundItem;

            Word match = beforeModifiedWords.Find(w => modifiedWord.OrdinalNumber == w.OrdinalNumber);

            if (match != null)
            {
                bool changeUndo = match.Equals(modifiedWord);
                if (changeUndo)
                {
                    beforeModifiedWords.Remove(match);
                    afterModifiedWords.Remove(modifiedWord);
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                } else
                {
                    bool contained = afterModifiedWords.Contains(modifiedWord);
                    if (!contained)
                    {
                        afterModifiedWords.Add(modifiedWord);
                        row.DefaultCellStyle.BackColor = Color.LightBlue;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }



            if (afterModifiedWords.Count != 0) buttonUpdate.Enabled = true;
            else buttonUpdate.Enabled = false;
        }

        private void cellBeginEditHandler(object sender, DataGridViewCellCancelEventArgs e)
        {
            var row = dataGridViewMyWords.Rows[e.RowIndex];

            Word modifiedWord = Word.From((Word)row.DataBoundItem);

            Word match = beforeModifiedWords.Find(w => modifiedWord.OrdinalNumber == w.OrdinalNumber);
            if (match == null)
            {
                beforeModifiedWords.Add(modifiedWord);
            }
        }

        private void buttonUpdateClickHandler(object sender, EventArgs e)
        {
            if (afterModifiedWords.Count != 0)
            {
                int count = 0;
                afterModifiedWords.ForEach(w =>
                {
                    w.UpdatedAt = DateTime.Now;
                    w.Save(inif);
                    count++;
                });
                afterModifiedWords.Clear();
                beforeModifiedWords.Clear();
                buttonUpdate.Enabled = false;
                MessageBox.Show($"Update {count} words successfully!", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonFindClickedHandler(object sender, EventArgs e)
        {
            string type = comboBoxType.Text;
            string search = textBoxSearch.Text;
            DateTime from = dateTimePickerFrom.Value;
            DateTime to = dateTimePickerTo.Value;

            foreach(DataGridViewRow row in dataGridViewMyWords.Rows)
            {

                CurrencyManager currManager = (CurrencyManager)BindingContext[dataGridViewMyWords.DataSource];
                currManager.SuspendBinding();

                bool visible = true;
                Word w = (Word)row.DataBoundItem;

                if (type != "All" && w.Type != type) visible = false;
                if (from != null && w.CreatedAt < from) visible = false;
                if (to != null && w.CreatedAt > to) visible = false;
                if (!string.IsNullOrEmpty(search))
                {
                    Regex reg = new Regex(search);
                    visible = reg.IsMatch(w.MyWord) || reg.IsMatch(w.Meaning) || reg.IsMatch(w.Example);
                }
                row.Visible = visible;

                currManager.ResumeBinding();
            }

        }

        private void buttonClearClickedHandler(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMyWords.Rows)
            {
                if (!row.Visible) row.Visible = true;
            }
        }
    }
}
