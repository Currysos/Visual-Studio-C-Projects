using static JumpGame.classes.methods;
using JumpGame.classes;
using System.Threading;
using System;
using System.Collections;
using System.Collections.Generic;

//Setup
int WORLD_LENGTH = 30;
int WORLD_HEIGHT = 10;
int TICK_SPEED = 100;
int FRAME = 1;

Random rnd = new Random();

Player PLAYER = new Player();
PLAYER.startKeyListener();

List<Obstacle> OBSTACLES = new List<Obstacle>();

//Instatiate world
char[,] WORLD = new char[WORLD_HEIGHT, WORLD_LENGTH];
setBorders(ref WORLD);
setMenu(ref WORLD);
print2DArray(WORLD);

do
{
    FRAME++;
    WORLD[8, 29] = '¯';

    bool died = updateObstacles(ref OBSTACLES, PLAYER);

    if(died) {
        break;
    }

    moveWorld(ref WORLD);
    setBorders(ref WORLD);

    int possibility = rnd.Next(0, 6);

    if (possibility == 0) {
        createObstacle(ref WORLD, ref OBSTACLES);
    }
    if(timeToSpawn != 0) {
        timeToSpawn--;
    }

    PLAYER.updatePlayer();
    setPlayer(PLAYER, ref WORLD);




    print2DArray(WORLD);
    Thread.Sleep(TICK_SPEED);
} while (true);

Console.WriteLine("Game Over");