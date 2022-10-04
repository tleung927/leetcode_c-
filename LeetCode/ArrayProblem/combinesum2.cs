using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace LeetCode.ArrayProblem
{
    class CombinationSum2
    {
        public static IList<IList<int>> exec(int[] candidates, int target)
        {
            IList<IList<int>> rtnList = new List<IList<int>>();
            Array.Sort(candidates);
            help(candidates, target, 0, new List<int>(), rtnList);
            return rtnList;
        }

        private static void help(int[] candidates, int target, int start, IList<int> oneResult, IList<IList<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(oneResult));
            }
            else if (target > 0)
            {
                for (int i = start; i < candidates.Length; i++)
                {                    
                    if (i > start && candidates[i - 1] == candidates[i]) continue;
                    oneResult.Add(candidates[i]);
                    help(candidates, target - candidates[i], i + 1, oneResult, result);
                    oneResult.RemoveAt(oneResult.Count - 1);
                }
            }

        }
    }
}
