using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_product_in_a_grid
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int Columns = 20;
            int Rows = 20;

            int[,] Grid = new int[Columns, Rows];

            string path = Directory.GetCurrentDirectory() + "/Logs/Numbers.txt";

            string[] Lines = new string[Rows];

            Print print = new Print();

            //Get from Text Document
            for (int y = 0; y < Rows; y++)
            {
                Lines[y] = File.ReadLines(path).Skip(y).Take(1).First();
            }

            //Convert To the 2D arrays
            for (int y = 0; y < Columns; y++)
            {
                string[] NumbersInThisY = Lines[y].Split();
                for (int x = 0; x < Rows; x++)
                {
                    Grid[x, y] = Convert.ToInt32(NumbersInThisY[x]);
                }
            }
            Console.WriteLine(CheckHorizontal());
            Console.WriteLine();
            Console.WriteLine(CheckVertical());
            Console.WriteLine();
            Console.WriteLine(CheckDiagonalRight());
            Console.WriteLine();
            Console.WriteLine(CheckDiagonalLeft());

            int CheckHorizontal()
            {
                int answer;
                List<int> Answers = new List<int>();
                for (int y = 0; y < Columns; y++)
                {
                    for (int x = 0; x < Rows - 3; x++)
                    {
                        Answers.Add(Grid[y, x] * Grid[y, x + 1] * Grid[y, x + 2] * Grid[y, x + 3]);
                    }
                }
                Answers.Sort();
                answer = Answers[Answers.Count - 1];
                return answer;
            }
            int CheckVertical()
            {
                int answer;
                List<int> Answers = new List<int>();
                for (int x = 0; x < Rows; x++)
                {
                    for (int y = 0; y < Columns - 3; y++)
                    {
                        Answers.Add(Grid[y, x] * Grid[y + 1, x] * Grid[y + 2, x] * Grid[y + 3, x]);
                    }
                }
                Answers.Sort();
                answer = Answers[Answers.Count - 1];
                return answer;
            }
            int CheckDiagonalRight()
            {
                int answer;
                List<int> Answers = new List<int>();
                for (int y = 0; y < Columns - 3; y++)
                {
                    for (int x = 0; x < Rows - 3; x++)
                    {
                        Answers.Add(Grid[y, x] * Grid[y + 1, x + 1] * Grid[y + 2, x + 2] * Grid[y + 3, x + 3]);
                    }
                }
                Answers.Sort();
                answer = Answers[Answers.Count - 1];
                return answer;
            }
            int CheckDiagonalLeft()
            {
                int answer = 0;
                List<int> Answers = new List<int>();
                for (int y = 0; y < Columns - 3; y++)
                {
                    for (int x = 3; x < Rows; x++)
                    {
                        Answers.Add(Grid[y, x] * Grid[y + 1, x - 1] * Grid[y + 2, x - 2] * Grid[y + 3, x - 3]);
                    }
                }
                Answers.Sort();
                answer = Answers[Answers.Count - 1];
                return answer;
            }
        }
    }
}