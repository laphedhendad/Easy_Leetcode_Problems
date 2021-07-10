/*
 * Given an integer array nums sorted in non-decreasing order, 
 * remove the duplicates in-place such that each unique element appears only once.
 * The relative order of the elements should be kept the same.
 * -100 <= nums[i] <= 100
 */
using System;

namespace Easy_Leetcode_Problems
{
    class RemoveDuplicatesfromSortedArray
    {
        static public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int k = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k])
                {
                    i++;
                    nums[k] = nums[i];
                }
            }
            return k + 1;
        }
        static void Main(string[] args)
        {
            int[] nums = new int[3] { 1, 1, 2 };
            Console.WriteLine(RemoveDuplicates(nums));
            foreach(int item in nums)
            {
                Console.Write(item + ",");
            }
        }
    }
}
