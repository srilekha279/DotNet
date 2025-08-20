using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.OopsExercises
{
    public class Car
    {
        public string Make, Model;
        public int Year;
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Car Details:");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
        public void DisplayAge()
        {
            int year = DateTime.Now.Year;
            Console.WriteLine("Car Age: " + (year - Year) + " years");
        }
    }
}
