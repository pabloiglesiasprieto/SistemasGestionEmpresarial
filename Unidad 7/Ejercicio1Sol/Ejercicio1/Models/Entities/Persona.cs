namespace Ejercicio1.Models.Entities
{
    /// <summary>
    /// Clase que representa una persona.
    /// </summary>
    public class Persona
    {
        private string nombre;
        private int edad;
        private int idDepartamento;

        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre">Nombre de la persona.</param>
        /// <param name="edad">Edad de la persona.</param>
        public Persona(string nombre, int edad)
        {

            this.nombre = nombre;
            this.edad = edad;
        }

        /// <summary>
        /// Getter y setter de la persona.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }


        }
        /// <summary>
        /// Getter y setter de la edad.
        /// </summary>
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        /// <summary>
        /// Getter y setter del departamento.
        /// </summary>
        public int IdDepartamento
        {
            get { return this.idDepartamento; }
            set { this.idDepartamento = value; }
        }
    }
}
