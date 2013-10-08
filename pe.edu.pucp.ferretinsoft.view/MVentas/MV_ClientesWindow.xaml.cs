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
    /// Lógica de interacción para MV_ClientesWindow.xaml
    /// </summary>
    public partial class MV_ClientesWindow : Window
    {
        
        public MV_ClientesWindow()
        {
            InitializeComponent();
            seleccionarListaPanel.Visibility = System.Windows.Visibility.Collapsed;
            seleccionarDetallePanel.Visibility = System.Windows.Visibility.Collapsed;
        }

        public MV_ClientesWindow(MV_AdministrarVentasWindow MV_AdministrarVentasWindow)
        {
            InitializeComponent();
            seleccionarListaPanel.Visibility = System.Windows.Visibility.Visible;
            seleccionarDetallePanel.Visibility = System.Windows.Visibility.Visible;
            edicionTab.Visibility = System.Windows.Visibility.Collapsed;
            nuevoTab.Visibility = System.Windows.Visibility.Collapsed;
            seleccionarListaClienteBtn.Click += MV_AdministrarVentasWindow.seleccionarCliente;
            Show();
        }

        private void nuevoClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 1;
        }

        private void edClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 0;
        }

        private void cancelarListaClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
