using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Singleton
    {
        private static Singleton instance = null;
        private static string CreatedOn;
        private Singleton()
        {
            CreatedOn = DateTime.Now.ToLongTimeString();
        }
        public static Singleton getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            Console.WriteLine(CreatedOn);
            return instance;
        }
    }
}
