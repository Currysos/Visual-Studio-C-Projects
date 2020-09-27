using System;
using System.Collections;
using System.Collections.Generic;

namespace Longest_Arithmetic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int TestCases = Convert.ToInt32(Console.ReadLine());
            List<int> Outputs = new List<int>();

            for (int i = 1; i <= TestCases; i++)
            {
                int NumberOfInts = Convert.ToInt32(Console.ReadLine());
                int[] Ints = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

                Outputs.Add(FindLongestArithmetic(Ints));
            }
            for (int i = 0; i < TestCases; i++)
            {
                Console.WriteLine("Case #" + (i + 1) + ": " + Outputs[i]);
            }

            static int FindLongestArithmetic(int[] arr)
            {
                int CurrentDiff = 0;
                int LastDiff = arr[0] - arr[1];
                int CurrentConsecutive = 1;
                int LargestConsecutive = 1;

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    CurrentDiff = arr[i] - arr[i + 1];
                    if (CurrentDiff == LastDiff)
                    {
                        CurrentConsecutive++;
                    }
                    else
                    {
                        CurrentConsecutive = 1;
                        i--;
                    }

                    LastDiff = CurrentDiff;

                    if (LargestConsecutive < CurrentConsecutive) { LargestConsecutive = CurrentConsecutive; }
                }

                return LargestConsecutive;
            }
        }
    }
}