using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class MainMenu
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            WriteAnim _Write = new WriteAnim();

            _Write.Write("Welcome to my humble RPG\n", 10);
            _Write.Write("Want to create a Character? \ny/n", 10);

            string Input;
            Input = Console.ReadLine();

            if (string.Equals(Input, "y"))
            {
                Console.Clear();
                new CreateCharacter().Create_Character();
            }
            if (string.Equals(Input, "n"))
            {
                Console.Clear();
                _Write.Write("Oke )=", 10);
            }
        }
    }
}