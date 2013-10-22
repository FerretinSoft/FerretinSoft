using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Producto
    {
        public int ID { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        public List<Categorias> categorias { set; get; }
        public double precioLista { set; get; }
        public int id_material_base { set; get; }
        public int id_material_sec { set; get; }
        public int id_unidad_medida { set; get; }
        public int estado { set; get; }
    }
}
