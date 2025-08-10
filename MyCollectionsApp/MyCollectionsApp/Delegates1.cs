using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    public delegate int MyDelegate(); 
    internal class Delegates1
    {
        public void AcceptAndPrint()
        {
            MyDelegate del1 = new MyDelegate(ClassA.MethodA);
            MyDelegate del2 = ClassB.MethodB;
            MyDelegate del = del1 + del2;
            Console.WriteLine("Delegate1 returns " + del1());
            Console.WriteLine("Delegate2 returns " + del2());
            Console.WriteLine("Delegate1 + Delegate2 returns "+ del());

        }
    }
    class ClassA()
    {
        public static int  MethodA()
        {
            Console.WriteLine("Method A called, returning 100");
            return 100;
        }
    }
    class ClassB()
    {
        public static int  MethodB()
        {
            Console.WriteLine("Method B called, returning 200");
            return 200;
        }
    }
}
