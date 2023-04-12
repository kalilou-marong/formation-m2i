using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3.Classes
{
    internal class IHM
    {
        private string choix;

        public void Start()
        {
            do
            {
                Menu();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
                {
                    case "1":
                       ListerComptes() ;
                        break;
                    case "2":
                        CreerCompte();
                        break;
                    case "3":
                        Deposer();
                        break;
                    case "4":
                        Retirer();
                        break;
                    case "5":
                        Afficher();
                        break;
                    case "0":
                        ;
                        break;
                }
            }while (choix != "0");
        }
        private void Menu()
        {
            Console.WriteLine("1 - Lister les comptes bancaires");
            Console.WriteLine("2 - Créer un compte bancaire");
            Console.WriteLine("3 - Effectuer un dépot");
            Console.WriteLine("4 - Effectuer un retrait");
            Console.WriteLine("5 - Afficher les opérations et le solde");
            Console.WriteLine("0 - Quitter le programme");
        }
        private void ListerComptes()
        {

        }

        private void CreerCompte()
        {

        }

        private void Deposer()
        {

        }

        private void Retirer()
        {

        }

        private void Afficher()
        {

        }
    }
}
