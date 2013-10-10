using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Devolucion
    {
        public int Codigo { get; set; }
        public Venta Venta { get; set; }
        public Cliente Cliente { get; set; }
        public String FechaDevolucion { get; set; }
        public String Importe { get; set; }
    }
}
