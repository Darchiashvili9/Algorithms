namespace Algorithms.TwoPointers
{
    public class TwoSumII
    {
        public static int[] Solve(int[] numbers, int target)
        {
            int i = 0;
            int j = numbers.Length - 1;
            int sum;

            while (i < j)
            {
                sum = numbers[i] + numbers[j];

                if (sum > target)
                    j--;
                else if (sum < target)
                    i++;
                else break; //we found
            }
            return new int[] { ++i, ++j };
        }
    }
}
