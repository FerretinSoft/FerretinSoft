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
           
            /*if (listaClientes == null)
                Console.WriteLine("es nula");
            else
            {
                Console.WriteLine(((Cliente)listaClientes[0]).Nombre);
                Console.WriteLine(((Cliente)listaClientes[1]).Nombre);
            }*/
            return listaClientes;

        }
    }
}
