using System;
using System.Collections.Generic;

namespace HackerRank_Problems
{
    // Link to problem: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

    class BdayGiftProbability
    {
        static void Main(string[] args)
        {
            var input = new List<int>
            {
                1, 2, 2, 2
            };

            Console.WriteLine(GetExpectedValue(input));
        }

        private static double GetExpectedValue(List<int> input)
        {
            double result = 0;

            for (int i = 0; i < input.Count; i++)
            {
                result += input[i] * 0.5;
            }

            return Math.Round(result, 2);
        }
    }
}
