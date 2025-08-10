using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsApp
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
            Console.WriteLine($"Count:{al.Count} \nCapacity: {al.Capacity}");

           // ArrayList al1 = new ArrayList() {1, "A", 20.2, 9 };
           // al.AddRange(al1);
           // Console.WriteLine("After adding:");

           // Console.WriteLine($"Count:{al.Count} \nCapacity: {al.Capacity}");
           // foreach(var item in al)
           // {
           //     Console.Write(item + " ");
           // }
           // Console.WriteLine();

           //// Console.WriteLine("Hello exists: " + al.Contains("Hello"));
           // if(al.Contains("Hello"))
           // {
           //     Console.WriteLine("Hello exists");
           //     int ind = al.IndexOf("Hello");
           //     string strHello = (string)al[ind];
           //     al.Add(strHello);

           // }
           // else
           // {
           //     Console.WriteLine("Does not exist");
           // }
           // al.Insert(al.IndexOf("Hello"), "World");
           // ArrayList al3 = new ArrayList() { "Welcome", "To", "Collections" };
           // al.InsertRange(al.IndexOf("World"), al3);
           // foreach(var item in al)
           // {
           //     Console.WriteLine (item + " ");
           // }
            Console.WriteLine(al.IsFixedSize);
            Console.WriteLine(al.IsReadOnly);
            //fixing the array on an earlier array list
          //  ArrayList arrFixed = new ArrayList(al);
            var arrFixed = ArrayList.FixedSize(al);
            //Console.WriteLine(arrFixed.IsFixedSize);
            ArrayList newal = new ArrayList() { 34, 2, 9, 45, 0, 35};
           // newal.AddRange(arrFixed);
            //apply toString() on this arraylist to get the elements into a string and display the string
            Console.WriteLine(newal.ToString());
            //  al.Remove("Hello");
            //foreach (var item in al)
                //Console.WriteLine(item);
            //Removeat(index)
            //RemoveRange
            //


        }
    }
}
