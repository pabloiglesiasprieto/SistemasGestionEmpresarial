using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Persona;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz que define los casos de uso relacionados con Persona.
    /// </summary>
    public interface IUseCases
    {
        /// <summary>
        /// Devuelve una lista de todas las personas.
        /// </summary>
        /// <returns></returns>
        public List<Persona> GetAllPersonas();
    }
}