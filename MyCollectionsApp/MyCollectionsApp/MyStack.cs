using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class MyStack
    {
        public void StackFunctions()
        {
            Stack<int> intStack = new Stack<int>();
            for(int i = 1; i <= 5; i++)
            {
                intStack.Push(i);
            }
            Console.WriteLine("Stack elements using for loop");
            for(int i = 0; i < intStack.Count; i++)
                Console.WriteLine(intStack.ElementAt(i));
            Console.WriteLine("\nInitial Count: " + intStack.Count);
            Console.WriteLine("for each");
            foreach(var item in intStack)
                Console.WriteLine(item);
            if (intStack.Contains(3))
            {
                Console.WriteLine("Pushed 3");
                intStack.Push(3);
            }
            Console.WriteLine("Peek: " + intStack.Peek());
            intStack.EnsureCapacity(10);
            Console.WriteLine("Count after ensure capacity: " + intStack.Count);
            Console.WriteLine("Stack elements using foreach finally");
            foreach (var item in intStack)
                Console.WriteLine(item);
        }
    }
}
