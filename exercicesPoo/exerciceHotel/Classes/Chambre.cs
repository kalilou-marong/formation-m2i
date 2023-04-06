using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Chambre
    {
        private static int compteur = 0;
        private int numero;
        private decimal tarif;
        private int nb_personne;

        public int Numero { get => numero; set => numero = value; }
        public decimal Tarif { get => tarif; set => tarif = value; }
        public int Nb_personne { get => nb_personne; set => nb_personne = value; }

        public StatutChambre Statut { get; set; }

        public Chambre(decimal tarif, int nb)
        {
            numero = ++compteur;
            Tarif = tarif;
            Nb_personne = nb;
            Statut = StatutChambre.Libre;
        }

        

    }
    public enum StatutChambre
    {
        Libre,
        Occupe,
        Nettoyage
    }


}
