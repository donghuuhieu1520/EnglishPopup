using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EnglishPopup.util;

namespace EnglishPopup
{
    public partial class Preferences : Form
    {
        private INIFile inif;
        private AppConfig conf;
        private Form ownerForm;
        public Preferences()
        {
            inif = new INIFile(AppConfig.PATH);
            InitializeComponent();
        }

        public Preferences(Form owner) : this()
        {
            ownerForm = owner;
        }

        private void save()
        {
            inif.Write("0", "interval", numericUpDownInterval.Value.ToString());
            inif.Write("0", "delay", numericUpDownStill.Value.ToString());
            inif.Write("0", "sound", checkBoxSound.Checked.ToString());
            inif.Write("0", "opacity", trackBarOpacity.Value.ToString());
            inif.Write("0", "random", checkBoxRandomOrder.Checked.ToString());

            Form1 parrent = this.ownerForm as Form1;
            if (parrent != null)
            {
                parrent.SetChangedConfig(AppConfig.Load(inif));
            }
        }

        private void buttonExitClickedHandler(object sender, EventArgs e)
        {
            Close();
        }

        private void preferenceFormOnLoadHandler(object sender, EventArgs e)
        {
            try
            {
                conf = AppConfig.Load(inif);
                decimal interval = (decimal)conf.Interval;
                decimal still = (decimal)conf.Delay;
                bool sound = conf.Sound;
                int opacity = (int)conf.Opacity;
                bool random = conf.Random;

                numericUpDownInterval.Value = interval;
                numericUpDownStill.Value = still;
                checkBoxSound.Checked = sound;
                trackBarOpacity.Value = opacity;
                checkBoxRandomOrder.Checked = random;
            } catch
            {
                save();
            }
        }

        private void buttonSaveClickedHandler(object sender, EventArgs e)
        {
            save();
            Close();
        }
    }
}
