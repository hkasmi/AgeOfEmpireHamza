using AOE.BLL.MessagesBTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOE.BLL.Domain
{
    public interface IElementEnCarte
    {
        TypeBatiment Nom { get; }
        double Sante { get; set; }
        
    }
}
