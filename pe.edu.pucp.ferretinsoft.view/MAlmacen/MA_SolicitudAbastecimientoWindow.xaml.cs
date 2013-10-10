using pe.edu.pucp.ferretinsoft.model;
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
    /// Lógica de interacción para MA_SolicitudAbastecimientoWindow.xaml
    /// </summary>
    /// 

    public class DataDetalle
    {
        public String Codigo { get; set; }
        public String Nombre{ get; set; }
        public String Cantidad{ get; set; }
        public String Estado{ get; set; }
    }

    public partial class MA_SolicitudAbastecimientoWindow : Window
    {
        public MA_SolicitudAbastecimientoWindow()
        {
            InitializeComponent();
            gridDetalle.ItemsSource = listaSolicitudDetalle();
            gridBusqueda.ItemsSource = listaSolicitudBusqueda();
            gridGenerar.ItemsSource = listaSolicitudGenerar();
            GridAtender.ItemsSource = ListaAtenderSolicitud();
        }

        private void atenderSolBtn_Click(object sender, RoutedEventArgs e)
        {
            solicitudesTab.SelectedIndex = 3;
        }

        private void buscarSolBtn_Click(object sender, RoutedEventArgs e)
        {
            solicitudesTab.SelectedIndex = 0;
        }

        private void consolidarBtn_Click(object sender, RoutedEventArgs e)
        {
            MCompras.MC_ConsolidarSolicitudesWindow consoli = new MCompras.MC_ConsolidarSolicitudesWindow();
            consoli.Show();
        }

        private List<Producto> ListaAtenderSolicitud()
        {
            List<Producto> Listprod = new List<Producto>();

            Producto prod1 = new Producto();
            Producto prod2 = new Producto();
            Producto prod3 = new Producto();

            prod1.ID = "200001";
            prod1.nombre = "Cemento Premium ";
            prod1.cantidad = 200;
            prod1.stock = 1000;
            prod1.saldo = 1000;
            prod1.estado = "Activo";

            prod2.ID = "200002";
            prod2.nombre = "Cemento Regular";
            prod2.cantidad = 500;
            prod2.stock = 1000;
            prod2.saldo = 1000;
            prod2.estado = "Activo";

            prod3.ID = "200003";
            prod3.nombre = "Cemento Arqua";
            prod3.cantidad = 400;
            prod3.stock = 800;
            prod3.saldo = 800;
            prod3.estado = "Activo";

            Listprod.Add(prod1);
            Listprod.Add(prod2);
            Listprod.Add(prod3);

            return Listprod;


        }

        public List<SolicitudAbastecimiento> listaSolicitudBusqueda()
        {
            List<SolicitudAbastecimiento> data = new List<SolicitudAbastecimiento>();
            data.Add(new SolicitudAbastecimiento { ID="SOL01",tienda="Tienda 2",fecha="20/09/2013",estado="Atendido"});
            data.Add(new SolicitudAbastecimiento { ID="SOL02",tienda="Tienda 1",fecha="21/09/2013",estado="Atendido"});
            data.Add(new SolicitudAbastecimiento { ID="SOL03",tienda="Tienda 3",fecha="22/09/2013",estado="Atendido"});
            data.Add(new SolicitudAbastecimiento { ID="SOL04",tienda="Tienda 1",fecha="25/09/2013",estado="No Atendido"});
            data.Add(new SolicitudAbastecimiento { ID="SOL05",tienda="Tienda 2",fecha="27/09/2013",estado="No Atendido"});
            data.Add(new SolicitudAbastecimiento { ID = "SOL06", tienda = "Tienda 3", fecha = "01/10/2013", estado = "No Atendido" });

            return data;

        }


        public List<DataDetalle> listaSolicitudDetalle()
        {
            List<DataDetalle> data = new List<DataDetalle>();
            data.Add(new DataDetalle { Codigo = "ABC123", Nombre = "Cemento Premium ", Cantidad = "300", Estado = "a" });
            data.Add(new DataDetalle { Codigo = "BBB123", Nombre = "Cemento Regular", Cantidad = "300", Estado = "a" });
            data.Add(new DataDetalle { Codigo = "AAA123", Nombre = "Taladro Boch", Cantidad = "400", Estado = "a" });
            data.Add(new DataDetalle { Codigo = "PPP123", Nombre = "Inodor Trebol", Cantidad = "500", Estado = "a" });
            data.Add(new DataDetalle { Codigo = "TTT123", Nombre = "Botas de construcción", Cantidad = "200", Estado = "a" });
            data.Add(new DataDetalle { Codigo = "ZZZ123", Nombre = "Pinturas Tekno", Cantidad = "100", Estado = "a" });

            return data;

        }

        private List<ProductoAlmacen> listaSolicitudGenerar()
        {
            List<ProductoAlmacen> solicitudes = new List<ProductoAlmacen>();


        
            solicitudes.Add(new ProductoAlmacen{codigo = "200001",
            producto = "Cemento Premium ",
            cantidad = "200",
            stockactual = "150",
            stockmin = "200"});

            solicitudes.Add(new ProductoAlmacen{
            codigo = "200002",
            producto = "Cemento Regular",
            cantidad = "300",
            stockactual = "150",
            stockmin = "200"});

            solicitudes.Add(new ProductoAlmacen{
            codigo = "200003",
            producto = "Cemento Arqua",
            cantidad = "500",
            stockactual = "150",
            stockmin = "200"});


            return solicitudes;
        }


        public void idSolicitud_Click(object sender, RoutedEventArgs e)
        {
            var rowData = ((Hyperlink)e.OriginalSource).DataContext as SolicitudAbastecimiento;

            tiendaTxtBox.Text = rowData.tienda;
            estadoTxtBox.Text = rowData.estado;
        }

        private void gridDetalle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}
