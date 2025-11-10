using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class MediaNocheUseCase : IMediaNocheUseCase
    {
        private readonly IListadoMisiones _listadoMisiones;
        
        public MediaNocheUseCase(IListadoMisiones listadoMisiones)
        {
            _listadoMisiones = listadoMisiones;
        }

        public List<Mision> getMisiones()
        {
            return _listadoMisiones.getMisiones();
        }
    }
}
