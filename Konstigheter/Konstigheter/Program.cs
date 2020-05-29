using System;

namespace Konstigheter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("From?");
            long a = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("To?");
            long b = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\n\n");

            long number = 0;/*Convert.ToInt32(Console.ReadLine());*/

            long HighestIteration = 0;
            long HighestNumber = 0;

            for (; a <= b; a++)
            {
                long i = 0;
                number = a;

                //Console.WriteLine("number:" + number);
                for (i = 0; number != 1; i++)
                {
                    //Console.WriteLine("Iteration: " + i + "\nStart Number: " + number);
                    if (number % 2 == 0)
                    {
                        number /= 2;
                        //Console.WriteLine("Iteration: " + i + "\nEnd Number: " + number);
                    }
                    else
                    {
                        number = (3 * number) + 1;
                        //Console.WriteLine("Iteration: " + i + "\nEnd Number: " + number);
                    }

                    //Console.WriteLine("\n\n");
                }

                if (HighestIteration < i)
                {
                    HighestIteration = i;
                    HighestNumber = number;
                }
                /*
                Console.WriteLine("Iterations: " + i);
                if (number == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Worked!\n\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Debunked!\n\n");

                    break;
                }*/
            }
            Console.WriteLine("Highest Iterationcount number: " + HighestNumber + " with IterationCount: " + HighestIteration);
            Console.WriteLine("Done");
        }
    }
}