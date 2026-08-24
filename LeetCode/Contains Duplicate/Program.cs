namespace Contains_Duplicate
{
    internal class Program
    {
        public static bool ContainsDuplicate(int[] nums)
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

        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 1];
            Console.WriteLine(ContainsDuplicate(nums));
        }
    }
}
