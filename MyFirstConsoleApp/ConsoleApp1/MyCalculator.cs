using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MyCalculator
    {
        public int number1, number2;
        public MyCalculator() { }
        public MyCalculator(int num1, int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static MyCalculator operator +(MyCalculator Calc1, MyCalculator Calc2)
        {
            MyCalculator Calc3 = new MyCalculator();
            Calc3.number1 = Calc1.number1 + Calc2.number1;
            Calc3.number2 = Calc1.number2 + Calc2.number2;
            return Calc3;
        }
        //~operator
        public static MyCalculator operator ~(MyCalculator Calc)
        {
            Calc.number1 = ~Calc.number1;
            Calc.number2 = ~Calc.number2;
            return Calc;
        }
        public void Implement()
        {
            MyCalculator calc1 = new MyCalculator(1, 2);
            MyCalculator calc2 = new MyCalculator(2, 3);
            MyCalculator calc3 = calc1 + calc2;

            Console.WriteLine($"Addition: {calc1.number1} + {calc2.number1} = {calc3.number1}");
            Console.WriteLine($"Addition: {calc1.number2} + {calc2.number2} = {calc3.number2}");

            calc1 = ~calc1;
            Console.WriteLine(calc1.number1 + " " + calc1.number2);
        }
    }
}
