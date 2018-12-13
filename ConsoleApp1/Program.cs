using AOE.model;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace AOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Rouge = new Player(PlayerColor.RED);
            Villager v = (new Villager(Rouge.Color));

            Rouge.addUnit(v);
            v.Harvesting = ResourceType.Food;

            Thread.Sleep(1000);
            Console.WriteLine(Rouge.Stock);

            //Console.ReadKey();
        }
    }
}