using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Limit = 1000;
            List<int> MultiplesList = new List<int>();

            for (int i = 1; i < Limit; i++)
            {
                if (i % 3 == 0)
                {
                    MultiplesList.Add(i);
                }
                else if (i % 5 == 0)
                {
                    MultiplesList.Add(i);
                }
            }

            MultiplesList.ForEach(Console.WriteLine);

            int sum = MultiplesList.Sum();

            Console.WriteLine(sum);
        }
    }
}