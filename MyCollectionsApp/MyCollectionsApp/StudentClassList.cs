using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class StudentClassList
    {
        public List<Student1>students = new List<Student1>()
        {
            new Student1{Id = 1, Name = "Bill" },
            new Student1{Id = 2, Name = "Steve" },
            new Student1{Id = 3, Name = "Ram" },
            new Student1{Id = 4, Name = "Abdul" },
        };
        public void StudentListFunctions()
        {
            StudentManager sm = new StudentManager();
            sm.DisplayStudents();
            sm.AddStudents();
            Console.WriteLine("After adding students: ");
            sm.DisplayStudents();
           // students.Sort(); //Icomparer
          //  sm.DisplayStudents();

        }
    }
    class Student1
    {
        public int Id;
        public string Name;
        //public string grade;
        
    }
    class StudentManager
    {
        StudentClassList scl = new StudentClassList();
        public void AddStudents()
        {
            scl.students.Add(new Student1 { Id = 6, Name = "Tim" });
            scl.students.Add(new Student1 { Id = 7, Name = "Jenny" });
            List<Student1> extrastudents = new List<Student1> {
                { new Student1{Id = 5, Name = "Fahad"} }
                };
            scl.students.AddRange(extrastudents);
        }
        public void DisplayStudents()
        {
            foreach(Student1 std in scl.students)
            {
                Console.WriteLine($"Id: {std.Id} Name: {std.Name}");
            }
        }
    }
}
