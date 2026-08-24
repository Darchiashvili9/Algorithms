namespace Best_Time_to_Buy_and_Sell_Stock
{
    internal class Program
    {
        public static int MaxProfit(int[] prices)
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
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
        }
    }
}
