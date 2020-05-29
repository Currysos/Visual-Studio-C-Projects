using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacci
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Initiate Lists
            List<int> FibNumbers = new List<int>();
            List<int> EvenFibNumbers = new List<int>();
            FibNumbers.Add(1);
            FibNumbers.Add(2);
            EvenFibNumbers.Add(2);

            for (int i = 2; ; i++)
            {
                int a = FibNumbers[i - 2];
                int b = FibNumbers[i - 1];

                int c = a + b;

                if (c > 4000000)
                {
                    break;
                }

                FibNumbers.Add(c);

                if (c % 2 == 0)
                {
                    EvenFibNumbers.Add(c);
                }
            }
            //Print fib numbers
            FibNumbers.ForEach(Console.WriteLine);

            //Get Sum of Even fib numbers
            int sum = 0;
            for (int i = 0; i < EvenFibNumbers.Count; i++)
            {
                sum += EvenFibNumbers[i];
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}