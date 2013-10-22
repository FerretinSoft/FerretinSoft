using IBatisNet.DataMapper;
using pe.edu.pucp.ferretinsoft.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.controller.Services
{
    class CategoriasService
    {
        public static IList<Categorias> obtenerCategorias()
        {
            IList<Categorias> listaCat = Mapper.Instance().QueryForList<Categorias>("obtenerListaCategorías", null);
            return listaCat;
        }




    }
}
