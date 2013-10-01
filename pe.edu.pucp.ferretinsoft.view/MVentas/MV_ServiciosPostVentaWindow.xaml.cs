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
    /// Lógica de interacción para MV_ServiciosPostVentaWindow.xaml
    /// </summary>
    public partial class MV_ServiciosPostVentaWindow : Window
    {
        public MV_ServiciosPostVentaWindow()
        {
            InitializeComponent();
        }
        private void anularVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_AdministrarVentasWindow pw = new MV_AdministrarVentasWindow();
            pw.Show();
        }

        private void administrarDevolucionBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_DevolucionesWindow pw = new MV_DevolucionesWindow();
            pw.Show();
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.OwnedWindows.Count == 0) //si no tiene ninguna ventana hija 
            {
                this.Close();
            }
        }

        private void administrarNotaCreditoBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_AdministrarNotaCreditoWindow w = new MV_AdministrarNotaCreditoWindow();
            w.Show();
        }
    }
}
