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

namespace pe.edu.pucp.ferretinsoft.view.MVentas
{
    /// <summary>
    /// Lógica de interacción para MV_AdministrarVentasWindow.xaml
    /// </summary>
    public partial class MV_AdministrarVentasWindow : Window
    {
        public MV_AdministrarVentasWindow()
        {
            InitializeComponent();
        }
        private void detalleVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 1;
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
    }
}
