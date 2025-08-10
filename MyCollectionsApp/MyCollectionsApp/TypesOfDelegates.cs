using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class TypesOfDelegates
    {
        public void Execute()
        {
            Predicate<string> pred = CheckIsUpper;
            Console.WriteLine(pred("L"));
        }
        public bool CheckIsUpper(string str)
        {
            if (str.Equals(str.ToUpper()))
                return true;
            return false;
        }
    }
}
