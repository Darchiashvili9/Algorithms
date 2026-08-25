namespace Algorithms.SlidingWindow
{
    public class Program
    {
        public static int Solve(int[] prices)
        {
            int buy = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                buy = Math.Min(buy, prices[i]);
                profit = Math.Max(profit, prices[i] - buy);
            }

            return profit;
        }
    }
}
