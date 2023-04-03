using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leSalarie.Classes
{
    internal class Salarie
    {
        private int _matricule;
        private string _service;
        private string _name;
        private string _salary;

        public Salarie(int Matricule, string Service, string Name, string Salary)
        {
            this._matricule = Matricule;
            this._service = Service;
            this._name = Name;
            this._salary = Salary;
        }

        public int Matricule { get => _matricule; set => _matricule = value; }
        public string Service { get => _service; set => _service = value; }
        public string Name { get => _name; set => _name = value; }
        public string Salary { get => _salary; set => _salary = value; }


    }
}
