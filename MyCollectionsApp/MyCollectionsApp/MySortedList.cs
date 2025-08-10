using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class MySortedList
    {
        public void SortedListFunctions()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            Console.WriteLine("Key Value Pairs");
            for(int i = 0; i < numberNames.Count; i++)
            {
                Console.Write(numberNames.Keys[i]);
                Console.WriteLine(": " + numberNames.Values[i]);
             //   Console.WriteLine(numberNames[i].K);
            }
            IList<int> keys = numberNames.Keys;
            IList<string>values = numberNames.Values;
            Console.WriteLine("Keys");
            for(int i = 0; i < keys.Count; i++)
                Console.Write($"{keys[i]}, ");
            Console.WriteLine("\nValues");
            for (int i = 0; i < values.Count; i++)
                Console.Write($"{values[i]}, ");
            Console.WriteLine($"\nCount: {numberNames.Count}, Capacity: {numberNames.Capacity}");
            SortedList<int, string> names = new SortedList<int, string>()
            {
                {4, "four" }, {5, "five"}
            };
            foreach(KeyValuePair<int, string> pair in names)
            {
                numberNames.Add(pair.Key, pair.Value);
            }
            Console.WriteLine("After adding");
            Console.WriteLine($"Count: {numberNames.Count}, Capacity: {numberNames.Capacity}");
            foreach(var kvp in numberNames)
            {
                Console.WriteLine(kvp.Key + ": " + kvp.Value);
            }
            Console.WriteLine("Value six exists: " + values.Contains("six"));
            if(keys.Contains(3))
            {
                Console.WriteLine("Exists");
                numberNames.TryGetValue(3, out string retrieved_value);
                //exception will be raised for below line
                //numberNames.Add(3, retrieved_value);
                Console.WriteLine("After adding");
                

            }
            else
            {
                Console.WriteLine("does not exist");
            }
            foreach(var kvp in numberNames)
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            //Remove(Key)
            //RemoveAt(index)
            numberNames.Remove(1);
            numberNames.Remove(20); //20 is not among keys
            numberNames.RemoveAt(0);
            // numberNames.RemoveAt(22); //index out of range exception
            Console.WriteLine("After removing");
            foreach (var kvp in numberNames)
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
        }
    }
}
