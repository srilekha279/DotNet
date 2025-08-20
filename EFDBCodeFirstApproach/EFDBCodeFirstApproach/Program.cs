using EFDBCodeFirstApproach.DTO;
using EFDBCodeFirstApproach.Models;
using EFDBCodeFirstApproach.Services;

namespace EFDBCodeFirstApproach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StudentDbContext context = new StudentDbContext();
            SchoolDAL dal = new SchoolDAL();
            Grade g = new Grade();
            //int result = dal.AddGrades();
            //Console.WriteLine($"{result} rows inserted.");
            //Console.WriteLine("Enter new record:");
            //Console.WriteLine("Enter grade name: ");
            //g.GradeName = Console.ReadLine();
            //Console.WriteLine("Enter section name: ");
            //g.Section = Console.ReadLine();
            //dal.AddGrade(g);

            ////update grade
            //Grade g1 = new Grade();
            //int gradeId = dal.GetGradeId(g1);

            //g1.GradeId = gradeId;
            //int result = dal.UpdateGrade(gradeId, g1);
            //Console.WriteLine($"{result} records affected");

            //int rowsAff = dal.AddStudents();
            //Console.WriteLine(rowsAff + " records updated for students");

            //GetGradeById
            //getstudentbyid from schooldal.cs, getstudentsbyid from dto
            Console.WriteLine("Enter student id");
            int id = Convert.ToInt32(Console.ReadLine());

            //Student std = dal.GetStudentbyId(id);
            Dto dtoobj = new Dto();
            StdWithGradeDTO std = dtoobj.GetStudentsById(id);
            if(std != null)
            {
                Console.WriteLine("Student details:\n");
                Console.WriteLine($"{ std.StudentId}");
                Console.WriteLine($"{std.StudentName}");
                //Console.WriteLine($"{std.Grade.GradeName}");
                //Console.WriteLine($"{std.Grade.Section}");
                Console.WriteLine($"{std.GradeName}");
                Console.WriteLine($"{std.Section}");
            }
        }
    }
}
