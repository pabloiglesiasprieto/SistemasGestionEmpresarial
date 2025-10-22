namespace Ejercicio1.Models.Entities
{
    /// <summary>
    /// Clase que representa un departamento.
    /// </summary>
    public class Departamento
    {
        private int _id;
        private string _nombre;


        /// <summary>
        /// Constructor del departamento.
        /// </summary>
        /// <param name="id">Id del departamento</param>
        /// <param name="nombre">Nombre del departamento</param>
        public Departamento(int id, string nombre)
        {
            this._id = id;
            this._nombre = nombre;
        }

        /// <summary>
        /// Getter y setter del Id del departamento.
        /// </summary>
        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        /// <summary>
        /// Getter y setter del nombre del departamento.
        /// </summary>
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

       
    }
}
