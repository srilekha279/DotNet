using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsApp
{
    internal class MyExceptions
    {
        public void exceptions()
        {
            try
            {
                if (true)
                    throw new CustomExc("Custom exception");
                else
                    Console.WriteLine("....");
            }
            catch(Exception ex) { 
                Console.WriteLine(ex.ToString());
            }
        }
    }
    class CustomExc : Exception
    {
        public CustomExc() { }
        public CustomExc(string message) { 
            Console.WriteLine(message);
        }
    }
}
