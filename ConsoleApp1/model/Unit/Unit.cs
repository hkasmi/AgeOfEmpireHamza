using System;
using System.Collections.Generic;
using System.Text;

namespace AOE.model
{
    public abstract class Unit
    {
        private Stats _statistics;
        private Resources _cost;
        private PlayerColor _color;

        public PlayerColor Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Resources Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public Stats Statistics
        {
            get { return _statistics; }
            set { _statistics = value; }
        }
        
    }
}
