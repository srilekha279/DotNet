using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class BasicLinq
    {
        public void LinqBasics()
        {
            string[] names = { "Bill", "Steve", "James", "Rohan" };
            //Delayed execution
            //var myLinqQuery = from name in names
            //                  where name.Contains("a")
            //                  select name;
            var myLinqQuery = (from name in names
                              where name.Contains("a")
                              select name).ToList();

            Console.WriteLine("Original list:");
            foreach (var name in names) Console.Write(name + " ");
            Console.WriteLine("\nNames that contain letter a:");
            foreach (var item in myLinqQuery)
                Console.Write(item + " ");
            Console.WriteLine();

            //method syntax or fluent syntax
            var teenagers = names
                            .Where(name => name.Contains('a'))
                            .ToList();
            foreach (var name in teenagers)
                Console.Write(name + " ");
            Console.WriteLine();
        }
    }
}
