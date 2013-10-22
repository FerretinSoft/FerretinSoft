using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Tienda
    {
        public int codigo { get; set; }
        public String nombre { get; set; }
        public String tipo { get; set; }
        public int codigoAlmacenAbastecedor { get; set; }        
        public String direccion { get; set; }
        public String distrito { get; set; }
        public String codigoPostal { get; set; }
        public String provincia { get; set; }
        public String pais { get; set; }
        public String telefono1 { get; set; }
        public String telefono2 { get; set; }
        public String idUbigeo { get; set; }
        public String descripcion { get; set; }
        public String fechaCreacion { get; set; }
        public Cliente idCliente { get; set; }

    }
}
