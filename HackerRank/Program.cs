using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> input = new List<List<int>>();
        
            for (int i = 0; i < 6; i++)
            {
                input.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }
        
            Console.WriteLine(TwoDArray.HourglassSum(input));
        }
    }
}
