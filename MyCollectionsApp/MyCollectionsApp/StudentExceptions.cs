using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class StudentExceptions
    {
        public void GetStudentDetails()
        {
            Student newStudent;
            try
            {
                newStudent = new Student();
                newStudent.Name = "008";
                ValidateStudent(newStudent);
            }
            catch (InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void ValidateStudent(Student student)
        {
            Regex regex = new Regex("^[A-Za-z]+$");
            if (!regex.IsMatch(student.Name))
            {
                throw new InvalidStudentNameException(student.Name);
            }
        }
    }
    class InvalidStudentNameException : Exception
    {
        public InvalidStudentNameException() { }
        public InvalidStudentNameException(string name) : base($"Invalid name: {name}")
        { }
    }
    class Student
    {
        public int id;
        public string Name;
    }
}
 