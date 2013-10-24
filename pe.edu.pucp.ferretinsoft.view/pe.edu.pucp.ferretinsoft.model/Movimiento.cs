using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.model
{
    class Movimiento
    {
        public DateTime Fecha { get; set; }

        public String Comentario { get; set; }

        public TipoMovimiento tipoMovimiento { get; set; }

        public EstadoMovimiento estado { get; set; }
    }
}
