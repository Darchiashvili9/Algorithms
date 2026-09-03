namespace Algorithms.ArraysAndHashing
{
    public class LongestConsecutiveSequence
    {
        public static int Solve(int[] nums)
        {
            int sequence = 0;
            HashSet<int> h = new();
            foreach (var item in nums)
            {
                h.Add(item);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!h.Contains(nums[i] - 1))
                {
                    var seq = 0;
                    while (h.Contains(nums[i] + seq))
                    {
                        seq++;
                    }
                    if (seq > sequence)
                        sequence = seq;
                }
            }

            return sequence;
        }
    }
}
