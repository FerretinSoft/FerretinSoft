using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class ProductoAlmacen
    {
        public string codigo { get; set; }
        public string producto { get; set; }
        public string cantidad { get; set; }
        public string stockactual { get; set; }
        public string stockmin { get; set; }
        public string estado { get; set; }
    }
}
