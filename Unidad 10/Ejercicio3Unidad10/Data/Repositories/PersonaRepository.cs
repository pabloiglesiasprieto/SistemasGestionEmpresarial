using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Persona;
using Domain.Interfaces;

namespace Data.Repositories
{

    public class PersonaRepository : IPersonaRepository

    {
        private List<Persona> _personas =
        [
        new Persona(1, "Juan", "Perez"),
        new Persona(2, "Maria", "Gomez"),
        new Persona(3, "Carlos", "Lopez"),
        new Persona(4, "Ana", "Martinez"),
        new Persona(5, "Luis", "Garcia"),
        new Persona(6, "Laura", "Fernandez"),
        new Persona(7, "Andres", "Torres"),
        new Persona(8, "Carmen", "Diaz"),
        new Persona(9, "Jorge", "Ramirez"),
        new Persona(10, "Sofia", "Ruiz"),
        new Persona(11, "Pedro", "Sanchez"),
        new Persona(12, "Lucia", "Mendoza"),
        new Persona(13, "Fernando", "Silva"),
        new Persona(14, "Patricia", "Morales"),
        new Persona(15, "Diego", "Castro"),
        new Persona(16, "Valentina", "Rojas"),
        new Persona(17, "Ricardo", "Vargas"),
        new Persona(18, "Gabriela", "Ortega"),
        new Persona(19, "Hector", "Jimenez"),
        new Persona(20, "Natalia", "Cruz")];
        
        /// <summary>
        /// Método que devuelve una lista de 20 personas.
        /// </summary>
        /// <returns>Lista de 20 personas.</returns>
      public List<Persona> GetAllPersonas()
        {
            return _personas;
        }
    }
}

