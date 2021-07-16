/*
 * Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
 */

namespace MaxSubArray
{
    class Solution
    {
        public int MaxSubArray(int[] nums)
        {

            int maxSub = nums[0];
            int curSum = 0;

            foreach (int n in nums)
            {
                if (curSum < 0) curSum = 0;
                curSum += n;
                if (maxSub < curSum) maxSub = curSum;
            }

            return maxSub;

        }
    }
}
