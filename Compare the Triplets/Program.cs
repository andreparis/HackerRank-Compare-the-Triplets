using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Compare_the_Triplets
{
    /// <summary>
    /// Problem: https://www.hackerrank.com/challenges/compare-the-triplets/problem
    /// </summary>
    class Program
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> score = new List<int>();
            int aCount = a.Count,
                bCount = b.Count;
            if (aCount != bCount)
                throw new Exception("Alice and Bob must have arrays with same length!");
            score.AddRange(new int[] { 0, 0});
            for (int i = 0; i < aCount; i++)
            {
                if (a[i] > b[i])
                {
                    score[0] += 1;
                }
                else if (a[i] < b[i])
                {
                    score[1] += 1;
                }
            }
            return score;

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
