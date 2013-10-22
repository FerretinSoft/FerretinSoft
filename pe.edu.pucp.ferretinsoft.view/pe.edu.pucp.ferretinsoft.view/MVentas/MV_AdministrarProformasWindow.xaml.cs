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

namespace pe.edu.pucp.ferretinsoft.view.MVentas
{
    /// <summary>
    /// Lógica de interacción para MV_AdministrarProformasWindow.xaml
    /// </summary>
    public partial class MV_AdministrarProformasWindow : Window
    {
        public MV_AdministrarProformasWindow()
        {
            InitializeComponent();
            proformasGrid.ItemsSource = ListaProformas();
        }

        private List<Proforma> ListaProformas()
        {
            Vendedor vendedor = new Vendedor
            {
                Codigo = 0000256256,
                Nombre = "José Olaya Balandra"
            };

            List<Proforma> proformas = new List<Proforma>();
           

            return proformas;
        }

        private void detalleProformaBtn_Click(object sender, RoutedEventArgs e)
        {
            ProformasTab.SelectedIndex = 1;
        }

        public void codProforma_Click(object sender, RoutedEventArgs e)
        {
             var rowData = ((Hyperlink)e.OriginalSource).DataContext as Proforma;
             codProformaTxtBox.Text = rowData.Codigo+"";
             vendedorTxtBox.Text = rowData.Vendedor.Nombre;
             codClienteTxtBox.Text = rowData.Cliente.nroDoc + "";
             nombreClienteTxtBox.Text = rowData.Cliente.nombre;
             fechaProformaTxtBox.Text = rowData.FechaProforma;
             totalProformaTxtBox.Text = "S/." + rowData.Importe;
             igvProformaTxtBox.Text = "S/." + (rowData.Importe * 0.18) + "";
             double subtotal = (rowData.Importe - rowData.Importe * 0.18);
             subTotalTxtBox.Text = "S/." + subtotal;
             ProformasTab.SelectedIndex = 1;

        }
        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            //ClientesWindow pw = new ClientesWindow();
            //pw.Show();
        }

        private void buscarVendedorBtn_Click(object sender, RoutedEventArgs e)
        {
            //PersonalAdminWindow pw = new PersonalAdminWindow();
            //pw.Show();
        }

        private void nuevaProformaBtn_Click(object sender, RoutedEventArgs e)
        {
            ProformasTab.SelectedIndex = 1;
        }

        private void registrarProformaBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cancelarBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buscarProformaBtn_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
