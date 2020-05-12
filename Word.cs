using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnglishPopup.util;

namespace EnglishPopup
{
    class Word
    {
        private int ordinalNumber;

        private string myWord;
        private string type;
        private string pron;
        private string meaning;
        private string example;
        private DateTime createdAt;
        private DateTime updatedAt;

        public string Type { get => type; set => type = value; }
        public string Pron { get => pron; set => pron = value; }
        public string Meaning { get => meaning; set => meaning = value; }
        public string Example { get => example; set => example = value; }
        public string MyWord { get => myWord; set => myWord = value; }
        
        public int OrdinalNumber { get => ordinalNumber; set => ordinalNumber = value; }
        public DateTime CreatedAt { get => createdAt; set => createdAt = value; }
        public DateTime UpdatedAt { get => updatedAt; set => updatedAt = value; }

        public Word()
        {

        }

        public Word(string myWord, string type, string pron, string meaning, string example, int ordinalNumber)
        {
            MyWord = myWord;
            Type = type;
            Pron = pron;
            Meaning = meaning;
            Example = example;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            OrdinalNumber = ordinalNumber;
        }

        public static Word From(Word word)
        {
            Word cloneWord = new Word();

            cloneWord.MyWord = word.MyWord;
            cloneWord.Type = word.Type;
            cloneWord.Pron = word.Pron;
            cloneWord.Meaning = word.Meaning;
            cloneWord.Example = word.Example;
            cloneWord.CreatedAt = word.CreatedAt;
            cloneWord.UpdatedAt = word.UpdatedAt;
            cloneWord.OrdinalNumber = word.OrdinalNumber;

            return cloneWord;
        }

        public void Save(INIFile inif)
        {
            string ordinalNumberInString = ordinalNumber.ToString();
            inif.Write(ordinalNumberInString, "word", MyWord);
            inif.Write(ordinalNumberInString, "type", Type);
            inif.Write(ordinalNumberInString, "pron", Pron);
            inif.Write(ordinalNumberInString, "meaning", Meaning);
            inif.Write(ordinalNumberInString, "example", Example);
            inif.Write(ordinalNumberInString, "createdAt", createdAt.ToString());
            inif.Write(ordinalNumberInString, "updatedAt", updatedAt.ToString());
        }

        public static Word Load(INIFile inif, int ordinalNumber)
        {            
            string ordinalNumberInString = ordinalNumber.ToString();
            string word = inif.Read(ordinalNumberInString, "word");
            string type= inif.Read(ordinalNumberInString, "type");
            string pron = inif.Read(ordinalNumberInString, "pron");
            string meaning = inif.Read(ordinalNumberInString, "meaning");
            string example = inif.Read(ordinalNumberInString, "example");
            string createdAt = inif.Read(ordinalNumberInString, "createdAt");
            string updatedAt = inif.Read(ordinalNumberInString, "updatedAt");

            Word newWord = new Word(word, type, pron, meaning, example, ordinalNumber);

            bool createdAtParsedSuccess = DateTime.TryParse(createdAt, out DateTime createdAtInDateTime);
            bool updatedAtParsedSuccess = DateTime.TryParse(createdAt, out DateTime updatedAtInDateTime);

            newWord.CreatedAt = createdAtParsedSuccess ? createdAtInDateTime : DateTime.Now;
            newWord.UpdatedAt = updatedAtParsedSuccess ? updatedAtInDateTime : DateTime.Now;

            return new Word(word, type, pron, meaning, example, ordinalNumber);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Word w = obj as Word;

            if (w == null)
            {
                return false;
            }


            return MyWord == w.MyWord
                && Type == w.Type
                && Meaning == w.Meaning
                && Pron == w.Pron
                && Example == w.Example;
        }
        public override int GetHashCode()
        {
            return MyWord.GetHashCode() ^ Type.GetHashCode() ^ Meaning.GetHashCode() ^ Pron.GetHashCode() ^ Example.GetHashCode();
        }

    }
}
