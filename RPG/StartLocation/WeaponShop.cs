using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class WeaponShop
    {
        public void _WeaponShop(Character _Character)
        {
            string Input;
            Random Rand = new Random();
            WriteAnim _Write = new WriteAnim();
            Character YourCharacter = _Character;

            List<Object> Stock = new List<Object>();

            for (int i = 0; i < Rand.Next(1, 4); i++)
            {
                int a = Rand.Next(1, 2);

                if (a == 1)
                {
                    Stock.Add(new Weapons.Dagger());
                }
                else if (a == 2)
                {
                    Stock.Add(new Weapons.LongSword());
                }
            }

            _Write.Write("Welcome dear, what would you like?\nI have everything from swords and mases to bows and arrows. Choose wisely.\nStock:", 10);

            for (int i = 0; i < Stock.Count; i++)
            {
                var Weapon = Stock[i].GetType();
                Console.WriteLine(Weapon.Name);
            }

            _Write.Write("Type exit to exit the weapon shop",10);
            Input = Console.ReadLine();
            if(string.Equals(Input, "exit"))
            {
                Console.Clear();
                new Start().StartSequence(YourCharacter);
            }
        }
    }
}