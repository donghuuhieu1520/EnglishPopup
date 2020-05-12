using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EnglishPopup.util
{
    class INIFile
    {
        private string filePath;

        [DllImport("kernel32", EntryPoint="WritePrivateProfileStringW",
                    SetLastError=true,
                    CharSet=CharSet.Unicode,
                    ExactSpelling=true,
                    CallingConvention=CallingConvention.StdCall)]
        private static extern long WritePrivateProfileString(string section,
        string key,
        string val,
        string filePath);

        [DllImport("kernel32", EntryPoint = "GetPrivateProfileStringW",
                    SetLastError = true,
                    CharSet = CharSet.Unicode,
                    ExactSpelling = true,
                    CallingConvention = CallingConvention.StdCall)]
        private static extern int GetPrivateProfileString(string section,
        string key,
        string def,
        StringBuilder retVal,
        int size,
        string filePath);

        public INIFile(string filePath)
        {
            string directory = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            bool fileExist = File.Exists(filePath);

            if (!fileExist)
            {
                StreamWriter writer = new StreamWriter(filePath, false, Encoding.Unicode);
                writer.Close();
            }

            this.filePath = filePath;
        }

        public void Write(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, this.filePath);
        }

        public string Read(string section, string key)
        {
            StringBuilder SB = new StringBuilder(255);
            int i = GetPrivateProfileString(section, key, "", SB, 255, this.filePath);
            return SB.ToString();
        }

        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }
    }
}
