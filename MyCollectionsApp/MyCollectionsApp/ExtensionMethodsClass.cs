using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal static class ExtensionMethodsClass
    {
        public static int IntegerExtension(this string str)
        {
            return Int32.Parse(str);
        }
        
    }
    public static class StringExtension
    {
        public static int GetWordCount(this  string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            string[] stringArray= str.Split(" ");
            return stringArray.Count();
        }
    }
}
