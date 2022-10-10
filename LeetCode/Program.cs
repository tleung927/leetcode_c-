using LeetCode.ArrayProblem;
using LeetCode.TreeProblem;
using LeetCode.String;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LeetCode
{
    class Start : PreDefindDataStruct
    {
        static void Main(string[] args)
        {
            //List<int> a = new List<int> { 1, 2, 3 };
            //List<int> b = new List<int> { 4, 5, 6 };
            //List<int> c = new List<int> { 7, 8, 9 };
            //List<int> e = new List<int> { 9 };
            //List<int> f = new List<int> { 12, 13, 14, 15, 16 };
            //IList<IList<int>> d = new List<IList<int>>
            //{
            //    a,
            //    b,
            //    c,
            //};

            object[] arr = { 1 };
            TreeNode t2 = new TreeNode(arr);            
            
            Console.WriteLine(JsonSerializer.Serialize(findTarget.exec(t2.root,1)));
        }
    }
}

