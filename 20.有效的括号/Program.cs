// See https://aka.ms/new-console-template for more information


new Solution().IsValid("(([]){})");

Console.ReadKey();

public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s)) return false;

        while (s.IndexOf("{}") != -1 || s.IndexOf("()") != -1 || s.IndexOf("[]") != -1)
        {
            s = s.Replace("()", string.Empty).Replace("{}", string.Empty).Replace("[]", string.Empty);
        }
        return s.Length == 0;
    }
}