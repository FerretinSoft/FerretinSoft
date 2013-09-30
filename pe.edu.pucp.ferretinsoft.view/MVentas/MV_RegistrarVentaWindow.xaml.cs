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
    /// Lógica de interacción para MV_RegistrarVentaWindow.xaml
    /// </summary>
    public partial class MV_RegistrarVentaWindow : Window
    {
        public MV_RegistrarVentaWindow()
        {
            InitializeComponent();
        }

        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            //ClientesWindow cw = new ClientesWindow();
            //cw.clientesTab.SelectedIndex = 0;
            //cw.Show();
        }

        private void pagarBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_PagoWindow pw = new MV_PagoWindow();
            pw.Owner = this;
            pw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
