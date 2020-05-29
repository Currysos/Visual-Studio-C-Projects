using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Weapons
    {
        public class Dagger
        {
            public string Name = "Dagger";
            public int Dmg = 2;
            public int Rng = 1;
            public int Speed = 4;

            public int Rarity = 1;
            public int Size = 1;

            public string Description = "A small common dagger, you can hold 2 at the same time.";
        }

        public class LongSword
        {
            public string Name = "Longsword";
            public int Dmg = 4;
            public int Rng = 2;
            public int Speed = 2;

            public int Rarity = 1;
            public int Size = 2;

            public string Description = "A longer but heavier sword, you can only hold one at the time.";
        }
    }
}