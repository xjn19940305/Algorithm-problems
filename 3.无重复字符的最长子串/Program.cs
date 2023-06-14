// See https://aka.ms/new-console-template for more information
/*
 * 
给定一个字符串 s ，请你找出其中不含有重复字符的 最长子串 的长度。

 

示例 1:

输入: s = "abcabcbb"
输出: 3 
解释: 因为无重复字符的最长子串是 "abc"，所以其长度为 3。
示例 2:

输入: s = "bbbbb"
输出: 1
解释: 因为无重复字符的最长子串是 "b"，所以其长度为 1。
示例 3:

输入: s = "pwwkew"
输出: 3
解释: 因为无重复字符的最长子串是 "wke"，所以其长度为 3。
     请注意，你的答案必须是 子串 的长度，"pwke" 是一个子序列，不是子串。
 
*/
var s = "abcabcbb";
var result = new Solution();
Console.WriteLine(result.LengthOfLongestSubstring(s));
Console.ReadKey();
public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        HashSet<char> set = new HashSet<char>();
        int i = 0, j = 0;

        while (i < n && j < n)
        {
            if (!set.Contains(s[j]))
            {
                set.Add(s[j]);
                maxLength = Math.Max(maxLength, j - i + 1);
                j++;
            }
            else
            {
                set.Remove(s[i]);
                i++;
            }
            //Console.WriteLine($"i:{i} j:{j} str:{string.Join("", set)}");
        }

        return maxLength;
    }
}