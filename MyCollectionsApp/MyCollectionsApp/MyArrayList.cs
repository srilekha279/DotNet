using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCollectionsApp
{
    internal class MyArrayList
    {
        public void ArrayListFunctions()
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("Hello");
            al.Add("World");
            al.Add(45.03);
            al.Add(null);
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine($"Item {i}: {al[i]}");
            }
            Console.WriteLine($"Before adding: \nCount:{al.Count} \nCapacity: {al.Capacity}");

            ArrayList al1 = new ArrayList() { 1, "A", 20.2, 9 };
            al.AddRange(al1);
            Console.WriteLine("After adding:");
            Console.WriteLine($"Count:{al.Count} \nCapacity: {al.Capacity}");
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Hello exists: " + al.Contains("Hello"));
            if (al.Contains("Hello"))
            {
                Console.WriteLine("Hello exists");
                string strHello = (string)al[al.IndexOf("Hello")];
                al.Add(strHello);

            }
            else
            {
                Console.WriteLine("Does not exist");
            }
            al.Insert(al.IndexOf("Hello") + 1, "World");
            ArrayList al3 = new ArrayList() { "Welcome", "To", "Collections" };
            al.InsertRange(al.IndexOf("World") + 1, al3);
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Isfixedsize: " + al.IsFixedSize);
            Console.WriteLine("isreadonly: " + al.IsReadOnly);
            var arrFixed = ArrayList.FixedSize(al);
            Console.WriteLine("Or arrFixed:");
            Console.WriteLine("Isfixedsize: " + arrFixed.IsFixedSize);
            Console.WriteLine("isreadonly: " + arrFixed.IsReadOnly);
            ArrayList al2 = new ArrayList() { 34, 2, 9, 45, 0, 33 };
           // arrFixed.AddRange(al2); //exception
            Console.WriteLine("ToString:\n" + string.Join(" ", arrFixed.Cast<object>()));
            Console.WriteLine("ToString:\n" + string.Join(" ", arrFixed.ToArray()));

            al.Remove("Hello");
            al.RemoveAt(1);
            al.RemoveRange(0, 2);
           
            foreach (var item in al)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in arrFixed)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Count of al: {al.Count} and Count of arrFixed: {arrFixed.Count}");
            Console.WriteLine($"Capacity before trim to size: al = {al.Capacity}, arrFixed = {arrFixed.Capacity}");
            al.TrimToSize();
            Console.WriteLine($"Count of al: {al.Count} and Count of arrFixed: {arrFixed.Count}");
            Console.WriteLine($"Capacity after trim to size: al = {al.Capacity}, arrFixed = {arrFixed.Capacity}");
        }
    }
}
