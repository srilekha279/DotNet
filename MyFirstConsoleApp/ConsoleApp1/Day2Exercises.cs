using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Day2Exercises
    {
        public void Ternary()
        {
            int x = 9, y = 18;
            string result = x > y ? "x is greater" : "y is greater";
            int z = x > y ? x : y;
            Console.WriteLine("{0} is the greatest", z);
            //string interpolation
            Console.WriteLine($"{z} is greatest number");
        }

        //initialize 3 integer variables, check which is greater and display using ternary operator
        public void Greatest()
        {
            int first = 112, second = 100, third = 872;
            int greatest = first > second ? (first > third ? first : third) : second;
            Console.WriteLine($"{greatest} is greatest among three");
        }

        public void GreatestSmallest3UsingIf()
        {
            int first, second, third;
            Console.WriteLine("Enter 3 integers:");
            first = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            third = Convert.ToInt32(Console.ReadLine());
            if(first > second)
            {
                if(first > third)
                    Console.WriteLine($"{first} is largest");
                else
                    Console.WriteLine($"{third} is largest");
                if(second < third)
                    Console.WriteLine($"{second} is smallest");
                else
                    Console.WriteLine($"{third} is smallest");
            }
            else
            {
                if(second > third)
                    Console.WriteLine($"{second} is largest");
                else
                    Console.WriteLine($"{third} is largest");
                if(first < third)
                    Console.WriteLine($"{first} is smallest");
                else
                    Console.WriteLine($"{third} is smallest");
            }
            
        }

        
        public void GetPrimes()
        {
            int n, cnt = 0;
            Console.WriteLine("How many prime numbers do you want to print: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 2; ; i++)
            {
                if (isPrime(i))
                {
                    cnt++;
                    Console.WriteLine($"Prime {cnt} : {i}");
                }                
                if (cnt == n)
                    break;
            }
        }

        public bool isPrime(int n)
        {
            for(int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        public void ExecuteOptions()
        {
            int choice;
            do
            {
                Console.WriteLine("1.Execute Ternary");
                Console.WriteLine("2.Execute Greatest");
                Console.WriteLine("3.Execute GetPrimes");
                Console.WriteLine("4.Exit");
                Console.Write("\nEnter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Ternary();
                        break;
                    case 2:
                        Greatest();
                        break;
                    case 3:
                        GetPrimes();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.WriteLine("Press any key to continue..");
                Console.ReadKey(); //To pause after output
                Console.Clear();
            } while(choice != 4);            
        }

        //Display odd digits of a number
        public void OddDigits()
        {
            Console.WriteLine("Enter an integer");
            int n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                int rem = n % 10;
                if (rem % 2 != 0)
                    Console.WriteLine(rem);
                n /= 10;
            }
        }

        
    }
}
