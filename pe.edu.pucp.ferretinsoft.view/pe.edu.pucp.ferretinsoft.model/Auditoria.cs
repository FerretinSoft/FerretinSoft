using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Auditoria
    {
        public string ip { get; set; }
        public string macAddress { get; set; }
        public string nombreUsuario { get; set; }
        public string perfil { get; set; }
        public string fecha { get; set; }
        public string hora { get; set; }
        public string transaccion { get; set; }        
    }
}
