using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Large_sum
{
    internal class Program
    {
        private static void Main()
        {
            int Rows = 100;
            string path = Directory.GetCurrentDirectory() + "/Logs/Numbers.txt";

            List<string> Numbers = new List<string>();

            //Get from Text Document
            for (int y = 0; y < Rows; y++)
            {
                Numbers.Add(File.ReadLines(path).Skip(y).Take(1).First());
            }

            Numbers.ForEach(Console.WriteLine);

            BigInteger aVeryVeryHugeSum = 0;

            for (int i = 0; i < Numbers.Count; i++)
            {
                var aVeryVeryHugeNumber = BigInteger.Parse(Numbers[i]);
                aVeryVeryHugeSum += aVeryVeryHugeNumber;
            }
            Console.WriteLine();
            Console.WriteLine(aVeryVeryHugeSum);
        }
    }
}