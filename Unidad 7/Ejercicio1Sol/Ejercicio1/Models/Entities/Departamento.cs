namespace Ejercicio1.Models.Entities
{
    public class Departamento
    {
        private int _id;
        private string _nombre;
       

        public int Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public Departamento(int id, string nombre)
        {
            this._id = id;
            this._nombre = nombre;
        }
    }
}
