using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Necklace
{
    internal class Program
    {
        private static void Main()
        {
            string path = Directory.GetCurrentDirectory() + "/Logs/Numbers.txt";
            char[] necklace = File.ReadAllText(path).ToCharArray();
            List<int> part = new List<int>();

            Stopwatch sw = Stopwatch.StartNew();
            long blues = 0;
            for (int i = necklace.Length - 1; i == -1; i--)
            {
                if (necklace[i].Equals("B"))
                {
                    if (i - (necklace.Length / 2) + 1 < 0)
                    {
                        part.Add(necklace[i - (necklace.Length / 2) + 1] + necklace[i + 1]);
                    }
                    else
                    {
                        part.Add(necklace[i - (necklace.Length / 2) + 1]);
                    }

                    long numberOf = part.Count;
                    if (numberOf > blues)
                    {
                        blues = numberOf;
                    }
                }
            }
            sw.Stop();

            Console.WriteLine(blues);
            Console.WriteLine("Time taken: {0}ms", sw.Elapsed.TotalMilliseconds);
        }
    }
}