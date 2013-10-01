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
    /// Lógica de interacción para MV_MainWindow.xaml
    /// </summary>
    public partial class MV_MainWindow : Window
    {
        public MV_MainWindow()
        {
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.OwnedWindows.Count == 0) //si no tiene ninguna ventana hija 
            {
                this.Close();
            }
        }

        private void registrarVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_RegistrarVentaWindow w = new MV_RegistrarVentaWindow();
            w.Owner = this;
            w.Show();
        }

        private void admClientesBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_ClientesWindow cw = new MV_ClientesWindow();
            cw.Owner = this;
            cw.Show();
        }

        private void repVentasBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_ReportesVentasWindow repW = new MV_ReportesVentasWindow();
            repW.Owner = this;
            repW.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MV_ServiciosPostVentaWindow w = new MV_ServiciosPostVentaWindow();
            w.Owner = this;
            w.Show();
        }

        private void administrarProformasBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_AdministrarProformasWindow w = new MV_AdministrarProformasWindow();
            w.Owner = this;
            w.Show();
        }

        

    }
}
