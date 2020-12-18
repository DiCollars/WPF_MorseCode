using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MorseCodeLibrary
{
    public static class MC
    {
        private static List<(string, string, string)> CodeMorseAlphabetic = new List<(string, string, string)>
        {
             ("А", "A", ".-"),
             ("Б", "B", "-..."),
             ("В", "W", ".--"),
             ("Г", "G", "--."),
             ("Д", "D", "-.."),
             ("Е", "E", "."),
             ("Ж", "V", "...-"),
             ("З", "Z", "--.."),
             ("И", "I", ".."),
             ("Й", "J", ".---"),
             ("К", "K", "-.-"),
             ("Л", "L", ".-.."),
             ("М", "M", "--"),
             ("Н", "N", "-."),
             ("О", "O", "---"),
             ("П", "P", ".--."),
             ("Р", "R", ".-."),
             ("С", "S", "..."),
             ("Т", "T", "-"),
             ("У", "U", "..-"),
             ("Ф", "F", "..-."),
             ("Х", "H", "...."),
             ("Ц", "C", "-.-."),
             ("Ч", "Ö", "---."),
             ("Ш", "CH", "----"),
             ("Щ", "Q", "--.-"),
             ("Ъ", "Ñ", "--.--"),
             ("Ы", "Y", "-.--"),
             ("Ь", "X", "-..-"),
             ("Э", "É", "..-.."),
             ("Ю", "Ü", "..--"),
             ("Я", "Ä", ".-.-"),
             ("1", "1", ".----"),
             ("2", "2", "..---"),
             ("3", "3", "...--"),
             ("4", "4", "....-"),
             ("5", "5", "....."),
             ("6", "6", "-...."),
             ("7", "7", "--..."),
             ("8", "8", "---.."),
             ("9", "9", "----."),
             ("0", "0", "-----"),
             (".", " ", "......"),
             (",", ".", ".-.-.-"),
             ("!", ",", "--..--"),
             ("", "!", "-.-.--"),
             ("?", "?", "..--.."),
             ("\'", "\'", ".----."),
             ("\"", "\"", ".-..-."),
             (";", ";", "-.-.-."),
             (":", ":", "---..."),
             ("-", "-", "-....-"),
             ("+", "+", ".-.-."),
             ("=", "=", "-...-"),
             ("_", "_", "..--.-"),
             ("/", "/", "-..-."),
             (" ", "(", "-.--."),
             ("ИЛИ", ")", "-.--.-"),
             ("&", "&", ".-..."),
             ("$", "$", "...-..-"),
             ("@", "@", ".--.-."),
             ("ОШИБКА", "ERROR", "........"),
             ("Конец связи", "END CONTACT", "..-.-")
        };

        public static string ConvertToCM(bool rus, string data)
        {
            string convertedText = "";

            if (rus)
            {
                foreach (var symbol in data.ToUpper())
                {
                    foreach (var item in CodeMorseAlphabetic)
                    {
                        if (symbol.ToString() == item.Item1)
                        {
                            convertedText += (item.Item3 + " ");
                        }
                    }
                }
            }

            else
            {
                foreach (var symbol in data.ToUpper())
                {
                    foreach (var item in CodeMorseAlphabetic)
                    {
                        if (symbol.ToString() == item.Item2)
                        {
                            convertedText += (item.Item3 + " ");
                        }
                    }
                }
            }

            return convertedText;
        }

        public static string ConvertFromCM(bool rus, string data)
        {
            var dataArray = Regex.Replace(data, @"\s+", " ").Split(" ");
            string convertedText = "";

            if (rus)
            {
                foreach (var symbol in dataArray)
                {
                    foreach (var item in CodeMorseAlphabetic)
                    {
                        if (symbol == item.Item3)
                        {
                            convertedText += item.Item1;
                        }
                    }
                }
            }

            else
            {
                foreach (var symbol in dataArray)
                {
                    foreach (var item in CodeMorseAlphabetic)
                    {
                        if (symbol == item.Item3)
                        {
                            convertedText += item.Item2;
                        }
                    }
                }
            }

            return convertedText;
        }
    }
}