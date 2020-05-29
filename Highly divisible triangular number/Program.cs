using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Highly_divisible_triangular_number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Count = 500;
            bool IsDone = false;

            List<long> TriangularNumbers = new List<long>();

            List<long> Divisors = new List<long>();

            for (int i = 1; IsDone == false; i++)
            {
                int TempTriangleNumber = 0;
                //Finding the Triangle number
                for (int a = 1; a <= i; a++)
                {
                    TempTriangleNumber += a;
                }
                TriangularNumbers.Add(TempTriangleNumber);

                //Getting all the devisors
                for (int a = 1; a < TempTriangleNumber; a++)
                {
                    if (TempTriangleNumber % a == 0)
                    {
                        Divisors.Add(a);
                    }
                }

                if (Divisors.Count >= Count)
                {
                    IsDone = true;
                    PrintOut(Divisors, TempTriangleNumber);
                    break;
                }
                Divisors.Clear();
            }

            void PrintOut(List<long> divisors, int triangleNumber)
            {
                Console.WriteLine("The triangle number is: " + triangleNumber + " with " + divisors.Count + " Divisors");
                Console.WriteLine();
                Console.WriteLine("Its divisors:");
                divisors.ForEach(Console.WriteLine);
            }
        }
    }
}