using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceComptesBancaires.Classes.Comptes
{
    internal class ComptePayant : CompteBancaire
    {
        public ComptePayant(Client client) : base(client)
        {
        }
    }
}
