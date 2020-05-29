using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    //Character stats
    public class Character
    {
        public string Name;
        public string Gender;
        public string Class;
        public int Str;
        public int HP;
        public int Rng;
        public int Exp = 0;
        public int Level = 1;
        public int Gold = 10;

        public List<string> Attacks = new List<string>();

        public string Location;
    }
}