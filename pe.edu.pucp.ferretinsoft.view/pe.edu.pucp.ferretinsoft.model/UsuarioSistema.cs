using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class UsuarioSistema
    {        
        public string codigo { get; set; }
        public string dni { get; set; }
        public string nombreUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string estado { get; set; }
        public Perfil perfil { get; set; }
        public string contraseña { get; set; }
    }
}
