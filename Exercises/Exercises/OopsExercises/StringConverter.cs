using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.OopsExercises
{
    public class StringConverter
    {
        public string ConvertString(string input)
        {
            return input.ToUpper();
        }
        public string ConvertString(string input, bool toLower)
        {
            return !toLower ? input : input.ToLower();
        }
        public string ConvertString(string input, int toTitleCase)
        {
            if(string.IsNullOrWhiteSpace(input) || toTitleCase != 1)
                return input;
            string[] words = input.Split(' ');
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
                }
            }
            return String.Join(" ", words);
        }
    }
}
