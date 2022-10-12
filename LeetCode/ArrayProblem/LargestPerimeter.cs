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
            n = n.OrderByDescending(num => num).ToList();
            int fst = 0;
            int sec = 0;
            int thr = 0;
            for (int i = 0; i < n.Count; i++)
            {
                if (sec + thr > fst)
                {
                    return sec + thr + fst;
                }
                else if (fst != 0 && sec != 0 && thr != 0)
                {
                    fst = sec;
                    sec = thr;
                    thr = 0;
                }

                if (n[i] > fst)
                {
                    fst = n[i];
                }
                else if (n[i] > sec)
                {
                    sec = n[i];
                }
                else if (n[i] > thr)
                {
                    thr = n[i];
                }
            }



            return thr + sec > fst ? fst + sec + thr : 0;
        }
    }
}
