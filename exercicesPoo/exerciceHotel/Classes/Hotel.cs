using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Hotel
    {
        private string nom;
        private List<Client> clients;
        private List<Chambre> chambres;
        private List<Reservation> reservations;

        public string Nom { get => nom; set => nom = value; }
        public List<Client> Clients { get => clients; set => clients = value; }
        public List<Chambre> Chambres { get => chambres; set => chambres = value; }
        public List<Reservation> Reservations { get => reservations; set => reservations = value; }

        public Hotel()
        {
            //Créer et ajouter des chambres => A faire
        }

        //Méthode pour créer et ajouter un Client
        public Client CreerClient(string nom, string prenom, string telephone)
        {
            //A Faire
            return null;
        }

        //Méthode pour Créer une réservation
        public Reservation CreerReservation(Client client, List<Chambre> chambres)
        {
            //A faire
            return null;
        }

        public bool AnnulerReservation(int numeroReservation)
        {
            //A faire
            return false;
        }
    }
}
