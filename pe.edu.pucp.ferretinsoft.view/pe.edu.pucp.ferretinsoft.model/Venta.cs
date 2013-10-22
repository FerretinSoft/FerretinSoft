using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Venta
    {
        public int Codigo { get; set; }
        public String FechaVenta { get; set; }
        public String Importe { get; set; }
        public Cliente Cliente { get; set; }
        public Vendedor Vendedor { get; set; }
    }
}
