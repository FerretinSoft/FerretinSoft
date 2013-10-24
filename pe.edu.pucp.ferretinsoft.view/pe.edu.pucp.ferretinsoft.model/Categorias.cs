using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Categorias
    {
        public int ID { set; get; }
        public string nombre { set; get; }
        public string descripcion { set; get; }
        //public int nivel { set; get; }
        public int id_padre { set; get; }
    }
}
