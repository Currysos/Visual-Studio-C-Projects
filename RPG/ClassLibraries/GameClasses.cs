using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Classes
    {
        public class Warrior
        {
            public int StartStr = 3;
            public int StartHP = 12;
            public int StartRng = 2;

            public string StartAttack = "Whirlwind";
        }

        public class Rouge
        {
            public int StartStr = 2;
            public int StartHP = 10;
            public int StartRng = 1;

            public string StartAttack = "Sneak";
        }

        public class Ranger
        {
            public int StartStr = 2;
            public int StartHP = 5;
            public int StartRng = 10;

            public string StartAttack = "Multishot";
        }
    }
}