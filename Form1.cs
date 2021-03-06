﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

using Tulpep.NotificationWindow;
using EnglishPopup.util;

namespace EnglishPopup
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private INIFile inif;
        private AppConfig conf;
        private PopupNotifier popup;
        private SoundPlayer player;
        private int nextWord;
        private Random r;

        public Form1()
        {
            r = new Random();
            nextWord = 1;
            player = new SoundPlayer(Properties.Resources.messenger);
            popup = new PopupNotifier();

            popup.Appear += (s, ev) =>
            {
                timer1.Enabled = false;
                if (conf.Sound) player.Play();
            };
            popup.Disappear += (s, e) => timer1.Enabled = true;

            popup.ContentPadding = new Padding(10);
            popup.TitlePadding = new Padding(10);
            popup.HeaderColor = Color.Black;
            popup.Size = new Size(350, 250);

            popup.HeaderHeight = 25;

            inif = new INIFile(AppConfig.PATH);
            InitializeComponent();
        }


        private void exitEnglishPop(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAddClickHandler(object sender, EventArgs e)
        {
            string word = textBoxWord.Text;
            string wordType = comboBoxType.Text;
            string wordPron = textBoxPron.Text;
            string wordMeaning = textBoxMeaning.Text;
            string wordExample = richTextBoxExample.Text;
            wordExample = wordExample.Replace("\n", "\\n");

            if (string.IsNullOrEmpty(word))
            {
                MessageBox.Show("Please fill in the word text box", "Oop! Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxWord.Focus();
                return;
            }

            Word newWord = new Word(word, wordType, wordPron, wordMeaning, wordExample, ++conf.WordsQuantity);

            conf.Save();
            newWord.Save(inif);

            textBoxWord.Clear();
            comboBoxType.Text = "";
            textBoxPron.Clear();
            textBoxMeaning.Clear();
            richTextBoxExample.Clear();

            MessageBox.Show("Add new word successfully", "Great!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadConfigs(object sender, EventArgs e)
        {
            conf = AppConfig.Load(inif);
            if (conf.Interval == 0 || conf.Delay == 0)
            {
                Preferences formPref = new Preferences();
                formPref.ShowDialog(this);
                formPref.Dispose();
            }
            timer1.Interval = (int)conf.Interval * 60 * 1000;
            popup.Delay = conf.Delay * 1000;
        }

        private void myWordsToolStripMenuItemClickHandler(object sender, EventArgs e)
        {
            using (MyWords formMyWords = new MyWords())
            {
                formMyWords.ShowDialog(null);
                formMyWords.Dispose();
            }
        }

        private void popupToolStripMenuItemClickedHandler(object sender, EventArgs e)
        {
            using (Preferences formPref = new Preferences(this))
            {
                formPref.ShowDialog(null);
                formPref.Dispose();
            }
        }

        private void buttonStartClickedHandler(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Hide();
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "You can show the application from this icon!";
            notifyIcon1.BalloonTipTitle = "Hey buddy!";
            notifyIcon1.ShowBalloonTip(3000);
        }

        private void showApplication(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Show();
        }

        private void ExitApp(object sender, EventArgs e)
        {
            Close();
        }

        internal void SetChangedConfig(AppConfig conf)
        {
            this.conf = conf;
            timer1.Interval = (int)conf.Interval * 60 * 1000;
            popup.Delay = conf.Delay * 1000;
        }

        private void timerHandler(object sender, EventArgs e)
        {
            if (conf.Random)
            {
                nextWord = r.Next(1, conf.WordsQuantity);
            }
            else
            {
                if (++nextWord > conf.WordsQuantity) nextWord = 1;
            }
            
            
            Word w = Word.Load(inif, nextWord);

            popup.TitleText = $"{w.MyWord} ({w.Type}) {w.Pron}";
            popup.ContentText = $@"{w.Meaning}
Example:
{w.Example.Replace("\\n", "\n")}";
            popup.Popup();
        }

        private void showAbout(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Hieu Dong ^^\nVersion: 1.0\nContact: donghuuhieu1520@gmail.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ImportFromFileClickHandler(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select your word files";
            openFileDialog.InitialDirectory = Environment.SpecialFolder.LocalApplicationData.ToString();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Configuration settings (*.ini)|*.ini";

            var result = openFileDialog.ShowDialog(this);
            if (result != DialogResult.OK)
            {
                return;
            }

            var tempInif = new INIFile(openFileDialog.FileName);
            var tempConf= AppConfig.Load(tempInif);


            int totalWordQuantity = conf.WordsQuantity + tempConf.WordsQuantity;
            
            for (int i = conf.WordsQuantity + 1; i <= totalWordQuantity; i++)
            {
                Word newWord = Word.Load(tempInif, i - conf.WordsQuantity);
                newWord.Save(inif);
            }

            conf.WordsQuantity = totalWordQuantity;
            conf.Save();

            MessageBox.Show(this, "Import words from your file success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
