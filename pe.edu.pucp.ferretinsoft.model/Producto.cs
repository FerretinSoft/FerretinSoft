using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Producto
    {
        public string ID { set; get; }
        public string nombre { set; get; }
        public string categoria { set; get; }
        public int stock { set; get; }
        public int stockMin { set; get; }
        public string almacen { set; get; }
    }
}
