/**
 * 990. Satisfiability of Equality Equations
Medium

3089

48

Add to List

Share
You are given an array of strings equations that represent relationships between variables where each string equations[i] is of length 4 and takes one of two different forms: "xi==yi" or "xi!=yi".Here, xi and yi are lowercase letters (not necessarily different) that represent one-letter variable names.

Return true if it is possible to assign integers to variable names so as to satisfy all the given equations, or false otherwise.

 

Example 1:

Input: equations = ["a==b","b!=a"]
Output: false
Explanation: If we assign say, a = 1 and b = 1, then the first equation is satisfied, but not the second.
There is no way to assign the variables to satisfy both equations.
Example 2:

Input: equations = ["b==a","a==b"]
Output: true
Explanation: We could assign a = 1 and b = 1 to satisfy both equations.
 

Constraints:

1 <= equations.length <= 500
equations[i].length == 4
equations[i][0] is a lowercase letter.
equations[i][1] is either '=' or '!'.
equations[i][2] is '='.
equations[i][3] is a lowercase letter.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class SatisfiabilityofEqualityEquations
    {
        public static Boolean exec(string[] equations)
        {
            List<string> el = equations.ToList();
            Hashtable ht = new Hashtable();

            for (int i = 0; i < el.Count; i++)
            {
                string[] tmpE = null;
                if (el[i].Contains("=="))
                {
                    tmpE = el[i].Split("==");

                    if (ht.ContainsKey(tmpE[0]))
                    {
                        List<string> tmpList = (List<string>)ht[tmpE[0]];
                        tmpList.Add(tmpE[1]);
                        ht[tmpE[0]] = tmpList;
                    }
                    else
                    {
                        ht.Add(tmpE[0], new List<string> { tmpE[0],tmpE[1] });
                    }

                    if (ht.ContainsKey(tmpE[1]))
                    {
                        List<string> tmpList = (List<string>)ht[tmpE[1]];
                        tmpList.Add(tmpE[0]);
                        ht[tmpE[1]] = tmpList;
                    }
                    else
                    {
                        ht.Add(tmpE[1], new List<string> { tmpE[1],tmpE[0] });
                    }

                    el.RemoveAt(i);
                }
            }

            for (int i = 0; i < el.Count; i++)
            {
                if (el[i].Contains("!="))
                {
                    List<string> chkList = el[i].Split("!=").ToList<string>();
                    foreach (DictionaryEntry l in ht)
                    {
                        if (ContainsAllItems((List<string>)l.Value, chkList))
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static bool ContainsAllItems<T>(List<T> a, List<T> b)
        {
            return !b.Except(a).Any();
        }
    }
}
