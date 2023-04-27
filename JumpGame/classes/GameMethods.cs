using System.Collections.Generic;
using System;
using JumpGame.classes;

namespace JumpGame.classes
{
    public class methods
    {
        //Print 2d array
        public static void print2DArray(char[,] array)
        {
            Console.Clear();
            string output = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    output += array[i, j] + " ";
                }
                output += "\n";
            }
            Console.WriteLine(output);
        }

        //Create the 2d array
        public static void setBorders(ref char[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == 0 || i == array.GetLength(0) - 1 || j == 0 || j == array.GetLength(1) - 1)
                    {
                        array[i, j] = '#';
                    }
                }
            }
        }

        public static void setMenu(ref char[,] array)
        {
            string message = "JUMPY";
            char[] messageChars = message.ToCharArray();
            int xOffset = 17;

            for (int i = 0; i < messageChars.Length; i++)
            {
                array[3, i + xOffset] = messageChars[i];
            }
        }

        public static void setPlayer(Player player, ref char[,] array) => array[player.height, 5] = player.character;
        public static void moveWorld(ref char[,] array)
        {
            char[,] newArray = new char[array.GetLength(0), array.GetLength(1)];

            //Whitelisted characters
            List<char> dontMoveThese = new List<char> { '#', '@' };
            //Loopies
            for (int i = 1; i < array.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < array.GetLength(1); j++)
                {

                    //If it isnt in whitelist, move!
                    if (!dontMoveThese.Contains(array[i, j]))
                    {
                        newArray[i, j - 1] = array[i, j];
                    }
                }
            }
            array = newArray;
        }

        public static bool updateObstacles(ref List<Obstacle> obstacles, Player player) {
            bool removeFirst = false;
            for (int i = 0; i < obstacles.Count; i++)
            {
                obstacles[i].pos--;
                if (obstacles[i].pos == 5 && player.height == 7) {
                    return true;
                }
                if(obstacles[i].pos == 1) {
                    obstacles.RemoveAt(0);
                }
            }
            return false;
        }

        public static int timeToSpawn = 0;
        public static void createObstacle(ref char[,] array, ref List<Obstacle> obstacles)
        {
            if (timeToSpawn == 0)
            {
                Obstacle currentObstacle = new Obstacle();
                array[7, 28] = currentObstacle.character;
                currentObstacle.pos = 28;
                timeToSpawn = 3;
                obstacles.Add(currentObstacle);
            }
        }
    }
}