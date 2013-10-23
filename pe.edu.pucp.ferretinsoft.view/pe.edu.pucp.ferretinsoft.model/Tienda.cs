using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.model
{
    public class Tienda
    {
        public String codigo { get; set; }
        public String nombre { get; set; }
        public String tipo { get; set; }
        public int codigoAlmacenAbastecedor { get; set; }        
        public String direccion { get; set; }
        public String distrito { get; set; }
        public String codigoPostal { get; set; }
        public String provincia { get; set; }
        public String pais { get; set; }
        public String telefono1 { get; set; }
        public String telefono2 { get; set; }
        public String idUbigeo { get; set; }
        public String descripcion { get; set; }
        public String fechaCreacion { get; set; }
        public String fechaCierre { get; set; }
        public Cliente idCliente { get; set; }
        public String horaIniLunes { get; set; }
        public String horaFinLunes { get; set; }
        public String horaIniMartes { get; set; }
        public String horaFinMartes { get; set; }
        public String horaIniMiercoles { get; set; }
        public String horaFinMiercoles { get; set; }
        public String horaIniJueves { get; set; }
        public String horaFinJueves { get; set; }
        public String horaIniViernes { get; set; }
        public String horaFinViernes { get; set; }
        public String horaIniSabado { get; set; }
        public String horaFinSabado { get; set; }
        public String horaIniDomingo { get; set; }
        public String horaFinDomingo { get; set; }
    }
}
