namespace Algorithms.ArraysAndHashing
{
    public class GroupAnagrams
    {
        public static IList<IList<string>> Solve(string[] strs)
        {
            Dictionary<string, List<string>> groups = new();

            foreach (var word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);


                if (!groups.ContainsKey(key))
                {
                    groups.Add(key, new List<string> { word });
                }
                else
                {
                    groups[key].Add(word);
                }
            }

            return groups.Values.Select(val => (IList<string>)val).ToList();
        }
    }
}
