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

        public List<Persona> GetAllPersonas()
        {
            return _personas;
        }
    }
}
