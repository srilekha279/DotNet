using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct DateOfBirth
    {
        public int day; public int month; public int year;
    }
    public struct Emp
    {
        public String EmpName;
        public DateOfBirth dob;
        public void Display()
        {
            Console.WriteLine("Name of the Employee: " + EmpName);
            Console.WriteLine($"Date of Birth(dd-mm-yy): {dob.day} - {dob.month} - {dob.year}");
        }
    }
    struct newStruct
    {
        public int StudentID;
        public string StudentName;
    }
    internal class SimpleStruct
    {
        public Emp emp;
        public SimpleStruct() { }
        public void AcceptAndPrint()
        {
            //Console.Clear();
            Console.WriteLine("Enter Emp Name");
            emp.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the Date of Birth: Date");
            emp.dob.day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Date of Birth: Month");
            emp.dob.month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Date of Birth: Year");
            emp.dob.year = Convert.ToInt32(Console.ReadLine());
            emp.Display();

            newStruct stu = new newStruct();
            stu.StudentName = "John";
            stu.StudentID = 100;
           // Console.Clear();
            Console.WriteLine($"{stu.StudentID}, {stu.StudentName}");
        }
    }
}
