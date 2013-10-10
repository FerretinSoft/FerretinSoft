using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pe.edu.pucp.ferretinsoft.view.MAlmacen
{
    /// <summary>
    /// Lógica de interacción para MA_MovimientosWindow.xaml
    /// </summary>
    /// 

    public class DataMovimiento
    {
        public String NombreMov{get;set;}
        public String Desc { get; set; }
        public Boolean Estado { get; set; }

    }

    public class DataBusquedaMovimiento
    {
        public String Fecha{get;set;}
        public String TipoMov{get;set;}
        public String Desde{get;set;}
        public String Hasta{get;set;}
        public String TotalProd{get;set;}
        public String Comentario{get;set;}
    }

    
    public partial class MA_MovimientosWindow : Window
    {
        public MA_MovimientosWindow()
        {
            InitializeComponent();
            MovimientoGrid.ItemsSource = listaMovimientos();
            BúsquedaMovGrid.ItemsSource = listaBusquedaMovimientos();
        }

        public List<DataBusquedaMovimiento> listaBusquedaMovimientos()
        {
            List<DataBusquedaMovimiento> data = new List<DataBusquedaMovimiento>();
            data.Add(new DataBusquedaMovimiento { Fecha = "01/10/2013", TipoMov = "Entrada - Despacho", Desde="Almacén Central",
                                                   Hasta="Sede San Miguel",TotalProd="200", Comentario="Envío mensual de productos"});
            
            data.Add(new DataBusquedaMovimiento { Fecha = "01/10/2013", TipoMov = "Salida - Despacho", Desde="Almacén Central",
                                                   Hasta="Sede San Miguel",TotalProd="200", Comentario="Envío mensual de productos"});

            data.Add(new DataBusquedaMovimiento { Fecha = "27/09/2013", TipoMov = "Entrada - Despacho", Desde="Almacén Central",
                                                   Hasta="Sede San Borja",TotalProd="400", Comentario="Envío mensual de productos"});
            
            data.Add(new DataBusquedaMovimiento { Fecha = "27/09/2013", TipoMov = "Salida - Despacho", Desde="Almacén Central",
                                                   Hasta="Sede San Borja",TotalProd="400", Comentario="Envío mensual de productos"});
            
            data.Add(new DataBusquedaMovimiento { Fecha = "20/09/2013", TipoMov = "Salida - Venta", Desde="Sede Jesús María",
                                                   Hasta="",TotalProd="10", Comentario="Venta de productos"});

            return data;
        }

        public List<DataMovimiento> listaMovimientos()
        {
            List<DataMovimiento> data = new List<DataMovimiento>();
            data.Add(new DataMovimiento { NombreMov = "MOV001", Desc = "Movimiento de devolución de productos", Estado = true});
            //data.Add(new DataMovimiento { NombreMov = "MOV002", Desc = "Movimiento de salida de almacén", Estado = true});
            //data.Add(new DataMovimiento { NombreMov = "MOV003", Desc = "Movimiento de venta", Estado = true});
            //data.Add(new DataMovimiento { NombreMov = "MOV004", Desc = "Movimiento de compra", Estado = true});

            return data;
        }


    }
}
