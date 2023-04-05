using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Client
    {
        private static int compteur = 0;
        private int id;
        private string nom;
        private string prenom;
        private string telephone;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Client(string nom, string prenom, string telephone)
        {
            id = ++compteur;
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }
    }
}
