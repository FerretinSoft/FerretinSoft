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
    /// Interaction logic for MS_AdministrarPerfiles.xaml
    /// </summary>
    public partial class MS_AdministrarPerfiles : Window
    {
        public MS_AdministrarPerfiles()
        {
            InitializeComponent();
            perfilDg.ItemsSource = listPerfiles();

        }

        private void nuevoPerfilBtn_click(object sender, RoutedEventArgs e)
        {
            perfilesTab.SelectedIndex = 1;
        }

        private void edPerfilBtn_Click(object sender, RoutedEventArgs e)
        {
            perfilesTab.SelectedIndex = 1;
        }


        private List<Perfil> listPerfiles()
        {
            List<Perfil> perfiles = new List<Perfil>();

            List<Perfil> catalogoProv1 = new List<Perfil>();
            Perfil perf1 = new Perfil();
            Perfil perf2 = new Perfil();
            Perfil perf3 = new Perfil();
            Perfil perf4 = new Perfil();
            Perfil perf5 = new Perfil();

            perf4.perf = "Administrador del Sistema";
            perf4.Modulo = "Seguridad";
            perf4.Descripcion = "Encargado de llevar un control de la seguridad y parametros.";
            perfiles.Add(perf4);

            perf5.perf = "Asistente de Almacén";
            perf5.Modulo = "Almacén";
            perf5.Descripcion = "Encargado de registrar las salidas y entradas de productos al almacen.";
            perfiles.Add(perf5);

            perf1.perf = "Asistente de Ventas";
            perf1.Modulo = "Ventas";
            perf1.Descripcion = "Encargado del mantenimiento de la información de los clientes.";
            perfiles.Add(perf1);

            perf3.perf = "Jefe de Tienda";
            perf3.Modulo = "Almacen, Ventas";
            perf3.Descripcion = "Encargado de controlar los movimientos de almacen y de las ventas.";
            perfiles.Add(perf3);

            perf2.perf = "Vendedor";
            perf2.Modulo = "Ventas";
            perf2.Descripcion = "Encargado de realizar las ventas a los clientes.";
            perfiles.Add(perf2);
            
            return perfiles;
        }


    }
}
