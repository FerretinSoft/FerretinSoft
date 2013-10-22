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

    public class DataNuevoMovimiento
    {
        public String CodProd { get; set; }
        public String NombreProd { get; set; }
        public String CantProd { get; set; }

    }

    
    public partial class MA_MovimientosWindow : Window
    {
        public MA_MovimientosWindow()
        {
            InitializeComponent();
            MovimientoGrid.ItemsSource = listaMovimientos();
            BúsquedaMovGrid.ItemsSource = listaBusquedaMovimientos();
            NuevoMovimientoGrid.ItemsSource = listaNuevoMovimiento();
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
                                                   Hasta="Sede Jesús María",TotalProd="10", Comentario="Venta de productos"});

            return data;
        }

        public List<DataMovimiento> listaMovimientos()
        {
            List<DataMovimiento> data = new List<DataMovimiento>();
            data.Add(new DataMovimiento { NombreMov = "MOV001", Desc = "Movimiento de devolución de productos", Estado = true });
            data.Add(new DataMovimiento { NombreMov = "MOV002", Desc = "Movimiento dar de baja a producto", Estado = true });
            //data.Add(new DataMovimiento { NombreMov = "MOV003", Desc = "Movimiento de venta", Estado = true});
            //data.Add(new DataMovimiento { NombreMov = "MOV004", Desc = "Movimiento de compra", Estado = true});

            return data;
        }


        public List<DataNuevoMovimiento> listaNuevoMovimiento()
        {
            List<DataNuevoMovimiento> data = new List<DataNuevoMovimiento>();
            data.Add(new DataNuevoMovimiento { CodProd = "ABC123", NombreProd = "Focos 50W", CantProd = "100" });
            data.Add(new DataNuevoMovimiento { CodProd = "XYZ123", NombreProd = "Spray Especial", CantProd = "700" });
            data.Add(new DataNuevoMovimiento { CodProd = "RST123", NombreProd = "Brocha Mediana", CantProd = "300" });
            data.Add(new DataNuevoMovimiento { CodProd = "PPP123", NombreProd = "Caja clavo 1kg", CantProd = "100" });
            data.Add(new DataNuevoMovimiento { CodProd = "MMM123", NombreProd = "Linterna Ligth", CantProd = "200" });
            data.Add(new DataNuevoMovimiento { CodProd = "VVV123", NombreProd = "Martillo 'Fuerte'", CantProd = "50" });
            data.Add(new DataNuevoMovimiento { CodProd = "KKK123", NombreProd = "Baterías Power", CantProd = "30" });
            data.Add(new DataNuevoMovimiento { CodProd = "UUU123", NombreProd = "Taladros Boch", CantProd = "200" });
            data.Add(new DataNuevoMovimiento { CodProd = "YYY123", NombreProd = "Set desarmadores", CantProd = "100" });
            data.Add(new DataNuevoMovimiento { CodProd = "RRR123", NombreProd = "Botas lona", CantProd = "300" });

            //return null;
            return data;
        }


    }
}
