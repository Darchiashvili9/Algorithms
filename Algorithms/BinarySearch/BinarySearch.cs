namespace Algorithms.BinarySearch
{
    public class BinarySearch
    {
        public static int Solve(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                if (target < nums[mid])
                {
                    right = mid - 1;
                    mid = left + (right - left) / 2;
                }

                if (target > nums[mid])
                {
                    left = mid + 1;
                    mid = left + (right - left) / 2;
                }
            }

            return -1;
        }
    }
}
