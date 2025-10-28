using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persona
{
    public class Persona
    {
        private int _id;
        private String _nombre;
        private String _apellido;



        public Persona(int id, String nombre, String apellido)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
        }

        public Persona() { }


        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
    }
}
