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
    /// Lógica de interacción para MA_MainWindow.xaml
    /// </summary>
    public partial class MA_MainWindow : Window
    {
        public MA_MainWindow()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.OwnedWindows.Count == 0)
            {
                this.Close();
            }
        }

        private void invProdBtn_Click(object sender, RoutedEventArgs e)
        {
            /*InventarioProductosWindow pw = new InventarioProductosWindow();
            pw.Show();*/
        }

        private void prodBtn_Click(object sender, RoutedEventArgs e)
        {
            //MantenimientoProductosWindow mw = new MantenimientoProductosWindow();
            //mw.Show();
        }

        private void movBtn_Click(object sender, RoutedEventArgs e)
        {
            //MovimientosWindow mw = new MovimientosWindow();
            //mw.Show();
        }
    }
}
