using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation_of_primes
{
    internal class Program
    {
        private static void Main()
        {
            bool[] MakeSieve(int max)
            {
                // Make an array indicating whether numbers are prime.
                bool[] is_prime = new bool[max + 1];
                for (int i = 2; i <= max; i++) is_prime[i] = true;

                // Cross out multiples.
                for (int i = 2; i <= max; i++)
                {
                    // See if i is prime.
                    if (is_prime[i])
                    {
                        // Knock out multiples of i.
                        for (int j = i * 2; j <= max; j += i)
                            is_prime[j] = false;
                    }
                }
                return is_prime;
            }

            List<int> Primes = new List<int>();
            int MaxPrime = 2000000;
            bool[] IsPrime = MakeSieve(MaxPrime);
            for (int i = 2; i < MaxPrime; i++)
            {
                if (IsPrime[i]) Primes.Add(i);
            }

            //Primes.ForEach(Console.WriteLine);

            long Sum = 0;
            for (int i = 0; i < Primes.Count; i++)
            {
                Sum += Primes[i];
            }
            Console.WriteLine("Sum: " + Sum);
        }
    }
}