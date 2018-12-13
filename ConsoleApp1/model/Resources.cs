using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public class Resources
    {
      
        private int Food;
        private int Gold;
        private int Wood;

        public Resources()
        {
            Food = 1000;
            Gold = 1000;
            Wood = 1000;
        }
        public Resources(int food, int gold, int wood)
        {
            Food = food;
            Gold = gold;
            Wood = wood;
        }

        public int food
        {
            get { return Food; }
            set { Food = value; }
        }
        public int gold
        {
            get { return Gold; }
            set { Gold = value; }
        }

        public int wood
        {
            get { return Wood; }
            set { Wood = value; }
        }

        public static Resources operator +(Resources first, Resources second)
        {
            return new Resources(first.food + second.food, first.gold + second.gold, first.wood + second.wood);
        }
        public static Resources operator -(Resources first, Resources second)
        {
            return new Resources(first.food - second.food, first.gold - second.gold, first.wood - second.wood);
        }
        public override string ToString()
        {
            return ($"Food:{food} Gold:{gold} wood:{wood}");
        }
    }
}
