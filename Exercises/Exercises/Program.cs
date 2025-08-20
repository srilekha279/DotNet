using Exercises.OopsExercises;

namespace Exercises
{
    internal class Program
    {
        public static void Test()
        {
            int choice = 0;
            Console.WriteLine("Enter your string: ");
            string input = Console.ReadLine();
            StringConverter sc = new StringConverter();
            do
            {
                Console.WriteLine("Press Enter to continue..");
                Console.ReadKey();
                Console.WriteLine("\nEnter your choice:");
                Console.WriteLine("1.Uppercase \n2.Lowercase \n3.Title Case \n4.Quit");
                int.TryParse(Console.ReadLine(), out choice);
                
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(sc.ConvertString(input));
                        break;
                    case 2:
                        Console.WriteLine(sc.ConvertString(input, true));
                        break;
                    case 3:
                        Console.WriteLine(sc.ConvertString(input, 1));
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(2000);
                        
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);
        }
        static void Main(string[] args)
        {
            //Person.Test();
            //Student.Test();
            //Console.WriteLine("Enter car details: ");
            //Console.Write("Make: ");
            //string make = Console.ReadLine();
            //Console.Write("Model: ");
            //string model = Console.ReadLine();
            //Console.Write("Year: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Car car = new Car(make, model, year);
            //car.DisplayDetails();
            //car.DisplayAge();
            Test();
            
        }
    }
}
