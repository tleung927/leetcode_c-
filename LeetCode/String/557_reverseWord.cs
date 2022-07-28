using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.String
{

    public class _557_reverseWord
    {
        public static string ReverseWords(string s)
        {

            string[] arrS = s.Split(" ");
            string[] rtn = new string[arrS.Length];
            int cnt = 0;
            foreach (string w in arrS)
            {
                char[] wod = w.ToCharArray();
                char[] newWord = new char[w.Length];
                int cntWord = 0;
                for (int j = wod.Length - 1; j >= 0; j--)
                {

                    newWord[cntWord] = wod[j];
                    cntWord++;
                }
                rtn[cnt] = string.Join("", newWord);
                cnt++;
            }
            return string.Join(" ", rtn);
        }
    }

}
