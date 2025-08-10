using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class JaggedArrays
    {
        public void JaggedWithMultiDim()
        {
            int[][,] arr1;
            Console.Write("Enter the size of array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            arr1 = new int[n][,];
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Enter the size of {i} inner array rows");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the size of {i} inner array cols");
                n = Convert.ToInt32(Console.ReadLine());

                arr1[i] = new int[m, n];
                Console.WriteLine("Enter the elements for {0} array:\n", i);
                for(int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter {n} elements for {j} row: ");
                    for(int k = 0; k < n; k++)
                    {
                        arr1[i][j, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
            }
            //Display
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Elements of {i} array:");
                for(int j = 0; j < arr1[i].GetLength(0); j++)
                {
                    Console.WriteLine($"Elements for {j} row");
                    for(int k = 0; k < arr1[i].GetLength(1); k++)
                    {
                        Console.Write(arr1[i][j, k] + " ");
                    }
                    Console.WriteLine() ;
                }
                Console.WriteLine();
            }
        }
    }
}
