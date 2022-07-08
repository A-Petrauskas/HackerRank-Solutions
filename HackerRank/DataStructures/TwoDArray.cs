using System.Collections.Generic;

namespace HackerRank
{
    class TwoDArray
    {
        // Link to problem: https://www.hackerrank.com/challenges/2d-array/problem

/*
1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0
*/

        //static void Main(string[] args)
        //{
        //    List<List<int>> input = new List<List<int>>();
        //
        //    for (int i = 0; i < 6; i++)
        //    {
        //        input.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        //    }
        //
        //    Console.WriteLine(TwoDArray.HourglassSum(input));
        //}

        public static int HourglassSum(List<List<int>> input)
        {
            var largestSum = -63;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var sum = 0;
                    sum += input[i][j] + input[i][j + 1] + input[i][j + 2] + input[i + 1][j + 1] + input[i + 2][j] + input[i + 2][j + 1] + input[i + 2][j + 2];

                    largestSum = sum > largestSum ? sum : largestSum;
                }
            }

            return largestSum;
        }
    }
}
