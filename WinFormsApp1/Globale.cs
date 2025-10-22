using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    
    class donnees
    {
        public static bool verifmatricule = false;
        public static bool verifmdp = false;
        public struct liste
        {
            public int matricule;
        }

        public static liste[] tabListe = new liste[100];
        public static int nbListe = 0;

        public struct liste2
        {
            public String mdp;
            public String autorisation;
            public String datedebut;
        }

        public static liste2[] tabListe2 = new liste2[100];
        public static int nbListe2 = 0;
    }
}
