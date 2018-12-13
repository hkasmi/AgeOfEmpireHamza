using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public class Cavalry : Unit
    {
        Unit _battling;
        public Cavalry(PlayerColor color)
        {
            Statistics = new Stats(150,8,0,4,0);
            Cost = new Resources(70, 80, 0);
            _battling = null;
        }

        public Unit Battling
        {
            get { return _battling; }
            set { _battling = value; }
        }

    }
}
