using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.OopsExercises
{
    public class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }

        }
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public static void Test()
        {
            Person p = new Person();
            Console.WriteLine("Enter the details of person: ");
            Console.Write("Name: ");
            p.Name = Console.ReadLine();
            Console.Write("Age: ");
            p.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Address: ");
            p.Address = Console.ReadLine();
            Console.WriteLine("\nPerson's Information:");
            Console.WriteLine($"Name: {p.Name}");
            Console.WriteLine($"Age: {p.Age}");
            Console.WriteLine($"Address: {p.Address}");
        }
    }
}
