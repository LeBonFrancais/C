using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebonfrancais.service
{    
    public static class Controleur
    {
        private static ModeleConnexion vmodeleC;
        private static ModeleContact vmodeleCt;
        private static ModeleInscrits vmodeleI;
        private static ModeleServices vmodeleSe;
        private static ModeleStatistique vmodeleStat;


        public static ModeleConnexion VmodeleC { get => vmodeleC; set => vmodeleC = value; }
        public static ModeleContact VmodeleCt { get => vmodeleCt; set => vmodeleCt = value; }
        public static ModeleInscrits VmodeleI { get => vmodeleI; set => vmodeleI = value; }
        public static ModeleServices VmodeleSe { get => vmodeleSe; set => vmodeleSe = value; }
        public static ModeleStatistique VmodeleStat { get => vmodeleStat; set => vmodeleStat = value; }


        public static void initConnexion()
        {
            VmodeleC = new ModeleConnexion();
        }
        public static void initContact()
        {
            VmodeleCt = new ModeleContact();
        }
        public static void initInscrit()
        {
            VmodeleI = new ModeleInscrits();
        }
        public static void initUtilisateur()
        {
            VmodeleI = new ModeleInscrits();
        }
    }
}
