namespace Algorithms.BinarySearch
{
    public class SearchInsertPosition
    {
        public static int Solve(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (target > nums[mid])
                    left = mid + 1;

                if (target < nums[mid])
                    right = mid - 1;

                if (target == nums[mid])
                    return mid;
            }

            return left;
        }
    }
}
