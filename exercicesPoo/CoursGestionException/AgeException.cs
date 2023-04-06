using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursGestionException
{
    public class AgeException:Exception
    {
        public AgeException():base("Erreur valeur Age")
        {

        }
    }
}
