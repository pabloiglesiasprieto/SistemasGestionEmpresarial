using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Mision
    {
        private int _id;
        private string _name;
        private int _recompensa;
        private string _descripcion;

        public Mision(int id, string name, string descripcion, int recompensa)
        {
            _id = id;
            _name = name;
            _descripcion = descripcion;
            _recompensa = recompensa;
        }
        public Mision()
        {

        }
        public int Id { get => _id; }

        public string Name { get { return this.Name; } set { this.Name = value; } }

        public string Descripcion { get { return this.Descripcion; } set { this.Descripcion = value; } }

        public int Recompensa { get { return this.Recompensa; } set { this.Recompensa = value; } }
    }
}
