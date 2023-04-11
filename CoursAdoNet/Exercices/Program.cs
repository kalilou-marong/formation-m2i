// See https://aka.ms/new-console-template for more information
using Exercice1.Classes;
using Azure.Core;
using Microsoft.Data.SqlClient;

//Console.Write("Merci de saisir le nom : ");
//string nom = Console.ReadLine();

//Console.Write("Merci de saisir le prénom : ");
//string prenom = Console.ReadLine();
//Console.Write("Merci de saisir le numéro de classe : ");
//int.TryParse(Console.ReadLine(), out int numeroClasse);
//Console.Write("Merci de saisir la date du diplome : ");
//DateTime.TryParse(Console.ReadLine(), out DateTime dateDiplome);

////string request = "INSERT INTO etudiant (nom, prenom, n_classe, date_diplome) values (@nom, @prenom, @n_classe, @date_diplome)";

////SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\cours-dotnet;Integrated Security=True");

////SqlCommand command = new SqlCommand(request, connection);
////command.Parameters.Add(new SqlParameter("@nom", nom));
////command.Parameters.Add(new SqlParameter("@prenom", prenom));
////command.Parameters.Add(new SqlParameter("@n_classe", numeroClasse));
////command.Parameters.Add(new SqlParameter("@date_diplome", dateDiplome));

////connection.Open();

////int nb = command.ExecuteNonQuery();

////command.Dispose();
////connection.Close();


//Etudiant etudiant = new Etudiant(nom, prenom, numeroClasse, dateDiplome);
//if (etudiant.Save())
//{
//    Console.WriteLine("Etudiant ajouté avec l'id " + etudiant.Id);
//}


Console.WriteLine("1 - Ajouter un étudiant");
Console.WriteLine("2 - Afficher la totalité des étudiants");
Console.WriteLine("3 - Afficher les étudiants d'une classe");
Console.WriteLine("4 - Supprimer un éttudiant");

Console.WriteLine("Faites votre choix : ");
string choix1 = Console.ReadLine();

if (choix1 == "1")
{
    Console.Write("Merci de saisir le nom : ");
    string nom = Console.ReadLine();
    Console.Write("Merci de saisir le prénom : ");
    string prenom = Console.ReadLine();
    Console.Write("Merci de saisir le numéro de classe : ");
    int.TryParse(Console.ReadLine(), out int numeroClasse);
    Console.Write("Merci de saisir la date du diplome : ");
    DateTime.TryParse(Console.ReadLine(), out DateTime dateDiplome);



    Etudiant etudiant = new Etudiant(nom, prenom, numeroClasse, dateDiplome);
    if (etudiant.Save())
    {
        Console.WriteLine("Etudiant ajouté avec l'id " + etudiant.Id);
    }
}

else if  (choix1 == "2")
{
    
}

private void AjouterEtudiant()
{

}