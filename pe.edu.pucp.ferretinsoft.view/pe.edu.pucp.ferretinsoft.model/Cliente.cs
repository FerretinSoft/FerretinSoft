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
        public int nroDoc { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String direccion { get; set; }
        public String TipoDocumento { get; set; }
        public String TipoCliente { get; set; }
        public String TelefonoCliente { get; set; }
        public String EmailCliente { get; set; }
        public int PuntosCliente { get; set; }
        public int PuntosGanadosCliente { get; set; }
        public int PuntosUsadosCliente { get; set; }
        public String UltimaCompraCliente { get; set; }
        public int TotalComprasCliente { get; set; }
        public String RegistradoCliente { get; set; }
        public String DireccionCliente { get; set; }
    }
}
