using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1.Classes
{
    internal class Etudiant
    {
        private int id;
        private string nom;
        private string prenom;
        private int numeroClasse;
        private DateTime dateDiplome;
        private static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\cours-dotnet;Integrated Security=True");
        private static SqlCommand command;
        private static String request;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int NumeroClasse { get => numeroClasse; set => numeroClasse = value; }
        public DateTime DateDiplome { get => dateDiplome; set => dateDiplome = value; }
        public int Id { get => id; }

        public Etudiant(string nom, string prenom, int numeroClasse, DateTime dateDiplome)
        {
            Nom = nom;
            Prenom = prenom;
            NumeroClasse = numeroClasse;
            DateDiplome = dateDiplome;
        }

        public bool Save()
        {
            request = "INSERT INTO etudiant (nom, prenom, n_classe, date_diplome) OUTPUT INSERTED.id values (@nom, @prenom, @n_classe, @date_diplome)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@n_classe", NumeroClasse));
            command.Parameters.Add(new SqlParameter("@date_diplome", DateDiplome));
            connection.Open();
            //int nb = command.ExecuteNonQuery();
            id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return id > 0;
        }

        public bool AfficherTotalite()
        {
            request = "SELECT * FROM etudiant";
            command = new SqlCommand(request, connection);
            connection.Open();
            id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return id > 0;

        }
    }
}
