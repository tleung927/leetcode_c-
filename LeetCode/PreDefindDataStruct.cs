using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public abstract class PreDefindDataStruct
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode root;

            public TreeNode(object[] array)
            {
                this.root = arrayToTree(array, 0);
            }

            public TreeNode()
            {

            }

            public TreeNode(int val)
            {
                this.val = val;
            }

            public TreeNode(int val, TreeNode left, TreeNode right)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }

            public static TreeNode arrayToTree(object[] array)
            {
                return arrayToTree(array, 0);
            }

            public static TreeNode arrayToTree(object[] array, int index)
            {
                if (index >= array.Length)
                    return null;
                if (array[index] == null)
                    return null;
                return new TreeNode(Convert.ToInt32(array[index]), arrayToTree(array, index * 2 + 1), arrayToTree(array, index * 2 + 2));
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }           

            public ListNode(int[] arr)
            {
                
               
            }
        }
    }
}
