using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyStringBuilder
    {
        public void Methods()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("hello");
            sb.Append("world");
            sb.Append("10");
            sb.Append(DateTime.Now);
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"length: {sb.Length}, {sb}" );

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("welcome to ");
            sb1.Append("c#");
            Console.WriteLine(sb1);
            sb1.Insert(11, "the beautiful world of ");

            sb1.Remove(11, 10);
            Console.WriteLine($"Length: {sb1.Length} and Capacity: {sb1.Capacity}");

            sb1.Replace('o', 'a');
            Console.WriteLine(sb1);
        }

        public void Session1()
        {
            Console.WriteLine("Enter a multi word string:");
            string str = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            for(int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char temp = sb[i];
                sb[i] = sb[j];
                sb[j] = temp;
            }
            Console.WriteLine("Reversed string: " +  sb);
            Console.WriteLine($"Length: {sb.Length} and Capacity: {sb.Capacity}");
            sb.Clear();
            Console.WriteLine($"Length: {sb.Length} and Capacity: {sb.Capacity}");

            StringBuilder sb1 = new StringBuilder("She sells sea shells on the sea shore");
            Console.WriteLine(sb1);
            sb1.Replace("sh", "h");
            Console.WriteLine(sb1);
            sb1.Replace("sh", "h", 0, 5);
            Console.WriteLine(sb1);
        }
    }
}
