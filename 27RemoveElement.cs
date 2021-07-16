/*
 * Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
 * The relative order of the elements may be changed.
 */

namespace RemoveElement
{
    class Solution
    {
        public int Remove_Element(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;

            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
    }
}
