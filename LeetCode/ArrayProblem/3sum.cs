using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class _3Sum
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> rtnList = new List<IList<int>>();
            Dictionary<string, int> newD = new Dictionary<string, int>();

            if (nums.Length <= 2) return rtnList;
            List<string> current = new List<string>();
            Array.Sort(nums);
            int i = 0;
            int j = i + 1;
            int k = nums.Length - 1;
            while (i < j)
            {
                j = i + 1;
                while (j < k)
                {
                    if (nums[i] + nums[j] + nums[k] > 0 )
                    {
                        k--;
                        continue;
                    }
                    else if (nums[i] + nums[j] + nums[k] < 0 )
                    {
                        j++;
                        continue;
                    }

                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        IList<int> inner = new List<int>();
                        inner.Add(nums[i]);
                        inner.Add(nums[j]);
                        inner.Add(nums[k]);
                        while (j < k && nums[j] == nums[j + 1]) j++;
                        while (j < k && nums[k] == nums[k - 1]) k--;
                        j++;
                    }
                }
                i++;
            }

            return rtnList;
        }
    }
}
