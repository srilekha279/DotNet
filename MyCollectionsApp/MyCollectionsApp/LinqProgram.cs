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
            //Console.WriteLine("Q count1: " + querySyntax1.Count());
            //foreach (var item in querySyntax1)
            //    Console.WriteLine($"Employee Id: {item.EmployeeId}, Employee Name: {item.EmployeeName}");
            var methodSyntax1 = employees.Where(emp => emp.EmployeeName.StartsWith("J"));
            //Console.WriteLine("M count1: " + methodSyntax1.Count());
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
            

            //if (querySyntax9 != null)
            //    Console.WriteLine(querySyntax9.EmployeeId + " " + querySyntax9.EmployeeName);
            //if (querySyntax9 != null)
            //{
            //    foreach (var item in querySyntax9) //getting error in this line
            //        Console.WriteLine(item.EmployeeId + " " + item.EmployeeName);
            //}

            //Console.WriteLine(querySyntax9.GetType());
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

            //foreach (var item in querySyntax12)
            //    Console.WriteLine(item.EmployeeName + " " + item.ProjectName);


        }

        public void Aggregations()
        {
            IList<Student2> students = new List<Student2>()
            {
                new Student2(){Id = 1, Name = "John", Age = 10},
                new Student2(){Id = 2, Name = "Steve", Age = 20},
                new Student2(){Id = 3, Name = "Alice", Age = 13},
                new Student2(){Id = 4, Name = "Bob", Age = 15},
            };
            var TotalCount = (from s in students select s.Age).Count();
            IList<int> intList = new List<int>() { 1, 23, 11, 22 };
            var skipEvens = intList.SkipWhile(i => { if (i % 2 == 0) return true; return false; });
            var takeEvens = intList.TakeWhile(i => { if (i % 2 == 0) return true; return false; });
            var largest = intList.Max();




            


        }
        public void SelectManyLinq()
        {
            //IList<string> nameList = new List<string>() { "Tina", "Ben", "Smith" };
            //IEnumerable<char> methodSyntax = nameList.SelectMany(x => x); //collection of collections 
            //Console.WriteLine("Flattened collection of strings into collection of chars:");
            //foreach (char c in methodSyntax)
            //    Console.Write(c + " ");
            //Console.WriteLine();
            //IEnumerable<char> querySyntax = from str in nameList from ch in str select ch;
            //List<string> MethodSyntax = LinqStudent.GetStudents().SelectMany(std => std.Programming).ToList();
            //IEnumerable<string> QuerySyntax = from std in LinqStudent.GetStudents()
            //                                  from program in std.Programming
            //                                  select program;
            //Console.WriteLine("Flatten collection of programs of each Student into 1 collection of program:");
            //foreach(string program in MethodSyntax) 
            //    Console.WriteLine(program);

            List<string> lst1 = [ "one", "two", "three", "six", "nine" ];
            List<string> lst2 = ["zero", "one", "three", "four", "five", "six", "eight"];
            List<string> strList = lst1.Except(lst2).ToList();
            Console.WriteLine("List except items in lst2");
            foreach(string s in strList)
                Console.Write(s + " ");
            Console.WriteLine();
            var QS = (from num in lst1 select num).Except(lst2).ToList();
            strList = lst1.Union(lst2).ToList();
            Console.WriteLine("Union of lst1 and lst2");
            foreach (string s in strList)
                Console.Write(s + " ");
            Console.WriteLine();
            strList = lst1.Intersect(lst2).ToList();
            Console.WriteLine("Intersection of lst1 and lst2");
            foreach (string s in strList)
                Console.Write(s + " ");
            Console.WriteLine();
            var lst_distinct = lst1.Distinct();
            Console.WriteLine(lst_distinct.Count());
            foreach (string s in lst_distinct)
                Console.Write(s + " ");
            Console.WriteLine();
        }
        public void MoreLinq()
        {
            List<Student1> AllStudents = new List<Student1>()
            {
                new Student1{Id = 101, Name = "Preeti"},
                new Student1{Id = 102, Name = "Sravanthi"},
                new Student1{Id = 103, Name = "Anurag"},
                new Student1{Id = 104, Name = "Priyanka"},
                new Student1{Id = 105, Name = "Abhi"},
                new Student1{Id = 106, Name = "Viraj"},
            };
            List<Student1> Class6Students = new List<Student1>()
            {
                new Student1{Id = 101, Name = "Preeti"},
                new Student1{Id = 103, Name = "Anurag"},
                new Student1{Id = 106, Name = "Viraj"},
            };
            var MS = AllStudents.Select(x => x.Name).Except(Class6Students.Select(y => y.Name)).ToList();
            var QS = (from std in AllStudents
                      select std.Name).Except(Class6Students.Select(y => y.Name)).ToList();
            foreach(var name in MS)
            {
                Console.WriteLine(name);
            }


        }
    }
    class Student2
    {
        public int Id;
        public string Name;
        public int Age;
    }
}
