using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.SetWindowSize(24, 13);

            //Creating play area
            int x = 10, y = 10;
            int[,] grid = new int[x, y];

            //Creating snake
            List<int[]> Snake = new List<int[]>();

            //Creating Candy
            int[] Candy = new int[2];

            Random rnd = new Random();
            bool isDead = false;
            int Dir = 1;

            //Adding Head
            Snake.Add(new int[2]);
            Snake[0][0] = 4;
            Snake[0][1] = 4;

            //Placing Head
            grid[Snake[0][0], Snake[0][1]] = 3;

            //Writing Welcome Message
            Write("Welcome to snake!", 10);
            Write2D();
            Write("Press to start", 10);

            Console.ReadKey();

            //GAME!!!----------------------------------------------------------
            Eat();
            Game();
            void Game()
            {
                //changing head
                if (Dir == 0)
                {
                    Snake[0][1]--;
                }
                else if (Dir == 1)
                {
                    Snake[0][0]++;
                }
                else if (Dir == 2)
                {
                    Snake[0][1]++;
                }
                else
                {
                    Snake[0][0]--;
                }

                //changing the tail
                for (int i = 1; i < Snake.Count; i++)
                {
                    Snake[i][0] = Snake[i - 1][0];
                    Snake[i][1] = Snake[i - 1][0];
                }
                Console.Clear();
                PlaceInGrid();
                Write2D();
                Thread.Sleep(500);
                if (isDead == false)
                {
                    Game();
                }
            }
            void Eat()
            {
                //Add one on tail
                Snake.Add(new int[2]);
                Snake[Snake.Count - 1][0] = Snake[Snake.Count - 2][0];
                Snake[Snake.Count - 1][1] = Snake[Snake.Count - 2][1];

                //Change Candy pos and Chack candy pos
                bool Good = false;
                while (Good == false)
                {
                    Candy[0] = rnd.Next(0, x);
                    Candy[1] = rnd.Next(0, x);
                    Good = true;

                    for (int i = 0; i < Snake.Count; i++)
                    {
                        if (Snake[i][0] == Candy[0] && Snake[i][1] == Candy[1])
                        {
                            Good = false;
                            break;
                        }
                    }
                }
            }

            void PlaceInGrid()
            {
                //Clearing grid
                for (int _y = 0; _y < y; _y++)
                {
                    for (int _x = 0; _x < x; _x++)
                    {
                        grid[_x, _y] = 0;
                    }
                }

                //Placing snake
                grid[Snake[0][0], Snake[0][1]] = 3;
                for (int i = 1; i < Snake.Count; i++)
                {
                    grid[Snake[i][0], Snake[i][1]] = 5;
                }

                //Placing candy
                grid[Candy[0], Candy[1]] = 6;
            }

            //writeFunction
            void Write(string WhatToWrite, int delayMS)
            {
                for (int i = 0; i < WhatToWrite.Length; i++)
                {
                    Console.Write(WhatToWrite[i]);
                    Thread.Sleep(delayMS);
                }
                Console.WriteLine();
            }
            //2D WriteFunction
            void Write2D()
            {
                for (int _y = 0; _y < y; _y++)
                {
                    for (int _x = 0; _x < x; _x++)
                    {
                        Console.Write(grid[_x, _y] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}