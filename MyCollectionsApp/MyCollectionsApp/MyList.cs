using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class MyList
    {
        public void ListFunctions()
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Capacity: {nums.Capacity} and Count: {nums.Count}");

            List<int> nums1 = new() { 10, 20, 30, 2 };
            nums.AddRange(nums1);
            Console.WriteLine($"After AddRange: \nCapacity: {nums.Capacity} and Count: {nums.Count}");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            

            //contains
            if (nums.Contains(1))
            {
                Console.WriteLine("The given number exists");
                int found_num = nums[nums.IndexOf(1)];
                nums.Add(found_num);
            }
            else
            {
                Console.WriteLine("The given number does not exist");
            }
            //insert 32 immediately after 2 in nums list
            nums.Insert(nums.IndexOf(2) + 1, 32);
            foreach(int i in nums)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine() ;
            List<int> nums2 = new() { 11, 12, 13 };
            nums.InsertRange(nums.Count, nums2);
            Console.WriteLine("\nAfter InsertRange");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("First occurence of 2 " + nums.IndexOf(2));
            Console.WriteLine("Last occurence of 2 " + nums.LastIndexOf(2));


        }

    }
}
