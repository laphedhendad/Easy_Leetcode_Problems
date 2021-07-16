/*
 * Given a sorted array of distinct integers and a target value, return the index if the target is found. 
 * If not, return the index where it would be if it were inserted in order.
 */
namespace SearchInsert
{
    class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            return SearchInsert(nums, target, 0, nums.Length - 1);
        }

        private int SearchInsert(int[] nums, int target, int left, int right)
        {
            if (left > right) return left;
            int middle = left + (right - left) / 2;
            if (nums[middle] == target) return middle;
            else if (nums[middle] > target) return SearchInsert(nums, target, left, right - 1);
            else if (nums[middle] < target) return SearchInsert(nums, target, left + 1, right);
            else return middle;
        }
    }
}
