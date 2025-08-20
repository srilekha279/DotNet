using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.OopsExercises
{
    public class Student
    {
        public string Name;
        public int Age;
        public string Grade;

        Student()
        {
            Name = "Hellen Doe";
            Age = 21;
            Grade = "A";
        }

        Student(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public static void Test()
        {
            Console.WriteLine("Enter the details of new student: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            string grade = Console.ReadLine();

            Student defstd = new Student();
            Student std = new Student(name, age, grade);

            Console.WriteLine("\nDefault Student:");
            Console.WriteLine($"Name: {defstd.Name}");
            Console.WriteLine($"Age: {defstd.Age}");
            Console.WriteLine($"Grade: {defstd.Grade}");

            Console.WriteLine("\nNew Student:");
            Console.WriteLine($"Name: {std.Name}");
            Console.WriteLine($"Age: {std.Age}");
            Console.WriteLine($"Grade: {std.Grade}");
        }
    }
}
