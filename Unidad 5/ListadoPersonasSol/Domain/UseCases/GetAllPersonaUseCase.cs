using Domain.Entities.Persona;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.UseCases
{
    /// <summary>
    /// Caso de uso para obtener todas las personas.
    /// </summary>
    public class GetAllPersonaUseCase : IUseCases
    {
            private readonly IPersonaRepository _repository;

        /// <summary>
        /// Método constructor del caso de uso.
        /// </summary>
        /// <param name="repository">Interfaz que implementará</param>
        public GetAllPersonaUseCase(IPersonaRepository repository)
            {
                _repository = repository;
            }

        /// <summary>
        /// Devuelve todas las personas.
        /// </summary>
        /// <returns>Lista de personas.</returns>
        public List<Persona> GetAllPersonas()
        {
            return _repository.GetAllPersonas();
        }
    }
    }

