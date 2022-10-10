/**
 * 1328. Break a Palindrome
Medium

1631

625

Add to List

Share
Given a palindromic string of lowercase English letters palindrome, replace exactly one character with any lowercase English letter so that the resulting string is not a palindrome and that it is the lexicographically smallest one possible.

Return the resulting string. If there is no way to replace a character to make it not a palindrome, return an empty string.

A string a is lexicographically smaller than a string b (of the same length) if in the first position where a and b differ, a has a character strictly smaller than the corresponding character in b. For example, "abcc" is lexicographically smaller than "abcd" because the first position they differ is at the fourth character, and 'c' is smaller than 'd'.

 

Example 1:

Input: palindrome = "abccba"
Output: "aaccba"
Explanation: There are many ways to make "abccba" not a palindrome, such as "zbccba", "aaccba", and "abacba".
Of all the ways, "aaccba" is the lexicographically smallest.
Example 2:

Input: palindrome = "a"
Output: ""
Explanation: There is no way to replace a single character to make "a" not a palindrome, so return an empty string.
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.String
{
    class BreakPalindrome
    {
        public static string exec(string palindrome)
        {
            if (palindrome.Length == 1 || palindrome.Length == 0) return string.Empty;
            char[] pa = palindrome.ToCharArray();
             
            for(int i = 0; i < pa.Length; i++)
            {                
                if(pa[i] == 'a' && i == pa.Length - 1)
                {
                    pa[i] = 'b';
                    break;
                }
                else if(pa[i] == 'a' && i != pa.Length - 1)
                {
                    continue;
                }
                else if(i == (int)pa.Length / 2)
                {
                    continue;
                }              
                else if (pa[i] > 'a' )
                {
                    pa[i] = 'a';
                    break;
                }
                else 
                {
                    pa[i] = 'b';
                }                       
            }

            return new string(pa);
        }
    }

}
