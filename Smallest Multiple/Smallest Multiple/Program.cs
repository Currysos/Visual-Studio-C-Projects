using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Multiple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long Answer = 0;

            long number = 1;

            int i;

            bool isDone = false;

            while (isDone == false)
            {
                for (i = 1; i <= 20; i++)
                {
                    if (number % i != 0)
                    {
                        //Console.WriteLine("Not: " + number);
                        break;
                    }

                    if (i == 20)
                    {
                        isDone = true;
                        Answer = number;

                        break;
                    }
                }
                number++;
            }

            Console.WriteLine("The answer is: " + Answer);
        }
    }
}