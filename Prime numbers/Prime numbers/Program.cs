using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long Quantity = 10001;
            long CurrentNumber = 2;
            bool isDone = false;

            List<long> PrimeNumbers = new List<long>();
            PrimeNumbers.Add(2);

            while (isDone == false)
            {
                //Check if its a prime number
                for (long i = 2; i < CurrentNumber; i++)
                {
                    if (CurrentNumber % i == 0)
                    {
                        break;
                    }
                    if (i == CurrentNumber - 1)
                    {
                        if (PrimeNumbers.Count == Quantity)
                        {
                            isDone = true;
                            break;
                        }
                        PrimeNumbers.Add(CurrentNumber);
                    }
                }
                CurrentNumber++;
            }

            PrimeNumbers.ForEach(Console.WriteLine);
        }
    }
}