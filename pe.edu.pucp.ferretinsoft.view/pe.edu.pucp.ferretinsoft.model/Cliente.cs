using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Cliente
    {
        public int codigo { get; set; }
        public int nroDoc { get; set; }
        public String nombre { get; set; }
        public String apellidoPaterno { get; set; }
        public String apellidoMaterno { get; set; }
        public String tipoDocumento { get; set; }
        public String tipoCliente { get; set; }
        public String telefonoCliente { get; set; }
        public String emailCliente { get; set; }
        public int puntosCliente { get; set; }
        public int puntosGanadosCliente { get; set; }
        public int puntosUsadosCliente { get; set; }
        public String ultimaCompraCliente { get; set; }
        public int totalComprasCliente { get; set; }
        public String registradoCliente { get; set; }
        public String direccionCliente { get; set; }
    }
}
