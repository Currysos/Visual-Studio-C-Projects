using System;

namespace Factorial_Illusion
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Input Number");
            int inNumber = Convert.ToInt32(Console.ReadLine());
            int outnumber = 1;

            for (; inNumber > 0; inNumber--)
            {
                outnumber = Multiplication(outnumber, inNumber);
            }

            Console.WriteLine(outnumber);

            int Multiplication(int number, int multiply)
            {
                int startnumber = number;
                for (int i = 1; i < multiply; i++)
                {
                    number += startnumber;
                }

                return number;

                //Den bruna melonen i afrika ruttnade i hettan
                //Den nyvakna programmeraren sliter av sitt hår frustrerat
                //Den slitna och välanvända datorn frös snabbt och utan anledning i källaren
            }
        }
    }
}