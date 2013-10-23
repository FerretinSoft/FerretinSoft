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
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;

namespace pe.edu.pucp.ferretinsoft.view.MSeguridad
{
    /// <summary>
    /// Interaction logic for MS_AdministrarTiendas.xaml
    /// </summary>
    public partial class MS_AdministrarTiendas : Window
    {
        public MS_AdministrarTiendas()
        {
            InitializeComponent();
            tiendaDg.ItemsSource = TiendaService.obtenerTiendas();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nuevaTiendaBtn_Click(object sender, RoutedEventArgs e)
        {
            tiendaTab.SelectedIndex = 1;            
        }

        private void edTiendaBtn_Click(object sender, RoutedEventArgs e)
        {
            tiendaTab.SelectedIndex = 1;
        }

       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
