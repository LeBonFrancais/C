using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebonfrancais.service
{
    public class ModeleInscrits
    {
        public void chargerInscrits(string inscrit)
        {
            Controleur.VmodeleC.charger("Select IDINSCRIT FROM inscrit where NOM like '" + inscrit + "'", Controleur.VmodeleC.DT[20]);
        }
    }
}
