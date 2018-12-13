using System;
using System.Collections.Generic;
using System.Text;
using AOE;
using AOE.model;

namespace AOE
{
    public class Player
    {
        private Resources _stock;
        private PlayerColor _color;
        private List<Unit> _units;

        public List<Unit> Units
        {
            get { return _units; }
            set { _units = value; }
        }


        public Player(PlayerColor color)
        {
            _stock = new Resources();
            _units = new List<Unit>();
            _color = color;
        }

        public PlayerColor Color
        {
            get { return _color; }
        }

        public Resources Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }

        public void ActionListenHarvest(ResourceType harvesting)
        {
            switch (harvesting)
            {
                case ResourceType.Food:
                    _stock.food += 1;
                    break;
                case ResourceType.Gold:
                    _stock.gold += 1;
                    break;
                case ResourceType.Wood:
                    _stock.wood += 1;
                    break;
                default:
                    break;
            }
        }

        public void addUnit(Unit unit)
        {
            Units.Add(unit);
            if (unit is Villager)
            {
                ((Villager)unit).harvestEvent += ActionListenHarvest;
            }
        }
    }
}
