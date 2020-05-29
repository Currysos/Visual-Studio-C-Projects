using System;
using System.Collections.Generic;
using System.Text;

namespace Largest_product_in_a_grid
{
    public class Print
    {
        public void PrintArray(object[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.WriteLine(Convert.ToString(Arr[i]));
            }
        }

        public void Print2DArray(int[,] Arr, int columns, int rows)
        {
            for (int y = 0; y < columns; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    Console.Write(" " + Arr[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}