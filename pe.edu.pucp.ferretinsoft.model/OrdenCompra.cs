using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class OrdenCompra
    {
        public string codigo { get; set; }
        public Proveedor proveedor { get; set; }
        public string fecEmision { get; set; }
        public string fecPago { get; set; }
        public List<ProductoOrdenCompra> productos{ get; set; }
        public string aprobadoPor { get; set; }
        public string emitidoPor { get; set; }
        public string ultimaCompra { get; set; }
        public double subTotal { get; set; }
        public double igv { get; set; }
        public double total { get; set; }
        public string estado { get; set; }
    }
}
