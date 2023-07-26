using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11Task1
{
    internal class Doc
    {
        public bool CountText(string text, int count)
        {
            string[] arrText = text.Split(' ');
            if (arrText.Length >= count)
                return false;
            return true;
        }

        public bool RepitedWord(string text, int percentage)
        {
            string[] arrText = text.Split(' ', '!', '?', ',');
            List<string> CountWord = new List<string>();
            foreach (string word in arrText)
            {
                CountWord.Add(word);
            }
            for (int i = 0; i < arrText.Length; i++)
            {
                int a = CountWord.FindAll(x => x == arrText[i]).Count();
                if (a >= arrText.Length * percentage / 100D)
                    return true;
            }

            return false;
        }

        public bool FirstWordCapital(string text)
        {
            for (int i = 0; i < text.Length - 2; i++)
            {
                var firstSimvol = $"{text[0]}";
                if (firstSimvol.ToLower() == firstSimvol)
                    return true;
                if (text[i] == '.' && text[i + 1] == ' ')
                {
                    var a = $"{text[i + 2]}";
                    if (a.ToLower() == a)
                        return true;
                }
                if (text[i] == '.' && text[i + 1] != ' ')
                {
                    var a = $"{text[i + 1]}";
                    if (a.ToLower() == a)
                        return true;
                }
            }

            return false;
        }

        public bool OtherNotCapital(string text)
        {
            string[] arrTxt = text.Split('.', '?', '!');
            foreach (string str in arrTxt)
            {
                if (str[0] != ' ')
                {
                    string a = $"{str[0]}".ToUpper();
                    for (int i = 1; i < str.Length; i++)
                    {
                        a += $"{str[i]}".ToLower();
                    }
                    if (a != str)
                        return true;
                }
                else
                {
                    string a = $"{str[1]}".ToUpper();
                    for (int i = 2; i < str.Length; i++)
                    {
                        a += $"{str[i]}".ToLower();
                    }
                    Console.WriteLine(a);
                    if (a != str)
                        return true;
                }
            }
            return false;
        }
        public bool LengthWord(string text, int LengthOfWord)
        {
            foreach(string word in text.Split(' ', '!', '?', ','))
            {
                if (word.Length >= LengthOfWord)
                    return true;
            }
            return false;
        }
    }
}
