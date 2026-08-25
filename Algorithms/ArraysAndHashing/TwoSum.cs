namespace Algorithms.ArraysAndHashing
{
    public class TwoSum
    {
        public static int[] Solve(int[] nums, int target)
        {
            Dictionary<int, int> seen = new();

            for (int i = 0; i < nums.Length; i++)
            {
                int num = target - nums[i];

                if (!seen.ContainsKey(num))
                {
                    if (seen.ContainsKey(nums[i]))
                        continue;

                    seen.Add(nums[i], i);
                }
                else
                {
                    return new int[] { seen[num], i };
                }
            }

            throw new InvalidOperationException("No solution found.");
        }
    }
}
