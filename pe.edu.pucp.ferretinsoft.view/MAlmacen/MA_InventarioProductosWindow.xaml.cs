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

namespace pe.edu.pucp.ferretinsoft.view.MAlmacen
{
    /// <summary>
    /// Lógica de interacción para MA_InventarioProductosWindow.xaml
    /// </summary>
    public partial class MA_InventarioProductosWindow : Window
    {
        public MA_InventarioProductosWindow()
        {
            InitializeComponent();
            ProductosDatagrid.ItemsSource = ListaProductos();
        }


        private List<Producto> ListaProductos()
        {
            List<Producto> lisProd = new List<Producto>();

            Producto prod1 = new Producto();
            Producto prod2 = new Producto();

            prod1.ID = "000001";
            prod1.nombre = "cemento";
            prod1.categoria = "Construcción";
            prod1.stock = 5000;
            prod1.stockMin = 1000;
            


            prod2.ID = "000002";
            prod2.nombre = "Pintura tecno";
            prod2.categoria = "Acabado";
            prod2.stock = 10000;
            prod2.stockMin = 2000;
            

            lisProd.Add(prod1);
            lisProd.Add(prod2);

            return lisProd;

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

                
    }
}
