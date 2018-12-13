using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOE.BLL.MessagesBTO;

namespace AOE.BLL.Domain
{
    public class Batiment : IElementEnCarte
    {
        public int SanteMax;
        public Batiment(TypeBatiment Nom, int SanteMax, double Sante)
        {
            this.Nom = Nom;
            this.SanteMax = SanteMax;
            this.Sante = Sante;
        }

        public TypeBatiment Nom { get; }

        private double sante;
        public double Sante
        {
            get { return sante; }
            set { sante = value; }
        }

       
    }
}
