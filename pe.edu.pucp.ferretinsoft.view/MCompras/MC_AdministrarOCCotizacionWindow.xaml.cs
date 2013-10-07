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
using pe.edu.pucp.ferretinsoft.view.Resources.Custom_Controls;

namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Interaction logic for MC_AdministrarOCCotizacion.xaml
    /// </summary>
    public partial class MC_AdministrarOCCotizacion : Window
    {
        public MC_AdministrarOCCotizacion()
        {
            InitializeComponent();
            var tab = ordenesCompraTab.Items[1] as TabItem;
            tab.IsEnabled = false;
        }

        private void nuevaOrdenBtn_Click(object sender, RoutedEventArgs e)
        {
            var tab = ordenesCompraTab.Items[1] as TabItem;

            MessageBoxResult result = CustomMessageBox.ShowYesNo(
                "¿Que tipo de documento desea agregar?",
                "Cotización/Órden de Compra",
                "Cotizacion",
                "Órden de Compra",
                MessageBoxImage.Question);

            if (result.Equals(MessageBoxResult.Yes))
            {
                tipoDocLbl.Content = "Cotización";
                fecValPagoLbl.Content = "Fecha de Validez";
                fecEmisioLbl.Content = "Fecha de Ingreso";
                tab.IsEnabled = true;
                ordenesCompraTab.SelectedIndex = 1;               
            }


            if (result.Equals(MessageBoxResult.No))
            {
                fecValPagoLbl.Content = "Fecha de Pago";
                fecEmisioLbl.Content = "Fecha de Emisión";
                tipoDocLbl.Content = "Órden de Compra";
                tab.IsEnabled = true;
                ordenesCompraTab.SelectedIndex = 1;             
            }
                
        }

        private void edOrdenCompraBtn_Click(object sender, RoutedEventArgs e)
        {
            ordenesCompraTab.SelectedIndex = 1;
        }

        private void nuevoProdProveedorBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AgregarProdProveedor agprodp = new MC_AgregarProdProveedor();
            agprodp.Show();
        }

        private void buscarProveedorBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow busqProv = new MC_AdministrarProveedorWindow();
            busqProv.ShowDialog();
        } 
    }
}
