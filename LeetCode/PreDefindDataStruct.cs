using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public abstract class PreDefindDataStruct
    {
        // create tree class from ojbect array 
        public class Tree
        {
            public Tree(object[] arr)
            {                
                this.root = this.insertLevelOrder(arr, 0);
                this.inOrder(this.root);
            }

            public Node root;

            // Tree Node
            public class Node
            {
                public int val;
                public Node left, right;
                public Node(int val)
                {
                    this.val = val;
                    this.left = null;
                    this.right = null;
                }
            }

            // Function to insert nodes in level order
            public Node insertLevelOrder(object[] arr, int i)
            {
                Node root = null;
                // Base case for recursion
                if (i < arr.Length)
                {
                    if (arr[i] != null)
                    {
                        root = new Node(Convert.ToInt32(arr[i]));

                        // insert left child
                        root.left = insertLevelOrder(arr, 2 * i + 1);

                        // insert right child
                        root.right = insertLevelOrder(arr, 2 * i + 2);
                    }



                }
                return root;
            }

            // Function to print tree
            // nodes in InOrder fashion
            public void inOrder(Node root)
            {
                if (root != null)
                {
                    inOrder(root.left);
                    inOrder(root.right);
                }
            }
        }
    }
}
