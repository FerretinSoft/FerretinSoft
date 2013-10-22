using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Perfil
    {
        public String nombrePerfil { get; set; }
        public String modulo { get; set; }
        public String descripcion { get; set; }
        public List<String> privilegios { get; set; }
    }
}
