using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class ProductoOrdenCompra
    {
        public Producto producto { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public double precUnit { get; set; }
        public double precioTotal { get; set; }
    }
}
