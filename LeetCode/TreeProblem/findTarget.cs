/**
 * 
 * 653. Two Sum IV - Input is a BST
Easy

5211

227

Add to List

Share
Given the root of a Binary Search Tree and a target number k, return true if there exist two elements in the BST such that their sum is equal to the given target.

 

Example 1:


Input: root = [5,3,6,2,4,null,7], k = 9
Output: true
Example 2:


Input: root = [5,3,6,2,4,null,7], k = 28
Output: false
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.TreeProblem
{
    class findTarget : PreDefindDataStruct
    {
        public static bool exec(TreeNode root, int k)
        {
            List<int> l = new List<int>();
            l.Add(root.val);

            if(root.left != null)
            {
                iterateT(root.left, l);
            }
            if (root.right != null) 
            {
                iterateT(root.right, l);
            }
            

            l.Sort();
            int i = 0;
            if (l.Count == 1 ) return false;            
            while (i < l.Count - 1)
            {
                int j = i + 1;

                if(l[i] + l[j] == k)
                {
                    return true;
                }
                else if(l[i] + l[j] < k)
                {
                    while(j < l.Count )
                    {
                        if (l[i] + l[j] == k)
                        {
                            return true;
                        }
                        else if (l[i] + l[j] > k)
                        {
                            break;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }
                i++;
            }                
            return false;

        }

        protected static void iterateT(TreeNode root, List<int> l)
        {
            l.Add(root.val);
            if (root.left != null)
            {               
                iterateT(root.left, l);
            }
            if (root.right != null)
            {               
                iterateT(root.right, l);
            }            
        }
    }
}
