namespace Ejercicio1.Models.Entities
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {

            this.nombre = nombre;
            this.edad = edad;
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }


        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
    }
}
