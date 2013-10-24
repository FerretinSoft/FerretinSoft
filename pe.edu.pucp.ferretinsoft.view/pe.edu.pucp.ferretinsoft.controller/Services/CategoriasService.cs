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
        /**************************************************
         * ->Permite obtener una lista con todas las categorias 
         * de productos.
         * ************************************************/
        public static IList<Categorias> obtenerCategorias()
        {
            IList<Categorias> listaCat = Mapper.Instance().QueryForList<Categorias>("obtenerListaCategorías", null);
            return listaCat;
        }


        /**************************************************
         * ->Permite obtener una lista con todas las categorias 
         * de un producto dado.
         * Input: 
         * -idProd:Id de prod. del cual se quiere obtener las categorías
         * Output:
         * -Lista con todos las categorías que posee el prod.
         * ************************************************/
        public static IList<String> obtenerCategoríasPorProducto(int idProd)
        {
            IList<int> listaCat = Mapper.Instance().QueryForList<int>("obtenerCategoríasPorProducto", idProd);

            IList<String> nombreCat=new List<String>();
            foreach (int idCat in listaCat)
            {
                nombreCat.Add(Mapper.Instance().QueryForObject<String>("obtenerNombreCategoría", idCat));
            }
            
            return nombreCat;
        }


    }
}
