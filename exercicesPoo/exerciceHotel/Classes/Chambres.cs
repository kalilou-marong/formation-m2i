using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exerciceHotel.Classes
{
    internal class Chambres
    {
        private int NumChambre {get; set; }
        private string Statut {get; set; }
        private int NombreLits {get; set; }
        private decimal Tarif { get; set; }

        public Chambres(int numChambre, string statut, int nombreLits,
            decimal tarif)
        {
           NumChambre = numChambre;
           Statut = statut;
           NombreLits = nombreLits;
           Tarif = tarif;
        }

    }
}
