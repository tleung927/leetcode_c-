/**
 * 
 * 1545. Find Kth Bit in Nth Binary String
Medium

616

43

Add to List

Share
Given two positive integers n and k, the binary string Sn is formed as follows:

S1 = "0"
Si = Si - 1 + "1" + reverse(invert(Si - 1)) for i > 1
Where + denotes the concatenation operation, reverse(x) returns the reversed string x, and invert(x) inverts all the bits in x (0 changes to 1 and 1 changes to 0).

For example, the first four strings in the above sequence are:

S1 = "0"
S2 = "011"
S3 = "0111001"
S4 = "011100110110001"
Return the kth bit in Sn. It is guaranteed that k is valid for the given n.

 

Example 1:

Input: n = 3, k = 1
Output: "0"
Explanation: S3 is "0111001".
The 1st bit is "0".
Example 2:

Input: n = 4, k = 11
Output: "1"
Explanation: S4 is "011100110110001".
The 11th bit is "1".
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.String
{
    class findNBitString
    {

        public static char exec(int n, int k)
        {            
            string tmp = "0";
            for(int i = 0; i< n - 1 ; i++)
            {
                tmp = buildStr(tmp);
            }
            
            return tmp.ToCharArray()[k-1];
        }

        private static string buildStr(string last)
        {
            List<char> chrA = last.ToCharArray().ToList();

            for(int i = 0; i< chrA.Count; i++)
            {
                if (chrA[i] == '0') chrA[i] = '1';
                else chrA[i] = '0';
            }


            return last + "1"+ new string(chrA.Reverse<char>().ToArray());
        }
    }
}
