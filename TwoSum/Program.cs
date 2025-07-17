// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> ints = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (ints.ContainsKey(complement))
            {
                Console.WriteLine($"Indices: [{ints[complement]}, {i}]");
                return new int[] { ints[complement], i };
            }

            if (!ints.ContainsKey(nums[i]))
            {
                ints[nums[i]] = i;
            }
        }
        return new int[] { };
    }
    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
       
        
        TwoSum(nums,target) ; // Output: Indices: [0, 1]
    }
}
