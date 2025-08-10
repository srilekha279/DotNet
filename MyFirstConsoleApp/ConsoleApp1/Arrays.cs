using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Arrays
    {
        // array should have size while declaring
        public void DisplayArray()
        {
            int[] arr1 = new int[10];
            arr1[2] = 2; arr1[3] = 3;
            int[] arr2 = new int[3] { 1, 2, 3 };
            string[] arr3 = ["a", "b", "c"];
            // arr1[12] = 2; //raised exception out of range
            for (int i = 0; i < arr1.Length; i++)
                Console.Write(arr1[i] + " ");
            Console.WriteLine();
            foreach(string i in arr3)
                Console.Write(i + " ");
                
        }

        public void OneDArray()
        {
            int[] numbers;
            int n;
            Console.Write("Enter the size of array");
            n = Convert.ToInt32(Console.ReadLine());
            numbers = new int[n];
            Console.WriteLine("Enter the numbers into array:\n");
            TakeInput(numbers, n);
            MinMaxOfArray(numbers);

        }
        public void TakeInput(int[] numbers, int n)
        {
            for (int i = 0; i < n; i++)
                numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        public void MinMaxOfArray(int[] numbers)
        {
            int maxi = int.MinValue, mini = int.MaxValue;
            foreach(int i in numbers)
            {
                if (i > maxi)
                    maxi = i;
                if(i < mini)
                    mini = i;
            }
            Console.WriteLine($"Maximum value: {maxi}");
            Console.WriteLine($"Minimum value: {mini}");
        }

        public void AddMatrices()
        {
            int n;
            Console.WriteLine("Enter size: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matA = new int[n, n];
            int[,] matB = new int[n, n];
            int[,] matC = new int[n, n];
            Console.WriteLine("Enter the elements of first matrix\n");
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write($"\nEnter matA[{i}, {j}]: ");
                    matA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of second matrix\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\nEnter matB[{i}, {j}]: ");
                    matB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matC[i, j] = matA[i, j] + matB[i, j];
                }
            }
            Console.WriteLine("Result matrix: \n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(matC[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void JaggedArray()
        {
            int[][] arr = new int[2][];
            arr[0] = [20, 31, 32, 12];
            arr[1] = [11, 10];
            int[][] arr1 = { new int[] { 1, 2 }, new int[] { 21, 292, 12 } };
            for(int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0; j < arr1[i].Length; j++)
                    Console.Write(arr1[i][j] + " ");
                Console.WriteLine() ;
            }
        }

    }
}
