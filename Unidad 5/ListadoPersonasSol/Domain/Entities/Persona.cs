using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Persona
{
    /// <summary>
    /// Persona entity class.
    /// </summary>
    public class Persona
    {
        private int _id;
        private String _nombre;
        private String _apellido;



        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="id">Id de la persona.</param>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="apellido">Apellido de la persona.</param>
        public Persona(int id, String nombre, String apellido)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
        }

        /// <summary>
        /// Constructor por defecto de la clase Persona.
        /// </summary>
        public Persona() { }

        /// <summary>
        /// Getter del id.
        /// </summary>
        public int Id
        {
            get;set;
        }

        /// <summary>
        /// Getter y Setter del nombre.
        /// </summary>
        public string Nombre
        {
            get; set;
        }

        /// <summary>
        /// Getter y Setter del apellido.
        /// </summary>
        public string Apellidos
        {
            get; set;
        }

        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public int Edad { get; set; }

        public DateTime FechaNac { get; set; }
    }
}
