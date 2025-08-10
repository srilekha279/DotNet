using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class FunctionParameters
    {
        public static void OutParam()
        {
            int sum, diff;
            sum = SumAndDiff(40, 20, out diff);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Diff: " + diff);
        }
        public static int SumAndDiff(int num1, int num2, out int diff)
        {
            diff = num1 - num2;
            return num1 + num2;
        }
    }
}
