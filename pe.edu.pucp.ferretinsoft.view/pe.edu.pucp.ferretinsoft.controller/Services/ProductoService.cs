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
        public static List<Producto> obtenerListaProductos()
        {
            IList listaProd= Mapper.Instance().QueryForList("obtenerListaProductos", null);
            //Console.WriteLine(listaProd[0].nombre);
            return null;
        }

    }
}
