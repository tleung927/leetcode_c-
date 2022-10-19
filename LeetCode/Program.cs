using LeetCode.ArrayProblem;
using LeetCode.TreeProblem;
using LeetCode.Intervals;
using LeetCode.String;
using LeetCode.List;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;

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

            object[] arr = { 1, 2, 2, 3, 3, null, null, 4, 4 };
            TreeNode t2 = new TreeNode(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine(JsonSerializer.Serialize(DeleteNode.exec()));
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time is {0} ms", stopwatch.ElapsedMilliseconds);

        }
    }
}

