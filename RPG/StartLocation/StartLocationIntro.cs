using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class Start
    {
        public void StartSequence(Character _Character)
        {
            string Input;
            WriteAnim _Write = new WriteAnim();
            Character YourCharacter = _Character;

            _Write.Write("Welcome to the starter town!" +
                "\nYou can do a bunch of fun stuff here like go shopping, competing in the arena, learn new skills or just sleep for the night. " +
                "\n\nWhat do you want to do?" +
                "\nWeapon shop (w)" +
                "\nArmour show (as)" +
                "\nArena (a)" +
                "\nTavern (t)" +
                "\n", 10);
            Input = Console.ReadLine();

            if (string.Equals(Input, "w"))
            {
                //WeapondShop
                Console.Clear();
                new WeaponShop()._WeaponShop(YourCharacter);
            }
            if (string.Equals(Input, "as"))
            {
                //ArmourShop
            }
            if (string.Equals(Input, "a"))
            {
                //Arena
            }
            if (string.Equals(Input, "t"))
            {
                //Tavern
            }
        }
    }
}