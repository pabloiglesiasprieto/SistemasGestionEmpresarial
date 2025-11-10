using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.DTOs
{
    public class ListadoWithMisionSeleccionadaDto
    {
    private List<Mision> _listadoMisiones;
        private Mision _misionSeleccionada = null;
    
    
        public ListadoWithMisionSeleccionadaDto()
        {
            _listadoMisiones = new List<Mision>();
            _misionSeleccionada = null;
        }

        public ListadoWithMisionSeleccionadaDto(List<Mision> listadoMisiones, Mision misionSeleccionada)
        {
            _listadoMisiones = listadoMisiones;
            _misionSeleccionada = misionSeleccionada;
        }



        public List<Mision> ListadoMisiones
        {
            get { return _listadoMisiones; }
            set { _listadoMisiones = value; }

        }
        public Mision MisionSeleccionada
        {
            get { return _misionSeleccionada; }
            set { _misionSeleccionada = value; }
        }
}


}
