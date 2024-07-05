//1438. Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit

/*Given an array of integers nums and an integer limit, return the size 
of the longest non-empty subarray such that the absolute difference 
between any two elements of this subarray is less than or equal to limit.
*/

namespace LeetCodeDaily
{
    public class ContigSubArrayWithDiffLessThanLimit
    {
        public static int LongestSubarray(int[] nums, int limit)
        {
            int left = 0;
            int right = 0;

            int min = nums[left];
            int max = 0;
            int arr_size = 1;
            while (right < nums.Length)
            {
                min = Math.Min(min, nums[right]);
                max = Math.Max(max, nums[right]);
                if (Math.Abs(max - min) <= limit)
                {
                    arr_size = Math.Max(arr_size, right - left + 1);
                    right++;
                }
                else
                {
                    left++;
                    if (nums[left - 1] == min)
                    {
                        min = newMin(left, right, nums);
                    }
                    if (nums[left - 1] == max)
                    {
                        max = newMax(left, right, nums);
                    }
                }
            }

            return arr_size;
        }
        private static int newMin(int l, int r, int[] nums)
        {
            int min = nums[l];
            for (int i = l; i <= r; i++)
            {
                min = Math.Min(min, nums[i]);
            }
            return min;
        }
        private static int newMax(int l, int r, int[] nums)
        {
            int max = nums[l];
            for (int i = l; i <= r; i++)
            {
                max = Math.Min(max, nums[i]);
            }
            return max;
        }
    }
}