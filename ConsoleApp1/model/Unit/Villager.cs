using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AOE.model
{
    public class Villager : Unit
    {
        ResourceType? _harvesting;
        private Resources _stock;
        public event Action<ResourceType> harvestEvent;
        private Task harv;
        public Villager(PlayerColor color)
        {
            Statistics = new Stats(25, 3, 0, 2, 0);
            Cost = new Resources(50, 0, 0);
            _harvesting = null;
            harv = new Task(harvest);
        }

        public ResourceType? Harvesting
        {
            get { return _harvesting; }
            set
            {
                _harvesting = value;
                if (value != null) {

                    
                    if (harv.Status == 0 || harv.IsCompleted)
                    {
                        harv.Start();
                    }
                }else
                {
                    harv.Dispose();
                }

            }
        }

        public void harvest()
        {
            while (true)
            {
                Thread.Sleep(50);
                harvestEvent(_harvesting.Value);
            }
        }

    }
}
