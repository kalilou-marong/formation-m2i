// See https://aka.ms/new-console-template for more information
using Azure.Core;
using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, World!");

string connectionString = "Data Source=(LocalDb)\\cours-dotnet;Integrated Security=True";
SqlConnection connection = new SqlConnection(connectionString);
connection.Open();
if (connection.State == System.Data.ConnectionState.Open)
    Console.WriteLine("Connexion ok");
else
    Console.WriteLine("Connexion error");

string titre = "la course";
string auteur = "toto";
string editeur = "titi";
string date_publication = "2023-10-11"; 
string isbn_10 = "momo";
string isbn_13 = "mimi";



string  request = "INSERT INTO livre ( titre, auteur, editeur, date_publication, isbn_10, isbn_13) values( @titre, @auteur, @editeur, @date_publication, @isbn_10, @isbn_13)";
SqlCommand command = new SqlCommand(request, connection);

command.Parameters.Add(new SqlParameter("@titre", titre));
command.Parameters.Add(new SqlParameter("@auteur", auteur));
command.Parameters.Add(new SqlParameter("@editeur", editeur));
command.Parameters.Add(new SqlParameter("@date_publication", date_publication));
command.Parameters.Add(new SqlParameter("@isbn_10", isbn_10));
command.Parameters.Add(new SqlParameter("@isbn_13", isbn_13));

int nbLigne = command.ExecuteNonQuery();
Console.WriteLine("Le nombre de lignes ajoutées : " + nbLigne);

command.Dispose();


connection.Close();
