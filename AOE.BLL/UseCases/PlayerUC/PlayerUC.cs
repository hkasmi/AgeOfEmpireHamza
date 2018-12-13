using AOE.BLL.Domain;
using AOE.BLL.MessagesBTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOE.BLL.UseCases
{
    public class PlayerUC
    {
        public PlayerUC()
        {

        }

        public bool CreerBatiment(CreationBatiment BatimentAConstruire)
        {
            //Logic Creation du Jeux
            var damier = new Damier(100, 100);

            //BLL
            return damier.AjouterBatiment(BatimentAConstruire);

        }

    }
}
