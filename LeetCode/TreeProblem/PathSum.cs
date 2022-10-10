/**
 * 112. Path Sum
Easy

7071

867

Add to List

Share
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.

 

Example 1:


Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:


Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
 

Constraints:

The number of nodes in the tree is in the range [0, 5000].
-1000 <= Node.val <= 1000
-1000 <= targetSum <= 1000
 */

using System;
using System.Collections.Generic;
using System.Text;


namespace LeetCode.TreeProblem
{
    class PathSum : PreDefindDataStruct
    {
        public static Boolean exec(TreeNode root, int targetSum)
        {
            if (root == null) return false;

            if (root.left == null && root.right == null) return root.val == targetSum;

            return exec(root.left, targetSum - root.val)
                || exec(root.right, targetSum - root.val);
        }

        private static Boolean treverTree(TreeNode self,int tmpSum, int targetSum)
        {
            if (self.left != null)
            {
                tmpSum = tmpSum + self.left.val;
                if (tmpSum == targetSum) 
                    return true;
                treverTree(self.left, tmpSum, targetSum);
            }

            if (self.right != null)
            {
                tmpSum = tmpSum + self.right.val;
                if (tmpSum == targetSum)
                    return true;
                treverTree(self.right, tmpSum, targetSum);
            }
            
            return false;
        }
    }


}
