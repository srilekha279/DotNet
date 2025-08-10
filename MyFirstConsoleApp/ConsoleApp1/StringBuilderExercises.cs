using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;
using System.Runtime.Intrinsics.X86;

namespace ConsoleApp1
{
    internal class StringBuilderExercises
    {
        StringBuilder sb = new StringBuilder("This is sample text");
        public void CallMethods()
        {
            //Count and display the no.of words and no.of chars, in this string.
            Count();
            //Find the length of this string w/o using the Length property.
            GetLength();
            //Replace all occurrence of the char ‘e’ in this sentence and redisplay.
            sb.Replace('e', '#');
            Console.WriteLine("After replacing 'e' with '#': " + sb.ToString());
            //Create this string, and add one word of this at a time to a StringBuilder object, and display it.
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            StringBuilder sb1 = new StringBuilder();
            foreach(string word in str.Split(" "))
            {
                sb1.Append(word);
                sb1.Append(" ");
            } 
            Console.WriteLine(sb1.ToString());
            //Split this sentence into words and store into a string array. Display the elements of the string array. 
            string[] words = sb.ToString().Split(" ");
            Console.WriteLine("Words in the sentence: ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();
            //Count the occurrence of the independent word ‘string’ in all the above sentences here.
            WordCount();

        }
        public void Count()
        {
            string[] words = sb.ToString().Split(" ");
            Console.WriteLine("No of words: " + words.Length);
            Console.WriteLine("No of characters: " + sb.Length);
        }
        public void GetLength()
        {
            int cnt = 0;
            foreach (char c in sb.ToString())
                cnt++;
            Console.WriteLine("Length of the string: " + cnt);
        }
        public void WordCount()
        {

        }
        
    }
}
