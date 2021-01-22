using System;
using System.Collections.Generic;
using System.Text;

namespace ProgOlymp
{
    public class UPG_1
    {
        public void Cubes()
        {
            Console.WriteLine("Number of big Cubes?");
            int NumberOfCubes = Convert.ToInt32(Console.ReadLine());
            double smallCubes = 0;

            for (int i = 1; i <= NumberOfCubes; i++)
            {
                smallCubes += Math.Pow(i, 3);
            }

            Console.WriteLine("Number of small cubes: ");
            Console.WriteLine(smallCubes);
        }
    }
}