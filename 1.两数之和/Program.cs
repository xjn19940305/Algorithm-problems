/*给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  的那 两个 整数，并返回它们的数组下标。

你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。

你可以按任意顺序返回答案。
示例 1：

输入：nums = [2,7,11,15], target = 9
输出：[0,1]
解释：因为 nums[0] + nums[1] == 9 ，返回 [0, 1] 。
示例 2：

输入：nums = [3,2,4], target = 6
输出：[1,2]
示例 3：

输入：nums = [3,3], target = 6
输出：[0,1]
*/

var nums = new int[] { 2, 3, 4, 5 };
var s = new Solution();
Console.WriteLine("[" + string.Join(",", s.TwoSum(nums, 8)) + "]");

Console.ReadKey();
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //for (var i = 0; i < nums.Length - 1; i++)
        //{
        //    for (var j = i + 1; j < nums.Length; j++)
        //    {
        //        if (nums[i] + nums[j] == target)
        //            return new int[] { i, j };
        //    }
        //}
        var dic = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var imp = target - nums[i];
            if (dic.ContainsKey(imp) && dic[imp] != i)
            {
                return new int[] { i, dic[imp] };
            }
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }
        }
        return new int[] { };
    }
}