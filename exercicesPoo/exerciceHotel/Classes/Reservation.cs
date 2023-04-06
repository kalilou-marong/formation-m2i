using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Reservation
    {
        private static int compteur = 0;
        private int numeroReservation;
        private List<Chambre> chambres;
        private Client client;
        private StatutReservation statut;

        public List<Chambre> Chambres { get => chambres; set => chambres = value; }
        public Client Client { get => client; set => client = value; }
        public StatutReservation Statut { get => statut; set => statut = value; }
        public int NumeroReservation { get => numeroReservation; set => numeroReservation = value; }

        public Reservation(Client client)
        {
            numeroReservation = ++compteur;
            Client = client;
            Statut = StatutReservation.Prevu;
            Chambres = new List<Chambre>();
        }

    }

    public enum StatutReservation
    {
        Prevu,
        EnCours,
        Fini,
        Annule
    }
}
