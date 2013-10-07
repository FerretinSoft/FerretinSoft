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
using Microsoft.Win32;


namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Lógica de interacción para MC_AdministrarProveedorWindow.xaml
    /// </summary>
    public partial class MC_AdministrarProveedorWindow : Window
    {
        public MC_AdministrarProveedorWindow()
        {
            InitializeComponent();
        }

        private void importarProducto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dirDialog = new OpenFileDialog();
            dirDialog.ShowDialog();
        }

        private void nuevoProveedorBtn_Click(object sender, RoutedEventArgs e)
        {
            proveedorTab.SelectedIndex = 1;
        }

        private void nuevoProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AgregarProdCatalogoWindow prdCat = new MC_AgregarProdCatalogoWindow();
            prdCat.Owner = this;
            prdCat.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            proveedorTab.SelectedIndex = 0;
        }
    }
}
