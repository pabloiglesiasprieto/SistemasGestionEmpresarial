using Domain.Entities.Persona;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class PersonaRepositoryEmpty : IPersonaRepository
    {   

        private List<Persona> _personas = [];

        /// <summary>
        /// Método de la interfaz para obtener todas las personas.
        /// </summary>
        /// <returns>Devuelve todas las personas.</returns>
        public List<Persona> GetAllPersonas()
        {
            return _personas;
        }
    }
}
