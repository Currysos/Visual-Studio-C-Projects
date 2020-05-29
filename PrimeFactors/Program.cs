using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long num = 600851475143;

            List<long> result = new List<long>();
            // Take out the 2s.
            while (num % 2 == 0)
            {
                result.Add(2);
                num /= 2;
            }

            // Take out other primes.
            long factor = 3;
            while (factor * factor <= num)
            {
                if (num % factor == 0)
                {
                    // This is a factor.
                    result.Add(factor);
                    num /= factor;
                }
                else
                {
                    // Go to the next odd number.
                    factor += 2;
                }
            }

            // If num is not 1, then whatever is left is prime.
            if (num > 1) result.Add(num);

            long largest;
            result.Sort();
            largest = result[result.Count - 1];

            Console.WriteLine("PrimeFactors");
            result.ForEach(Console.WriteLine);
            Console.WriteLine("Largest: " + largest);
        }
    }
}