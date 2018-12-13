using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public class Swordman : Unit
    {
        Unit _battling;
        public Swordman(PlayerColor color)
        {
            Statistics = new Stats(60, 7, 1, 3, 0);
            Cost = new Resources(35, 15, 0);
            _battling = null;
        }

        public Unit Battling
        {
            get { return _battling; }
            set { _battling = value; }
        }

    }
}
