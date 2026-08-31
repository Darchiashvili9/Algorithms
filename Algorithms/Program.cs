using Algorithms.ArraysAndHashing;
using Algorithms.TwoPointers;

namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TwoSum
            /*
            int[] nums = { 1, 1, 2, 3 };
            int [] indexies = TwoSum.Solve(nums, 6);

            foreach (var item in indexies)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region GroupAnagrams
            /*
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };

            var result = GroupAnagrams.Solve(strs);

            foreach (var group in result)
            {
                Console.WriteLine(string.Join(", ", group));
            }
            */
            #endregion

            #region ValidPalindrome
            /*
            string s = "A man, a plan, a canal: Panama";
            var result = ValidPalindrome.Solve(s);
            Console.WriteLine(result);
            */
            #endregion

            #region Two Sum II — Input Array Is Sorted
            /*
            int[] numbers = [2, 7, 11, 15];
            int[] result = TwoSumII.Solve(numbers, 9);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */
            #endregion


        }
    }
}
