using System.Runtime.InteropServices;
using System.Xml.Linq;
using Exercice2.Classes;

Start();

static void Menu()
{
    Console.WriteLine("1 - Ajouter un contact");
    Console.WriteLine("2 - Rechercher un contact");
    Console.WriteLine("3 - Supprimer un contact");
    Console.WriteLine("4 - Modifier un contact");

    Console.WriteLine("Tapez votre choix : ");
}
static void Start()
{
    string choix;
    do {
        Menu();
        choix = Console.ReadLine();

        switch (choix)
        {
            case "1":
                AddContact();
                break;
        }
    } while (choix != "0");
}


static void AddContact ()
{
    Console.Write("Merci de saisir le nom : ");
    string nom = Console.ReadLine();

    Console.Write("Merci de saisir le prénom : ");
    string prenom = Console.ReadLine();
    Console.Write("Merci de saisir le numéro de telephone : ");
    string telephone = Console.ReadLine();
    Contact contact = new Contact(nom, prenom, telephone);
    if (contact.Save())
    {
        Console.WriteLine("Contact ajouté avec l'id " + contact.Id);
    }
}


static void DeleteContact ()
{

}

//static void SearchContact()
//{
//    Console.WriteLine("Merci de saisir le nom des contacts recherché : ");
//    string nom = Console.ReadLine ();

//        Contact.GetContact(nom).ForEach(c =>
//        {
//            Console.WriteLine($"Contact : {c.Nom}, {c.Prenom}, {c.NumeroClasse}");
//        });
    

//}