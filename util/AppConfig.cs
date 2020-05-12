using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishPopup.util
{
    class AppConfig
    {
        private INIFile init;
        private int wordsQuantity;
        private double interval;
        private int delay;
        private bool sound;
        private double opacity;
        private bool random;

        public static readonly string PATH = Path.Combine(
            System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "EnglishPopup", "data.ini");

        public int WordsQuantity { get => wordsQuantity; set => wordsQuantity = value; }
        public double Interval { get => interval; set => interval = value; }
        public int Delay { get => delay; set => delay = value; }
        public bool Sound { get => sound; set => sound = value; }
        public double Opacity { get => opacity; set => opacity = value; }
        public bool Random { get => random; set => random = value; }
        internal INIFile Init { get => init; set => init = value; }

        public static AppConfig Load(INIFile ini)
        {
            AppConfig conf = new AppConfig();
            conf.Init = ini;

            int.TryParse(ini.Read("0", "soluongcautruc"), out int wordQuantity);
            double.TryParse(ini.Read("0", "interval"), out double interval);
            int.TryParse(ini.Read("0", "delay"), out int delay);
            bool.TryParse(ini.Read("0", "sound"), out bool sound);
            double.TryParse(ini.Read("0", "opacity"), out double opacity);
            bool.TryParse(ini.Read("0", "random"), out bool random);

            conf.WordsQuantity = wordQuantity;
            conf.Interval = interval == 0 ? 1 : interval;
            conf.Delay = delay == 0 ? 5 : delay;
            conf.Sound = sound;
            conf.Opacity = opacity;
            conf.Random = random;

            return conf;
        }

        public void Save()
        {
            init.Write("0", "soluongcautruc", wordsQuantity.ToString());
            init.Write("0", "interval", interval.ToString());
            init.Write("0", "delay", delay.ToString());
            init.Write("0", "sound", sound.ToString());
            init.Write("0", "opacity", opacity.ToString());
            init.Write("0", "random", random.ToString());
        }
    }
}
