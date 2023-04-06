using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursGestionException
{
    class Personne
    {
        private List<string> adresses;

        private int age;
        private string telephone;

        public List<string> Adresses { get => adresses; set => adresses = value; }
        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 200)
                    age = value;
                else
                    //throw new Exception("Erreur dans la valeur d'age");
                    throw new AgeException();
            }
        }

        public string Telephone
        {
            get => telephone;
            set
            {
                if (!value.StartsWith("0") || value.Length != 10)
                    throw new PhoneException();
                telephone = value;
            }
        }
    }
}
