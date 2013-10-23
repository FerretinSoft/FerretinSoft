using IBatisNet.DataMapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services
{
    class UsuarioService
    {

        public static IList obtenerListaUsuarios()
        {
            IList listaUsuarios = Mapper.Instance().QueryForList("obtenerListaUsuarios", null);

            /*if (listaClientes == null)
                Console.WriteLine("es nula");
            else
            {
                Console.WriteLine(((Cliente)listaClientes[0]).Nombre);
                Console.WriteLine(((Cliente)listaClientes[1]).Nombre);
            }*/
            return listaUsuarios;

        }

    }
}
