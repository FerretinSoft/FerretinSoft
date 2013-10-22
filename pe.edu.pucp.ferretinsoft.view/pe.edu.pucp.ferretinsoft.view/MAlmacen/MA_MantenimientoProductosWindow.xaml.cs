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

namespace pe.edu.pucp.ferretinsoft.view.MAlmacen
{
    /// <summary>
    /// Lógica de interacción para MA_MantenimientoProductosWindow.xaml
    /// </summary>
    /// 
    public class DataMantenimientoProductos
    {
        public String CodProd { get; set; }
        public String NombreProd { get; set; }
        public String Cat { get; set; }
        public Boolean Estado { get; set; }
    }

    public partial class MA_MantenimientoProductosWindow : Window
    {
        public MA_MantenimientoProductosWindow()
        {
            InitializeComponent();
            gridProductos.ItemsSource = listaProductos();
        }

        public List<DataMantenimientoProductos> listaProductos()
        {
            List<DataMantenimientoProductos> data = new List<DataMantenimientoProductos>();
            data.Add(new DataMantenimientoProductos { CodProd = "ABC123", NombreProd = "Sanitarios Trébol", Cat = "Sanitarios", Estado = true });
            data.Add(new DataMantenimientoProductos { CodProd = "PQR123", NombreProd = "Lámpara", Cat = "Dormitorios", Estado = true });
            data.Add(new DataMantenimientoProductos { CodProd = "XYZ999", NombreProd = "Ducha Térmica", Cat = "Duchas", Estado = true });
            data.Add(new DataMantenimientoProductos { CodProd = "QWE555", NombreProd = "Fertilizante", Cat = "Jardín", Estado = true });

            return data;
        }

        private void nuevoProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            mantenimientoTab.SelectedIndex = 1;
        }

        private void editarProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            mantenimientoTab.SelectedIndex = 1;
        }

        
                

        
    }
}
