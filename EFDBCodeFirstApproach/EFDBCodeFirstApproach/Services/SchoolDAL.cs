using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDBCodeFirstApproach.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDBCodeFirstApproach.Services
{
    internal class SchoolDAL
    {
        StudentDbContext context;
        public SchoolDAL()
        {
            context = new StudentDbContext();
        }
        public int AddGrades()
        {
            int rowsAffected = 0;
            DisplayStates();
            IList<Grade> grades = new List<Grade>();
            grades.Add(new Grade() { GradeName = "Grade 1", Section = "section 1" });
            grades.Add(new Grade() { GradeName = "Grade 2", Section = "section 2" });
            grades.Add(new Grade() { GradeName = "Grade 3", Section = "section 3" });
            context.Grades.AddRange(grades);
            rowsAffected = context.SaveChanges();
            Console.WriteLine(rowsAffected + " records updated");
            return rowsAffected;
        }
        public void AddGrade(Grade g)
        {
            int rowsAffected = 1;
            IList<Grade> grades = new List<Grade>();
            grades.Add(new Grade() { GradeName = g.GradeName, Section = g.Section });
            context.Grades.AddRange(grades);
            rowsAffected = context.SaveChanges();
            Console.WriteLine(rowsAffected + " records updated");
        }
        public void DisplayStates()
        {
            foreach(var entry in context.ChangeTracker.Entries())
            {
                Console.WriteLine($"Entity: {entry.Entity.GetType().Name}, State:{entry.State.ToString()}");
            }
        }
        public int GetGradeId(Grade g)
        {
            Console.WriteLine("Enter grade id to update:");
            int gradeId = int.Parse(Console.ReadLine());
            if (gradeId == null)
                Console.WriteLine("No grade");
            else
            {
                Console.WriteLine($"Grade Info: \nName: {g.GradeName}, Section: {g.Section}");
                Console.WriteLine("Enter grade name and section name:");
                g.GradeName = Console.ReadLine();
                g.Section = Console.ReadLine();
            }
            return gradeId;
        }
        public int UpdateGrade(int gradeId, Grade g1)
        {
            Grade g = new Grade();
            var existingRecord = context.Grades.Single(g => g.GradeId == gradeId);
            if(existingRecord != null)
            {
                existingRecord.GradeName = g1.GradeName;
                existingRecord.Section = g1.Section;
                return context.SaveChanges() ;
            }
            return 0;
        }
        public int AddStudents()
        {
            int rowsAffected = 0;
            //DisplayStates();
            IList<Student> students = new List<Student>();
            students.Add(new Student() { StudentName = "jai", DateOfBirth = new DateTime(2004, 6, 27), Height = 155, Weight = 45, GradeId = 1});
            students.Add(new Student() { StudentName = "priya", DateOfBirth = new DateTime(2003, 2, 1), Height = 153.5m, Weight = 55, GradeId = 2 });
            students.Add(new Student() { StudentName = "siya", DateOfBirth = new DateTime(2002, 1, 1), Height = 159, Weight = 49, GradeId = 1 });

            context.Students.AddRange(students);
            rowsAffected = context.SaveChanges();
           
            return rowsAffected;
        }
        public Student GetStudentbyId(int stuId)
        {
            Student std;
            try
            {
                //std = context.Students.FromSql($"select * from students where StudentId = {stuId}").FirstOrDefault();
                std = context.Students
                          .Include(s => s.Grade)
                          .FirstOrDefault(s => s.StudentId == stuId);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return std;
        }
    }
}
