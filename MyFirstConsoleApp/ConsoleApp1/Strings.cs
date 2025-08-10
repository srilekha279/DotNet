using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strings
    {
        public void StringFunctions()
        {
            string str1 = "This is test";
            string str2 = "This is text";
            if (String.Compare(str2, str1) == 0)
                Console.WriteLine("equal");
            else
                Console.WriteLine("Not equal");

            if (str1.Contains("test"))
                Console.WriteLine("the sequence test is found");

            string substr = str2.Substring(3);
            Console.WriteLine(substr);

            Boolean result1 = false;
            string s1 = "C# Programming", s2 = "C# Programming", s3 = "ProgrammingWhiz";
            if (s1 == s2) result1 = true;
            Console.WriteLine("s1 and s2 are equal: " + result1);

            Boolean result2 = s1.Equals(s3);
            Console.WriteLine("s1 and s3 are equal:" + result2);

            Console.WriteLine("Joined string: " + String.Concat(str1, str2));

            string str = "This is \"string\" class";
            Console.WriteLine(str);

            //IndexOf, Substring, split
            string sen = "This sen is 5 words";
            int start = sen.IndexOf(" ") + 1;
            string word2 = sen.Substring(start, sen.IndexOf(" ", start ) - start);



        }
    }
}
