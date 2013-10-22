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
            tiendaDg.ItemsSource = listTiendas();
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

        private List<Tienda> listTiendas()
        {

            List<Tienda> tiendas = new List<Tienda>();

            Tienda tien1 = new Tienda();
            tien1.codigo = 0001;
            tien1.nombre = "Ferretin Callao";
            tien1.direccion = "Av.Faucett 459";
            tiendas.Add(tien1);


            Tienda tien2 = new Tienda();
            tien2.codigo = 0002;
            tien2.nombre = "Ferretin Bertelo";
            tien2.direccion = "Av.Bertelo 1520 ";
            tiendas.Add(tien2);

            Tienda tien3 = new Tienda();
            tien3.codigo = 0003;
            tien3.nombre = "Ferretin Bolivar";
            tien3.direccion = "Av.Bolivar 1045 ";
            tiendas.Add(tien3);

            Tienda tien4 = new Tienda();
            tien4.codigo = 0004;
            tien4.nombre = "Ferretin San isidro";
            tien4.direccion = "Av.2 de mayo 425";
            tiendas.Add(tien4);

            return tiendas;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
