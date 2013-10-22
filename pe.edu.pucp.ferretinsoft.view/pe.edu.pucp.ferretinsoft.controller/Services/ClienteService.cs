using System;
using System.Collections;
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
        public static IList obtenerListaClientes()
        {
            IList listaClientes = Mapper.Instance().QueryForList("obtenerListaClientes", null);
            return listaClientes;
        }

        public static IList obtenerListaClientesBy(Cliente cliente)
        {
            IList listaClientes = Mapper.Instance().QueryForList("obtenerListaClientesby", cliente);
            return listaClientes;
        }
    }
}
