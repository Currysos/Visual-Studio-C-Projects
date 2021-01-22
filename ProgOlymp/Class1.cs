using System;
using System.Collections.Generic;
using System.Text;

namespace ProgOlymp
{
    public class Class1
    {
        public void Chiffer()
        {
            Console.WriteLine("Number of Rows?");
            int Rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of Columns?");
            int Columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your message?");
            string message = Console.ReadLine();

            int[][] grid = new int[Rows, Columns];
        }

        public void PrintArray(int[][] arr)
        {
            foreach (int[] R in arr)
            {
            }
        }
    }
}