﻿/**
 * 36. Valid Sudoku
Medium

6472

796

Add to List

Share
Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
 

Example 1:


Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 

Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LeetCode.ArrayProblem
{
    class validSoduku
    {
        public static Boolean exec(char[][] board)
        {
            // horizontal
            foreach(char[] bs in board)
            {
                if(bs.ToList().FindAll(x=> x != '.').GroupBy(x=>x).Any(x=>x.Skip(1).Any()))
                {
                    return false;
                }
            }   
            // vertically 
            for(int j= 0; j < 9; j++) {
                List<char> bs = new List<char>();
                for (int i = 0; i < 9; i++)
                {                    
                    bs.Add(board[i][j]);
                    
                }
                if (bs.ToList().FindAll(x => x != '.').GroupBy(x => x).Any(x => x.Skip(1).Any()))
                {
                    return false;
                }
            }

            // matrix 
            for(int j = 0; j< 9; j = j + 3)
            {                
                for (int i = 0; i < 9; i = i + 3)
                {
                    List<char> bs = new List<char>();
                    for (int m = 0; m < 3; m++)
                    {
                        for(int n=0; n<3; n++)
                        {
                            bs.Add(board[j + m][n + i]);
                        }
                    }
                    if (bs.ToList().FindAll(x => x != '.').GroupBy(x => x).Any(x => x.Skip(1).Any()))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
