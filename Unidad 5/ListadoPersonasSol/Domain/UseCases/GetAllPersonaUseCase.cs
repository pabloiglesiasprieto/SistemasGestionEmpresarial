using Domain.Entities.Persona;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.UseCases
{
        public class GetAllPersonaUseCase : IUseCases
    {
            private readonly IPersonaRepository _repository;

           
            public GetAllPersonaUseCase(IPersonaRepository repository)
            {
                _repository = repository;
            }

        public List<Persona> GetAllPersonas()
        {
            return _repository.GetAllPersonas();
        }
    }
    }

