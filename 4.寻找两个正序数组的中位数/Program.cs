﻿/*
给定两个大小分别为 m 和 n 的正序（从小到大）数组 nums1 和 nums2。请你找出并返回这两个正序数组的 中位数 。

算法的时间复杂度应该为 O(log (m+n)) 。

 

示例 1：

输入：nums1 = [1,3], nums2 = [2]
输出：2.00000
解释：合并数组 = [1,2,3] ，中位数 2
示例 2：

输入：nums1 = [1,2], nums2 = [3,4]
输出：2.50000
解释：合并数组 = [1,2,3,4] ，中位数 (2 + 3) / 2 = 2.5
 

 

提示：

nums1.length == m
nums2.length == n
0 <= m <= 1000
0 <= n <= 1000
1 <= m + n <= 2000
-106 <= nums1[i], nums2[i] <= 106*/
//var nums1 = new int[] { 1, 1 };
//var nums2 = new int[] { 1, 2 };
int[] nums1 = Enumerable.Range(0, 5)
                             .Select(_ => new Random().Next(0, 20))
                             .ToArray();
int[] nums2 = Enumerable.Range(0, 5)
                             .Select(_ => new Random().Next(0, 20))
                             .ToArray();
new Solution().FindMedianSortedArrays(nums1, nums2);

Console.ReadKey();

public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int m = nums1.Length;
        int n = nums2.Length;
        int[] merged = new int[m + n];

        int i = 0;  // 数组 nums1 的指针
        int j = 0;  // 数组 nums2 的指针
        int k = 0;  // 合并数组的指针

        while (i < m && j < n)
        {
            if (nums1[i] < nums2[j])
            {
                merged[k] = nums1[i];
                i++;
            }
            else
            {
                merged[k] = nums2[j];
                j++;
            }
            k++;
        }

        // 将剩余的数组元素添加到合并数组中
        while (i < m)
        {
            merged[k] = nums1[i];
            i++;
            k++;
        }        
        while (j < n)
        {
            merged[k] = nums2[j];
            j++;
            k++;
        }
        // 根据合并数组的长度计算中位数
        int mid = merged.Length / 2;
        if (merged.Length % 2 == 0)  // 数组长度为偶数
        {
            return (double)(merged[mid - 1] + merged[mid]) / 2;
        }
        else  // 数组长度为奇数
        {
            return merged[mid];
        }

    }
}