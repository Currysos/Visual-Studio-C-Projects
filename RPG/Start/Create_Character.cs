using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    public class CreateCharacter
    {
        public void Create_Character()
        {
            Character YourCharacter = new Character();
            WriteAnim _Write = new WriteAnim();

            string Input;

            //Name select
            _Write.Write("Whats your name?", 10);
            YourCharacter.Name = Console.ReadLine();

            //Gender select
            _Write.Write("\nMan or Woman? \nm/w", 10);
            Input = Console.ReadLine();

            if (string.Equals(Input, "m"))
            {
                YourCharacter.Gender = "Man";
                _Write.Write("\n Mr." + YourCharacter.Name + " I see", 10);
            }
            if (string.Equals(Input, "w"))
            {
                YourCharacter.Gender = "Woman";
                _Write.Write("\n Ms." + YourCharacter.Name + " I see", 10);
            }

            GetClass();
            Console.Clear();
            _Write.Write("Welcome " + YourCharacter.Name + " to my text-RPG\n" +
                "\nStats:" +
                "\nName: " + YourCharacter.Name +
                "\nGender: " + YourCharacter.Gender +
                "\nClass: " + YourCharacter.Class +
                "\nStr: " + YourCharacter.Str +
                "\nHp: " + YourCharacter.HP +
                "\nRng: " + YourCharacter.Rng +
                "\nAttacks: " + YourCharacter.Attacks[0] +
                "\nExp: " + YourCharacter.Exp +
                "\nLevel: " + YourCharacter.Level +
                "\nGold: " + YourCharacter.Gold, 10);

            _Write.Write("\nDoes everything look good? y/n", 10);
            Input = Console.ReadLine();
            if (Input.Equals("y"))
            {
                End();
            }
            if (Input.Equals("n"))
            {
                Console.Clear();
                Create_Character();
            }

            void GetClass()
            {
                _Write.Write("What class?", 10);
                _Write.Write("1. Warrior" +
                    "\n2. Rouge" +
                    "\n3. Ranger", 10);

                Input = Console.ReadLine();

                if (string.Equals(Input, "1"))
                {
                    Classes.Warrior YourClass = new Classes.Warrior();
                    YourCharacter.Class = "Warrior";
                    YourCharacter.Str = YourClass.StartStr;
                    YourCharacter.HP = YourClass.StartHP;
                    YourCharacter.Rng = YourClass.StartRng;

                    YourCharacter.Attacks.Add(YourClass.StartAttack);
                }
                if (string.Equals(Input, "2"))
                {
                    Classes.Rouge YourClass = new Classes.Rouge();
                    YourCharacter.Class = "Rouge";
                    YourCharacter.Str = YourClass.StartStr;
                    YourCharacter.HP = YourClass.StartHP;
                    YourCharacter.Rng = YourClass.StartRng;

                    YourCharacter.Attacks.Add(YourClass.StartAttack);
                }
                if (string.Equals(Input, "3"))
                {
                    Classes.Ranger YourClass = new Classes.Ranger();
                    YourCharacter.Class = "Ranger";
                    YourCharacter.Str = YourClass.StartStr;
                    YourCharacter.HP = YourClass.StartHP;
                    YourCharacter.Rng = YourClass.StartRng;

                    YourCharacter.Attacks.Add(YourClass.StartAttack);
                }
            }

            void End()
            {
                Console.Clear();
                _Write.Write("Good!\n Press any to start", 10);

                Console.ReadKey();

                //LINK START
                Console.Clear();
                new Start().StartSequence(YourCharacter);
            }
        }
    }
}