namespace Algorithms.SlidingWindow
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int Solve(string s)
        {
            int L = 0;
            int R = 0;
            int maxString = 0;
            HashSet<char> chars = new();

            while (R < s.Length)
            {
                while (chars.Contains(s[R]))
                {
                    chars.Remove(s[L]);
                    L++;
                }

                chars.Add(s[R]);

                if ((R - L + 1) > maxString)
                    maxString = R - L + 1;

                R++;
            }

            return maxString;
        }
    }
}
