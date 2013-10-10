using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public String Nombre { get; set; }
        public String TipoDocumento { get; set; }
        public String TipoCliente { get; set; }
        public String TelefonoCliente { get; set; }
        public String EmailCliente { get; set; }
        public int PuntosCliente { get; set; }
    }
}
