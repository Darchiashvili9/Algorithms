namespace Algorithms.ArraysAndHashing
{
    public class ValidAnagram
    {
        public static bool Solve(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> check = new();

            foreach (var item in s)
            {
                if (check.ContainsKey(item))
                {
                    check[item]++;
                }
                else check.Add(item, 1);
            }

            foreach (var item in t)
            {
                if (check.ContainsKey(item))
                {
                    check[item]--;
                    if (check[item] == 0)
                    {
                        check.Remove(item);
                    }
                }
                else return false;
            }

            return check.Count == 0;
        }
    }
}
