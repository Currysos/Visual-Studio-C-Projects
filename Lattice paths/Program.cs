using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lattice_paths
{
    internal class Program
    {
        private static void Main()
        {
            BigInteger Sides = 20;
            BigInteger Answer;
            Answer = Factorial(Sides * 2) / (Factorial(Sides) * Factorial(Sides));
            Console.WriteLine(Answer);

            BigInteger Factorial(BigInteger n)
            {
                BigInteger res = 1;
                while (n != 1)
                {
                    res = res * n;
                    n = n - 1;
                }

                return res;
            }
        }
    }
}