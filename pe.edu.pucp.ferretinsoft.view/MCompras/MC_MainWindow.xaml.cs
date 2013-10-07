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
        private static MC_MainWindow INSTANCE;

        public static MC_MainWindow instance  
        {
            get
            {
                if (INSTANCE == null)
                {
                    INSTANCE = new MC_MainWindow();
                }
                return INSTANCE;
            }
        }

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

        private void ventasBtn_Click(object sender, RoutedEventArgs e)
        {
             MC_MainWindow MCWindow = MC_MainWindow.instance;
             MCWindow.Show();
             MCWindow.Focus();
        }

        private void adminProveedoresBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow MCadmp = new MC_AdministrarProveedorWindow();
            MCadmp.ShowDialog();
        }

        private void ordCompraBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarOCCotizacion MCadmOC = new MC_AdministrarOCCotizacion();
            MCadmOC.ShowDialog();
        }

        private void repComprasBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_Reportes MCrep = new MC_Reportes();
            MCrep.ShowDialog();
        }

        private void solicitudAbastBtn_Click(object sender, RoutedEventArgs e)
        {
            MAlmacen.MA_SolicitudAbastecimientoWindow solabas= new  MAlmacen.MA_SolicitudAbastecimientoWindow();
            solabas.ShowDialog();
        }

        private void MCWindow_Closed(object sender, EventArgs e)
        {
            INSTANCE = null;
        }
    }
}
