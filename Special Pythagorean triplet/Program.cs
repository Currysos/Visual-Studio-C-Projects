using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, c2, Answer = 0, sum = 0;
            bool IsDone = false;

            for (a = 1; a < 500; a++)
            {
                for (b = a + 1; b < 500; b++)
                {
                    c2 = Math.Pow(a, 2) + Math.Pow(b, 2);
                    c = Math.Sqrt(c2);

                    sum = a + b + c;

                    if (a + b + c == 1000)
                    {
                        Answer = a * b * c;
                        IsDone = true;
                        break;
                    }
                }
                if (IsDone == true)
                {
                    break;
                }
            }

            Console.WriteLine("A: " + a + " B: " + b + " C: " + c);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Answer: " + Answer);
        }
    }
}