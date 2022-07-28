using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


/**
 * 168. Excel Sheet Column Title
Easy

2583

390

Add to List

Share
Given an integer columnNumber, return its corresponding column title as it appears in an Excel sheet.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...
 

Example 1:

Input: columnNumber = 1
Output: "A"
Example 2:

Input: columnNumber = 28
Output: "AB"
Example 3:

Input: columnNumber = 701
Output: "ZY"
 */

// https://leetcode.com/problems/excel-sheet-column-title/

namespace LeetCode.String
{
    public class excelColumn
    {
        public static string ConvertToTitle(int columnNumber)
        {
            Hashtable numsToName = new Hashtable();

            numsToName.Add(1, "A");
            numsToName.Add(2, "B");
            numsToName.Add(3, "C");
            numsToName.Add(4, "D");
            numsToName.Add(5, "E");
            numsToName.Add(6, "F");
            numsToName.Add(7, "G");
            numsToName.Add(8, "H");
            numsToName.Add(9, "I");
            numsToName.Add(10, "J");
            numsToName.Add(11, "K");
            numsToName.Add(12, "L");
            numsToName.Add(13, "M");
            numsToName.Add(14, "N");
            numsToName.Add(15, "O");
            numsToName.Add(16, "P");
            numsToName.Add(17, "Q");
            numsToName.Add(18, "R");
            numsToName.Add(19, "S");
            numsToName.Add(20, "T");
            numsToName.Add(21, "U");
            numsToName.Add(22, "V");
            numsToName.Add(23, "W");
            numsToName.Add(24, "X");
            numsToName.Add(25, "Y");
            numsToName.Add(26, "Z");

       
            if(columnNumber <= 26)
            {
                return numsToName[columnNumber].ToString();
            }
            else
            {
                List<double> word = new List<double>();
                int total = columnNumber;
                while(total > 26)
                {
                    total = total / 26;
                    if (total <= 26)
                    {
                        word.Add((int)total);
                    }

                    
                }

                int final = total;
                while(final < columnNumber)
                {
                    
                    final = final * 26;
                    word.Add(final);
                }


                var a = "abc";
            }



            return "abc";
           
        }
    }
}
