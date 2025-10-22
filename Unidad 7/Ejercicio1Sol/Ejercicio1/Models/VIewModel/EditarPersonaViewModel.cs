using Ejercicio1.Models.Entities;

namespace Ejercicio1.Models.VIewModel
{
    public class EditarPersonaViewModel
    {
        private Persona _persona;
        private List<Departamento> _departamentos;

        /// <summary>
        /// Función que inicializa el ViewModel para editar una persona en una posición concreta.
        /// </summary>
        /// <param name="posicionPersona">
        /// Posición de la persona a editar en la lista de personas.
        /// </param>
        public EditarPersonaViewModel(int posicionPersona)
        {
            this._persona = DAL.getPersonas()[posicionPersona];
            this._departamentos = DAL.getDepartamentos();
        }

        /// <summary>
        /// Función que inicializa el ViewModel para editar una persona aleatoria.
        /// </summary>
        public EditarPersonaViewModel()
        {
            Random random = new Random();
            List<Persona> personas = DAL.getPersonas();
            int posicionAleatoria = random.Next(personas.Count);
            this._persona = personas[posicionAleatoria];
            this._departamentos = DAL.getDepartamentos();
        }

        public Persona Persona
        {
            get { return this._persona; }
            set { this._persona = value; }
        }   
        public List<Departamento> Departamentos
        {
            get { return this._departamentos; }
        }
    }
}
