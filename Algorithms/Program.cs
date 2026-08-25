using Algorithms.ArraysAndHashing;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 3 };
            int [] indexies = TwoSum.Solve(nums, 6);

            foreach (var item in indexies)
            {
                Console.WriteLine(item);
            }
        }
    }
}
