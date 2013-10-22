using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Auditoria
    {
        public String ip { get; set; }
        public String macAddress { get; set; }
        public String nombreUsuario { get; set; }
        public String perfil { get; set; }
        public DateTime fecha { get; set; }
        public DateTime hora { get; set; }
        public String transaccion { get; set; }        
    }
}
