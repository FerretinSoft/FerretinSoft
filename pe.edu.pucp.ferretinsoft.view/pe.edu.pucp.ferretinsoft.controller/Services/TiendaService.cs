using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBatisNet.DataMapper;
using pe.edu.pucp.ferretinsoft.model;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services
{
    class TiendaService
    {
        /*
         *Permite obtener todas las tiendas que se encuentran en la tabla
         *Input (Vacio)
         *Output: IList<Tienda> 
         */
        public static IList<Tienda> obtenerTiendas()
        {
            IList<Tienda> listaTiend = Mapper.Instance().QueryForList<Tienda>("obtenerListaTiendas", null);
            return listaTiend;
        }
    }
}
