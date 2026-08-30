namespace Algorithms.TwoPointers
{
    public class ValidPalindrome
    {
        public static bool Solve(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            char fromLeft;
            char fromRight;

            while (i < j)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }

                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                fromLeft = char.ToLower(s[i]);
                fromRight = char.ToLower(s[j]);

                if (fromLeft != fromRight)
                    return false;
                else
                {
                    i++;
                    j--;
                } 
            }
            return true;
        }
    }
}
