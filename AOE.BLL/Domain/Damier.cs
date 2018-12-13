using AOE.BLL.MessagesBTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOE.BLL.Domain
{
    public class Damier
    {
        public IElementEnCarte[,] Carte { get; private set; }

        public Damier(int MaxX, int MaxY)
        {
            this.MaxX = MaxX;
            this.MaxY = MaxY;

            Carte = new IElementEnCarte[MaxX, MaxY];
        }

        public int MaxX { get; }
        public int MaxY { get; }

        public bool AjouterBatiment(CreationBatiment ACreer)
        {
            try
            {
                Carte[ACreer.X, ACreer.Y] = new Batiment(ACreer.TypeBatiment, 100, 100.0);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
    }
}
