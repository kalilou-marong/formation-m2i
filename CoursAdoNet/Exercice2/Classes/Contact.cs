using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2.Classes
{
    internal class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private string email;
        private static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\cours-dotnet;Integrated Security=True");
        private static SqlCommand command;
        private static String request;

        public int Id { get => id; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Email { get => email; set => email = value; }

        public Contact(string nom, string prenom, string telephone) 
        { 
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public bool Save()
        {
            request = "INSERT INTO annuaire (nom, prenom, telephone) OUTPUT INSERTED.id values (@nom, @prenom, @telephone)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@telephone", Telephone));

            connection.Open();
            //int nb = command.ExecuteNonQuery();
            id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return id > 0;
        }

        public bool Delete()
        {
            request = "DELETE FROM annuaire where id = @id";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));

            connection.Open();
            int nb = command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
            return nb > 0;
        }

        public static Contact GetContact(string nom)
        {
            Contact contact = null;
            request = "SELECT nom, prenom, telephone from annuaire where nom = @nom";

            connection.Open();
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", nom));
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                contact = new Contact(reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contact;
        }

    }
}
