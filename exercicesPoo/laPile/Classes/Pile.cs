using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laPile.Classes
{
    internal class Pile
    {
        private List<string> tableau;

        public List<string> Tableau  { get => tableau; set => tableau = value; }

        public void empiler ()
        {
            Tableau.Add();
        }

    }
}
