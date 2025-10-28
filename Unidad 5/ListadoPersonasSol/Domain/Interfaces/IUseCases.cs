using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Persona;

namespace Domain.Interfaces
{
    public interface IUseCases
    {
        public List<Persona> GetAllPersonas();
    }
}
