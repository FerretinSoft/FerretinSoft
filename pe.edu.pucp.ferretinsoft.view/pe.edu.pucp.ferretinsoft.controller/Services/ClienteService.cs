using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBatisNet.DataMapper;
using pe.edu.pucp.ferretinsoft.model;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services
{
    class ClienteService
    {
        public static List<Cliente> obtenerListaClientes()
        {
            List<Cliente> listaClientes = Mapper.Instance().QueryForList("obtenerListaClientes", null) as List<Cliente>;
            return listaClientes;

        }
    }
}
