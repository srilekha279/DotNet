using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    public delegate T MyAdd<T>(T param1, T param2);
    internal class GenericDelegates
    {
        public void CallFunctions()
        {
            MyAdd<int> sum = X.Sum; //static, method in different class
            Console.WriteLine("Adding integers: " + sum(10, 20));

            MyAdd<string> concat = new GenericDelegates().Concat; //non static, within same class
            Console.WriteLine("Adding strings: " + concat("good", "morning"));

        }
        public string Concat(string s1, string s2)
        {
            return s1 + s2;
        }
    }
    class X
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
       
    }
}
