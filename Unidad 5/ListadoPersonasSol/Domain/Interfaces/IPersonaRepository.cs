using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Persona;

namespace Domain.Interfaces
{
    /// <summary>
    /// Interfaz que define los métodos del repositorio de Persona.
    /// </summary>
    public interface IPersonaRepository
    {
        /// <summary>
        /// Método que devuelve una lista de todas las personas.
        /// </summary>
        /// <returns></returns>
        public List<Persona> GetAllPersonas();
    }
}