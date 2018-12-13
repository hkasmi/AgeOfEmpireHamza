using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public class Bowman : Unit
    {
        Unit _battling;
        public Bowman(PlayerColor color)
        {
            Statistics = new Stats(35, 3, 0, 3, 5);
            Cost = new Resources(40, 0, 20);
            _battling = null;
        }

        public Unit Battling
        {
            get { return _battling; }
            set { _battling = value; }
        }

    }
}
