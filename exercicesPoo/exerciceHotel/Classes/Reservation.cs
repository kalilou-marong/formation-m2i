using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceHotel.Classes
{
    public class Reservation
    {
        private List<Chambre> chambre;
        private Client client;
        private StatutReservation statut;

        public List<Chambre> Chambre { get => chambre; set => chambre = value; }
        public Client Client { get => client; set => client = value; }
        public StatutReservation Statut { get => statut; set => statut = value; }
    }

    public enum StatutReservation
    {
        Prevu,
        EnCours,
        Fini,
        Annule
    }
}
