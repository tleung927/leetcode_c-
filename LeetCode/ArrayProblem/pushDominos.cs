/**
 * 838. Push Dominoes
Medium

2778

169

Add to List

Share
There are n dominoes in a line, and we place each domino vertically upright. In the beginning, we simultaneously push some of the dominoes either to the left or to the right.

After each second, each domino that is falling to the left pushes the adjacent domino on the left. Similarly, the dominoes falling to the right push their adjacent dominoes standing on the right.

When a vertical domino has dominoes falling on it from both sides, it stays still due to the balance of the forces.

For the purposes of this question, we will consider that a falling domino expends no additional force to a falling or already fallen domino.

You are given a string dominoes representing the initial state where:

dominoes[i] = 'L', if the ith domino has been pushed to the left,
dominoes[i] = 'R', if the ith domino has been pushed to the right, and
dominoes[i] = '.', if the ith domino has not been pushed.
Return a string representing the final state.

 

Example 1:

Input: dominoes = "RR.L"
Output: "RR.L"
Explanation: The first domino expends no additional force on the second domino.
Example 2:


Input: dominoes = ".L.R...LR..L.."
Output: "LL.RR.LLRRLL.."
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class pushDominos
    {
        public static string exec(string dominoes)
        {
            List<string> rtn = new List<string>();
            char[] d = dominoes.ToCharArray();
            List<int> l = new List<int>();
            List<int> r = new List<int>();
            for (int i = d.Length - 1; i >= 0; i--)
            {
                if (d[i] == 'L')
                {
                    l.Add(-1);
                    while (i - 1 >= 0 && d[i - 1] != 'R')
                    {
                        l.Add(-1);
                        i--;
                    }
                }
                else
                {
                    l.Add(0);
                }
            }

            for (int i = 0; i < d.Length; i++)
            {
                if (d[i] == 'R')
                {
                    r.Add(1);
                    while (i + 1 < d.Length && d[i + 1] != 'L')
                    {
                        r.Add(1);
                        i++;
                    }
                }
                else
                {
                    r.Add(0);
                }
            }
            l.Reverse();
            for (int i = 0; i < l.Count; i++)
            {
                if (r[i] + l[i] == -1)
                {
                    rtn.Add("L");
                }
                else if (r[i] + l[i] == 1)
                {
                    rtn.Add("R");
                }
                else if (r[i] + l[i] == 0 && r[i] == 0)
                {
                    rtn.Add(".");
                }
                if (r[i] != 0 && l[i] != 0 && r[i] + l[i] == 0)
                {
                    rtn.Add("M");
                }
            }
            var index = 0;
            int count = 0;
            while (index < rtn.Count)
            {

                if (count == 0 && rtn[index] == "M")
                {
                    count++;
                    while (index + 1 < rtn.Count && rtn[index + 1] == "M")
                    {
                        count++;
                        index++;
                    }
                }
                else if (count > 0 && rtn[index] == "L")
                {
                    if (count % 2 == 0)
                    {
                        int start = index - count;
                        for (int i = 0; i < count; i++)
                        {
                            if (i < count / 2)
                                rtn[start + i] = "R";
                            else
                                rtn[start + i] = "L";
                        }
                    }
                    else
                    {
                        int start = index - count;
                        for (int i = 0; i < count; i++)
                        {
                            if (i == (int)count / 2)
                            {
                                rtn[start + i] = ".";
                            }
                            else if (i <= count / 2)
                            {
                                rtn[start + i] = "R";
                            }
                            else
                            {
                                rtn[start + i] = "L";
                            }
                        }
                    }
                    count = 0;
                }

                index++;
            }

            return String.Join("", rtn.ToArray());
        }
    }
}
