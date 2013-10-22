using IBatisNet.DataMapper;
using pe.edu.pucp.ferretinsoft.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services
{
    class ProductoService
    {
        public static IList<Producto> obtenerListaProductos()
        {
            IList<Producto> listaProd= Mapper.Instance().QueryForList<Producto>("obtenerListaProductos", null);
            return listaProd;
        }

        public static IList<Producto> obtenerProductoPorNombre(Producto p)
        {
            IList<Producto> listaProd = Mapper.Instance().QueryForList<Producto>("obtenerProductoPorNombre", p);
            return listaProd;
        }

    }
}
