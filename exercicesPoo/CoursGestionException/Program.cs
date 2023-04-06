// See https://aka.ms/new-console-template for more information
using CoursGestionException;

//Console.Write("Merci de saisir un prix : ");
//int[] tab = new int[3];
//Personne p = new Personne();
//try
//{
//    decimal price = Convert.ToDecimal(Console.ReadLine());
//    Console.WriteLine(price);
//    tab[1] = 50;
//    //Console.WriteLine(p.Adresses.Count);
//}
//catch (IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Erreur d'index");
//}

//catch (FormatException ex)
//{
//    Console.WriteLine("Erreur de saisie");
//}
//catch(NullReferenceException ex)
//{
//    Console.WriteLine("Null reference");
//}finally
//{
//    Console.WriteLine("Instruction tout le temps executée") ;
//}
RecupererAgeAndPhone();

static void RecupererAgeAndPhone()
{
    Personne p = new Personne();
    bool saisie = true;

    do
    {
        Console.Write("Merci de saisir votre age : ");
        try
        {
            p.Age = Convert.ToInt32(Console.ReadLine());
            saisie = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType());
            Console.WriteLine("Merci de saisir l'age dans un format correct");
        }
    } while (saisie);
    saisie = true;
    do
    {
        Console.Write("Merci de saisir le téléphone : ");
        try
        {
            p.Telephone = Console.ReadLine();
            saisie = false;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.GetType());
        }
    } while (saisie);
    Console.WriteLine(p.Telephone);
}