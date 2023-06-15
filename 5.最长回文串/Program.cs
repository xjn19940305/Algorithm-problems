/*
 * 给你一个字符串 s，找到 s 中最长的回文子串。

如果字符串的反序与原始字符串相同，则该字符串称为回文字符串。

 

示例 1：

输入：s = "babad"
输出："bab"
解释："aba" 同样是符合题意的答案。
示例 2：

输入：s = "cbbd"
输出："bb"
 

提示：

1 <= s.length <= 1000
s 仅由数字和英文字母组成
*/

new Solution().LongestPalindrome("ab");

Console.ReadKey();
public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
            return string.Empty;
        //最长回文子串开始位置
        int start = 0;
        //最长回文子串结束位置
        int end = 0;

        for (var i = 0; i < s.Length; i++)
        {
            //奇数长度的回文子串
            var len1 = ExpandAroundCenter(s, i, i);
            //偶数长度回文子串
            var len2 = ExpandAroundCenter(s, i, i + 1);
            //取奇偶中最长的长度
            int len = Math.Max(len1, len2);

            // 如果当前回文子串的长度大于已记录的最长回文子串的长度，则更新最长回文子串的起始和结束索引
            if (len > end - start)

            {
                start = i - (len - 1) / 2;
                end = i + len / 2;
            }
        }
        return s.Substring(start, end - start + 1); 
    }

    private int ExpandAroundCenter(string s, int left, int right)
    {
        while (left >= 0 && right < s.Length && s[left] == s[right])
        {
            left--;
            right++;
        }
        //返回当前回文子串的长度
        return right - left - 1;
    }
}