using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Proveedor
    {
        public string ID { get; set; }
        public string tipoProv { get; set; }
        public string codigo { get; set; }
        public string razSoc { get; set; }
        public string rubro { get; set; }
        public string domicilio { get; set; }
        public string dep { get; set; }
        public string prov { get; set; }
        public string dist { get; set; }
        public string cp { get; set; }
        public string telefono { get; set; }
        public string pagWeb { get; set; }
        public string nombContacto { get; set; }
        public string tlfContacto { get; set; }
        public List<ProductoProveedor> catalogo { get; set; }
    }
}
