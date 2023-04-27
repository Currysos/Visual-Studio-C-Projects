using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace JumpGame.classes
{
    public class Player
    {
        public char character = '@';
        public int height = 7;
        int groundHeight = 7;
        public int score = 0;

        private bool canJump = true;


        public void startKeyListener()
        {
            Task keyListener = new Task(() =>
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                if (cki.Key == ConsoleKey.Spacebar)
                {
                    jump();
                }
            } while (true);
        });

            keyListener.Start();
        }

        public void updatePlayer()
        {
            if (height != groundHeight)
            {
                // is not grounded
                height++;
                canJump = false;
            }
            else
            {
                canJump = true;
            }
        }

        private void jump()
        {
            if (canJump)
            {
                Console.Beep();
                height -= 4;
                canJump = false;
            }

        }
    }
}