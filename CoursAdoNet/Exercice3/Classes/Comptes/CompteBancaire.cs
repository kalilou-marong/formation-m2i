using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceComptesBancaires.Classes.Comptes
{
    internal abstract class CompteBancaire
    {
        private decimal _solde = 0;
        private List<Operation> _operations = new List<Operation>();

        public decimal Solde { get => _solde; }
        public List<Operation> Operations { get => _operations; }
        public Client Client { get; set; }

        public CompteBancaire(Client client)
        {
            Client = client;
        }
        public CompteBancaire(Client client, decimal soldeDepart)
        {
            Client = client;
            // ajouter une operation
            _solde = soldeDepart;
        }

        public bool Depot(decimal montant)
        {
            if (montant <= 0)
                return false;
            Operation operation = new Operation(_operations.Count + 1, montant, StatutOperation.Depot);
            _operations.Add(operation);
            _solde += montant;
            return true;
        }

        public bool Retrait(decimal montant)
        {
            if (montant <= 0 || Solde < montant)
                return false;
            Operation operation = new Operation(_operations.Count + 1, montant, StatutOperation.Retrait);
            _operations.Add(operation);
            _solde -= montant;
            return true;

        }

        public override string ToString()
        {
            string chaine = $"Compte Bancaire: Type: {base.GetType().Name} Solde = {Solde} Client = {Client}";
            // base.GetType().Name sert à récupérer le type de l'objet, le "base." est facultatif car GetType() est hérité de object
            foreach (Operation operation in _operations)
            {
                chaine += "\n\t-" + operation; // le .ToString() est facultatif lorsque l'on essaie de concaténer 
            }

            return chaine;
        }
    }
}
