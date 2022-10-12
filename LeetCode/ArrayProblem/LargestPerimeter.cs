/**
 * 
 * 976. Largest Perimeter Triangle
Easy

2136

293

Add to List

Share
Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

 

Example 1:

Input: nums = [2,1,2]
Output: 5
Example 2:

Input: nums = [1,2,1]
Output: 0
 

Constraints:

3 <= nums.length <= 104
1 <= nums[i] <= 106
Accepted
153,952
Submissions
282,704
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class LargestPerimeter
    {
        public static int exec(int[] nums)
        {
            List<int> n = nums.ToList();
            n = n.OrderByDescending(num=>num).ToList();
            int len = n[0];
            int wid = n[1];
            int i = 2;
            while(i < n.Count)
            {
                if(n[i] + wid > len)
                {
                    return n[i] + wid + len;
                }
                i++;
            }
            
            return 0;
        }
    }
}
