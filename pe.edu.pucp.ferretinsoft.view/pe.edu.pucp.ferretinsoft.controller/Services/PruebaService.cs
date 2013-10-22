using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using IBatisNet.Common.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pe.edu.pucp.ferretinsoft.controller.Services
{
    public class PruebaService
    {
        public static void getWelcome()
        {
            String val=Convert.ToString(Mapper.Instance().QueryForObject("msgPrueba", null));
            Console.WriteLine("Exito: " + val);
        }
    }
}
