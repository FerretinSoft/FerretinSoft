using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.model
{
    public enum CategoriaMovimiento {Entrada, Salida};
    class TipoMovimiento
    {

        public String Nombre { get; set; }

        public String Descripcion { get; set; }

        public CategoriaMovimiento Categoria {get; set;}

        public Estado Estado { get; set; }

    }
}
