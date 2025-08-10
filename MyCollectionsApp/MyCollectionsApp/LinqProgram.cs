using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyCollectionsApp
{
    internal class LinqProgram
    {
        public static List<Employee> employees = new List<Employee>();
        public static List<LinqProject> projects = new List<LinqProject>();

        public static void InitializeProjects()
        {
            projects.Add(new LinqProject 
            { ProjectId = 100, ProjectName = "ABC" }
            );
            projects.Add(new LinqProject
            { ProjectId = 101, ProjectName = "XYZ" }
            );
        }
        public static void InitializeEmployees()
        {
            
            employees.Add(new Employee
            {
                EmployeeId = 1, EmployeeName = "Tuba", ProjectId = 100
            });
            employees.Add(new Employee
            {
                EmployeeId = 2,
                EmployeeName = "James",
                ProjectId = 100
            });
            employees.Add(new Employee
            {
                EmployeeId = 3,
                EmployeeName = "John",
                ProjectId = 101
            });
            employees.Add(new Employee
            {
                EmployeeId = 4,
                EmployeeName = "Alice"
                //ProjectId = 101
            });
        }
        public static void WorkWithLinq()
        {
            InitializeEmployees();
            InitializeProjects();
            var querySyntax1 = from employee in employees
                               where employee.EmployeeName.StartsWith("J")
                               select employee;
            var querySyntax2 = from employee in employees
                               where employee.EmployeeName.StartsWith("J")
                               select employee.EmployeeName;
            Console.WriteLine("Q count1: " + querySyntax1.Count());
            //foreach (var item in querySyntax1)
            //    Console.WriteLine($"Employee Id: {item.EmployeeId}, Employee Name: {item.EmployeeName}");
            var methodSyntax1 = employees.Where(emp => emp.EmployeeName.StartsWith("J"));
            Console.WriteLine("M count1: " + methodSyntax1.Count());
            //foreach (var item in methodSyntax1)
            //    Console.WriteLine($"Employee Id: {item.EmployeeId}, Employee Name: {item.EmployeeName}");
            //foreach (var item in querySyntax2)
            //    Console.WriteLine(item);

            var querySyntax3 = from employee in employees
                               where employee.EmployeeName.StartsWith("J")
                               orderby employee.EmployeeName
                               select employee.EmployeeName;
            List<Employee> methodSyntax3 = (List<Employee>)employees
                                          .Where(e => e.EmployeeName.StartsWith("J"))
                                          .OrderBy(e => e.EmployeeName)
                                          .ToList();
            //foreach (var item in methodSyntax3)
            //    Console.WriteLine($"Employee Id: {item.EmployeeId}, Employee Name: {item.EmployeeName}");

            var methodSyntax4= employees.OrderByDescending(e => e.EmployeeName);

            var querySyntax5 = from emp in employees
                               orderby emp.ProjectId, emp.EmployeeName descending
                               select emp;
            var methodSyntax5 = employees.OrderBy(e => e.ProjectId).ThenByDescending(e => e.EmployeeName);

            var querySyntax6 = (from emp in employees select emp).Take(2);
            var methodSyntax6 = employees.Take(6);

            var querySyntax7 = (from emp in employees select emp).Skip(2).Take(2);
            var methodSyntax7 = employees.Skip(2);

            var querySyntax8 = from emp in employees group emp by emp.ProjectId;
            var methodSyntax8 = employees.GroupBy(e => e.ProjectId).ToList();
            //foreach(var item in querySyntax8)
            //{
            //    Console.WriteLine(item.Key + " Key: " + item.Count());
            //    foreach (var emp in item.ToList())
            //        Console.WriteLine($"Id {emp.EmployeeId}, name: {emp.EmployeeName}");
            //}

            //Console.WriteLine("Group in methodsyntax");
            //foreach(var item in methodSyntax8)
            //{
            //    Console.WriteLine(item.Key + " Key: " + item.Count());
            //    foreach (var emp in item.ToList())
            //        Console.WriteLine($"Id {emp.EmployeeId}, name: {emp.EmployeeName}");
            //}
            var querySyntax9 = (from emp in employees
                                where emp.EmployeeName.StartsWith("A")
                                select emp).First();
            var methodSyntax9 = employees.Where(e => e.EmployeeName.StartsWith("A")).First();
            

            if (querySyntax9 != null)
                Console.WriteLine(querySyntax9.EmployeeId + " " + querySyntax9.EmployeeName);
            //if (querySyntax9 != null)
            //{
            //    foreach (var item in querySyntax9) //getting error in this line
            //        Console.WriteLine(item.EmployeeId + " " + item.EmployeeName);
            //}

            Console.WriteLine(querySyntax9.GetType());
            var querySyntax10 = (from emp in employees
                                where emp.EmployeeName.StartsWith("A")
                                select emp).FirstOrDefault();

            var querySyntax11 = from emp in employees
                                join project in projects on emp.ProjectId equals project.ProjectId
                                select new { emp.EmployeeName, project.ProjectName };
            //foreach(var item in querySyntax11)
            //    Console.WriteLine(item.EmployeeName + " " + item.ProjectName);
            var methodSyntax11 = employees.Join(projects, e => e.ProjectId, p => p.ProjectId,
                (e, p) => new { e.EmployeeName, p.ProjectName });

            //left join
            var querySyntax12 = from emp in employees
                                join project in projects on emp.ProjectId equals project.ProjectId into group1
                                from project in group1.DefaultIfEmpty()
                                select new { emp.EmployeeName, ProjectName = project ? .ProjectName ?? "NULL"};

            foreach (var item in querySyntax12)
                Console.WriteLine(item.EmployeeName + " " + item.ProjectName);

        }

    }
}
