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
    public partial class MA_SolicitudAbastecimientoWindow : Window
    {
        public MA_SolicitudAbastecimientoWindow()
        {
            InitializeComponent();
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

        private List<SolicitudAbastecimiento> ListSolicitud()
        {
            List<SolicitudAbastecimiento> solicitudes = new List<SolicitudAbastecimiento>();

            SolicitudAbastecimiento sol1 = new SolicitudAbastecimiento();
            SolicitudAbastecimiento sol2 = new SolicitudAbastecimiento();
            SolicitudAbastecimiento sol3 = new SolicitudAbastecimiento();



            ProductoAlmacen prod1 = new ProductoAlmacen();
            prod1.codigo = "200001";
            prod1.producto = "Cemento Premium ";
            prod1.cantidad = "200";
            prod1.stockactual = "150";
            prod1.stockmin = "200";
            ProductoAlmacen prod2 = new ProductoAlmacen();
            prod2.codigo = "200002";
            prod2.producto = "Cemento Regular";
            prod2.cantidad = "300";
            prod2.stockactual = "150";
            prod2.stockmin = "200";
            ProductoAlmacen prod3 = new ProductoAlmacen();
            prod3.codigo = "200003";
            prod3.producto = "Cemento Ladrillo";
            prod3.cantidad = "500";
            prod3.stockactual = "150";
            prod3.stockmin = "200";




            sol1.tienda = "Tienda 1";
            sol2.tienda = "Tienda 2";
            sol3.tienda = "Tienda 3";

            return solicitudes;



        }


        public void idSolicitud_Click(object sender, RoutedEventArgs e)
        {
            var rowData = ((Hyperlink)e.OriginalSource).DataContext as SolicitudAbastecimiento;

            tiendaTxtBox.Text = rowData.tienda;
            estadoTxtBox.Text = rowData.estado;
        }


    }
}
