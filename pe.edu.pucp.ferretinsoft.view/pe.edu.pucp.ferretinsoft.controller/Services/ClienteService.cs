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
    static class ClienteService
    {
        public static FerretinDataContext db = new FerretinDataContext();

        public static IEnumerable<Cliente> clientes = null;

        public static IEnumerable<Cliente> obtenerListaClientes()
        {
            clientes = from p in db.Cliente
                   orderby p.nroDoc
                   select p;
            return clientes;
        }

        public static IEnumerable<Cliente> obtenerListaClientesBy(Cliente cliente)
        {
            if (clientes == null) obtenerListaClientes();

            return from c in clientes
                   where 
                   (      c.nroDoc!=null && c.nroDoc.Contains(cliente.nroDoc)
                       && c.nombre != null && c.nombre.Contains(cliente.nombre)
                       && c.apPaterno!=null && c.apPaterno.Contains(cliente.apPaterno)
                       && c.apMaterno!=null && c.apMaterno.Contains(cliente.apMaterno)
                       && c.tipoDocumento!=null && c.tipoDocumento.Contains(cliente.tipoDocumento) 
                    )
                   orderby c.nroDoc
                   select c;
        }

        public static void insertarCliente(Cliente cliente)
        {
            db.Cliente.InsertOnSubmit(cliente);
            db.SubmitChanges();
        }

        public static void actualizarCliente(Cliente cliente)
        {
            db.SubmitChanges();
        }
    }
}
