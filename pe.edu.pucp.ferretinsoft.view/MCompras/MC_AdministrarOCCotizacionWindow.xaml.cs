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
using pe.edu.pucp.ferretinsoft.model;
using pe.edu.pucp.ferretinsoft.view.Resources.Custom_Controls;

namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Interaction logic for MC_AdministrarOCCotizacion.xaml
    /// </summary>
    public partial class MC_AdministrarOCCotizacion : Window
    {
        public static List<OrdenCompra> ordenesCompra = ListOrdenCompra();

        public MC_AdministrarOCCotizacion()
        {
            InitializeComponent();
            ordenesDgv.ItemsSource = ordenesCompra;
        }

        
        private void nuevaOrdenBtn_Click(object sender, RoutedEventArgs e)
        {
            
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
                facturaGbox.Visibility = System.Windows.Visibility.Hidden;
                facturaLbl.Visibility = System.Windows.Visibility.Hidden;
                facturaTxtBox.Visibility = System.Windows.Visibility.Hidden;
                ordenesCompraTab.SelectedIndex = 1;               
            }


            if (result.Equals(MessageBoxResult.No))
            {
                fecValPagoLbl.Content = "Fecha de Pago";
                fecEmisioLbl.Content = "Fecha de Emisión";
                tipoDocLbl.Content = "Órden de Compra";
                facturaGbox.Visibility = System.Windows.Visibility.Hidden;
                facturaLbl.Visibility = System.Windows.Visibility.Hidden;
                facturaTxtBox.Visibility = System.Windows.Visibility.Hidden;
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
            agprodp.Owner = this;
            agprodp.ShowDialog();
        }

        private void buscarProveedorBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow busqProv = new MC_AdministrarProveedorWindow();
            busqProv.Owner = this;
            busqProv.ShowDialog();
        }

        private void cancelarBtn_Click(object sender, RoutedEventArgs e)
        {
            ordenesCompraTab.SelectedIndex = 0;
        }

        private void buscarProveedorBtn2_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow busqProv = new MC_AdministrarProveedorWindow();
            busqProv.Owner = this;
            busqProv.ShowDialog();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private static List<OrdenCompra> ListOrdenCompra()
        {
            List<OrdenCompra> ordenesCompra = new List<OrdenCompra>();

            OrdenCompra oc1 = new OrdenCompra();
            oc1.codigo = "OC001";
            oc1.proveedor = MC_AdministrarProveedorWindow.proveedores[0];
            oc1.fecEmision = "04/10/2013";
            oc1.fecPago = "12/10/2013";
            oc1.aprobadoPor = "Jerry Rivera";
            oc1.emitidoPor = "Carolina Suarez";
            oc1.ultimaCompra = "15/05/2013";
            oc1.subTotal = 1500.50;
            oc1.igv = 285.10;
            oc1.total = 1785.6;
            oc1.estado = "Con Factura";
            oc1.tipo = "Orden de Compra";

            ordenesCompra.Add(oc1);

            OrdenCompra oc2 = new OrdenCompra();
            oc2.codigo = "OC002";
            oc2.proveedor = MC_AdministrarProveedorWindow.proveedores[1];
            oc2.fecEmision = "15/08/2013";
            oc2.fecPago = "";
            oc2.aprobadoPor = "Jerry Rivera";
            oc2.emitidoPor = "Carolina Suarez";
            oc2.ultimaCompra = "01/11/2012";
            oc2.subTotal = 2500;
            oc2.igv = 475;
            oc2.total = 2975;
            oc2.estado = "Aprobada";
            oc2.tipo = "Orden de Compra";

            ordenesCompra.Add(oc2);


            return ordenesCompra;
        }

        public void codOrden_Click(object sender, RoutedEventArgs e)
        {
            var rowData = ((Hyperlink)e.OriginalSource).DataContext as OrdenCompra;

            codOrdenTxtBox.Text = rowData.codigo;
            proveedorTxtBox.Text = rowData.proveedor.razSoc;
            fecEmiDp.Text = rowData.fecEmision;
            fecPagoDp.Text = rowData.fecPago;
            ingresadoPorTxtBox.Text = rowData.emitidoPor;
            aprobadoPorTxtBox.Text = rowData.aprobadoPor;
            razSoc_Lbl.Content = rowData.proveedor.razSoc;
            direcLbl.Content = rowData.proveedor.domicilio;
            contactoLbl.Content = rowData.proveedor.nombContacto;
            contactoTlfLbl.Content = rowData.proveedor.tlfContacto;
            ultCompraTxtBox.Text = rowData.ultimaCompra;
            subTotalTxtBox.Text = rowData.subTotal.ToString();
            igvTxtBox.Text = rowData.igv.ToString();
            totalTxtBox.Text = rowData.total.ToString();

            ordenesCompraTab.SelectedIndex = 1;

            if (rowData.tipo.Equals("Orden de Compra"))
            {
                fecValPagoLbl.Content = "Fecha de Pago";
                fecEmisioLbl.Content = "Fecha de Emisión";
                tipoDocLbl.Content = "Órden de Compra";
            }

            if (rowData.tipo.Equals("Cotizacion"))
            {
                tipoDocLbl.Content = "Cotización";
                fecValPagoLbl.Content = "Fecha de Validez";
                fecEmisioLbl.Content = "Fecha de Ingreso";
            }

            if (rowData.estado.Equals("Con Factura"))
            {
                codOrdenTxtBox.IsEnabled = false;
                proveedorTxtBox.IsEnabled = false;
                fecEmiDp.IsEnabled = false;
                fecPagoDp.IsEnabled = false;
                guardarBtn.IsEnabled = false;
                ultCompraTxtBox.IsEnabled = false;
                facturaGbox.Visibility = System.Windows.Visibility.Visible;
                facturaLbl.Visibility = System.Windows.Visibility.Visible;
                facturaTxtBox.Visibility = System.Windows.Visibility.Visible;
                facturaTxtBox.Text = "0113254";
                facturaTxtBox.IsEnabled = false;
  
            }

            if (rowData.estado.Equals("Aprobada"))
            {
                codOrdenTxtBox.IsEnabled = false;
                proveedorTxtBox.IsEnabled = false;
                fecEmiDp.IsEnabled = false;
                fecPagoDp.IsEnabled = true;
                guardarBtn.IsEnabled = true;
                ultCompraTxtBox.IsEnabled = false;
                facturaGbox.Visibility = System.Windows.Visibility.Visible;
                facturaLbl.Visibility = System.Windows.Visibility.Visible;
                facturaTxtBox.Visibility = System.Windows.Visibility.Visible;
                facturaTxtBox.Text = "";
                facturaTxtBox.IsEnabled = true;
            }
        }
    }
}
