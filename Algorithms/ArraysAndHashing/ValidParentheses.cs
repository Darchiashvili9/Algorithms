namespace Algorithms.ArraysAndHashing
{
    public class ValidParentheses
    {
        public static bool Solve(string s)
        {
            Stack<char> list = new();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '}':
                    case ']':
                    case ')':
                        if (list.Count < 1)
                            return false;

                        if (list.Peek() == '{' && s[i] != '}' || list.Peek() == '[' && s[i] != ']' || list.Peek() == '(' && s[i] != ')')
                            return false;

                        else list.Pop();
                        break;

                    default:
                        list.Push(s[i]);
                        break;
                }
            }
            return list.Count == 0;
        }
    }
}
