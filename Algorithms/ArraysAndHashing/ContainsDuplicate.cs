namespace Algorithms.ArraysAndHashing
{
    public class ContainsDuplicate
    {
        public static bool Solve(int[] nums)
        {
            HashSet<int> seen = new();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!seen.Contains(nums[i]))
                    seen.Add(nums[i]);
                else return true;
            }
            return false;
        }
    }
}
