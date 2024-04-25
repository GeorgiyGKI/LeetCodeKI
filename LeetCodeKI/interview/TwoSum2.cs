using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeKI.interview
{
    //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    //
    //You may assume that each input would have exactly one solution, and you may not use the same element twice.
    //
    //You can return the answer in any order.
    //
    //Example 1:
    //
    //Input: nums = [2, 7, 11, 15], target = 9
    //Output: [0,1]
    //Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
    //Example 2:
    //
    //Input: nums = [3, 2, 4], target = 6
    //Output: [1,2]
    //Example 3:
    //
    //Input: nums = [3, 3], target = 6
    //Output: [0,1]

    public class TwoSum2
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            //classic not a perfect solution O(n^2)
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i+1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //            return [i, j];
            //    }
            //}
            //
            //return [];

            var numMap = new Dictionary<int, int>();
            var result = new int[2];

            for (var i = 0; i < nums.Length; i++)
            {
                var rightNum = target - nums[i];
                if (!numMap.ContainsKey(rightNum))
                {
                    numMap[nums[i]] = i;
                    rightNum = 0;
                }
                else
                {
                    result[0] = numMap[rightNum];
                    result[1] = i;
                    return result;
                }
            }

            return result;

        }
    }
    }

