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
        public static IList<Tienda> obtenerTiendas()
        {
            IList<Tienda> listaTiend = Mapper.Instance().QueryForList<Tienda>("obtenerListaTiendas", null);
            return listaTiend;
        }
    }
}
