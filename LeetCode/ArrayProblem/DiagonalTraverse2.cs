/**
 * Given a 2D integer array nums, return all elements of nums in diagonal order as shown in the below images.

 

Example 1:


Input: nums = [[1,2,3],[4,5,6],[7,8,9]]
Output: [1,4,2,7,5,3,8,6,9]
Example 2:


Input: nums = [[1,2,3,4,5],[6,7],[8],[9,10,11],[12,13,14,15,16]]
Output: [1,6,2,8,7,3,9,4,12,10,5,13,11,14,15,16]
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class DiagonalTraverse2
    {
        public static int[] exec(IList<IList<int>> nums)
        {
            #region work_but_timeout
            // work but time out!!!!
            //List<int> rtn = new List<int>();
            //int max = nums.Count;

            //for (int i = 0; i < nums.Count; i++)
            //{
            //    max = Math.Max(max, nums[i].Count);
            //}

            //// left side
            //for (int i = 0; i < max; i++)
            //{
            //    int row = i;
            //    int column = 0;
            //    while (row >= 0 )
            //    {
            //        if (nums[row].Count <= column)
            //        {
            //            row--;
            //            column++;
            //            continue;
            //        }
            //        try
            //        {
            //            rtn.Add(nums[row][column]);
            //        }
            //        catch
            //        {

            //        }
            //        row--;
            //        column++;
            //    }
            //}

            //// rigth side
            //for (int i = 1; i < max; i++)
            //{
            //    int row = max - 1;
            //    int column = i;
            //    while (column <= max - 1 && row >= 0)
            //    {
            //        if (nums[row].Count <= column)
            //        {
            //            row--;
            //            column++;
            //            continue;
            //        }
            //        try
            //        {
            //            rtn.Add(nums[row][column]);
            //        }
            //        catch
            //        {

            //        }
            //        row--;
            //        column++;
            //    }
            //}

            //return rtn.ToArray();
            #endregion

            var pq = new SortedSet<(int Weight, int Row, int Value)>();

            for (int row = nums.Count - 1; row >= 0; row--)
            {
                for (int index = 0; index < nums[row].Count; index++)
                {
                    pq.Add((row + index, nums.Count - row, nums[row][index]));
                }
            }

            return pq.Select(x => x.Value).ToArray();
        }
    }
}
