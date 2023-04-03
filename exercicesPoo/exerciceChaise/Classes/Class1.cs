using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceChaise.Classes
{
    internal class Chaise
    {
        private int nbPieds;
        private string materiaux;
        private string couleur;

        public Chaise (int NbPieds, string Materiaux, string Couleur)
        {
            this.nbPieds = NbPieds;
            this.materiaux = Materiaux;
            this.couleur = Couleur;
        }

        public int Nbpieds { get => nbPieds; set => nbPieds = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }
        public string Couleur { get => couleur; set => couleur = value; }

    }
}
