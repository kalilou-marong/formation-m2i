using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursGestionException
{
    public class PhoneException : Exception
    {
        public PhoneException():base("Erreur format téléphone")
        {

        }
    }
}
