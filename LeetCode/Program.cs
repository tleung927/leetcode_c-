using LeetCode.ArrayProblem;
using LeetCode.String;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace LeetCode
{
    class Start
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JsonSerializer.Serialize(_557_reverseWord.ReverseWords("God")));
        }
    }
}
