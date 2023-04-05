using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceHotel.Classes
{
    internal class Clients
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Tel { get; set; }

        public Clients(int id, string nom, string prenom, int tel)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
        }

    }
}
