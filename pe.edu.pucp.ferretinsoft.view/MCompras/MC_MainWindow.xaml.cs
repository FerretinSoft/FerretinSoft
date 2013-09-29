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

namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Interaction logic for MC_MainWindow.xaml
    /// </summary>
    public partial class MC_MainWindow : Window
    {
        public MC_MainWindow()
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

        private void adminProveedoresBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow MCadmp = new MC_AdministrarProveedorWindow();
            MCadmp.ShowDialog();
        }

        private void ordCompraBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarOCCotizacion MCadoc = new MC_AdministrarOCCotizacion();
            MCadoc.ShowDialog();
        }

        private void repComprasBtn_Click(object sender, RoutedEventArgs e)
        {
            //ReportesComprasWindow repW = new ReportesComprasWindow();
            //repW.ShowDialog();
        }

        private void repComprasBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            //ComprasSolicitudAbastecimiento solAbast = new ComprasSolicitudAbastecimiento();
            //solAbast.ShowDialog();
        }
    }
}
