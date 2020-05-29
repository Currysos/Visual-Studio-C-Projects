using System;

namespace Sum_square_difference
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long input = 100;

            Console.WriteLine("Answer is: " + (sumSquare(input) - squareSum(input)));

            long sumSquare(long number)
            {
                long Answer = 0;
                for (long i = 1; i <= number; i++)
                {
                    Answer += Convert.ToInt64(Math.Pow(i, 2));
                }

                return Answer;
            }
            long squareSum(long number)
            {
                long Answer = 0;

                for (long i = 1; i <= number; i++)
                {
                    Answer += i;
                }
                Answer = Convert.ToInt64(Math.Pow(Answer, 2));

                return Answer;
            }
        }
    }
}