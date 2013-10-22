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

            perf4.nombrePerfil = "Administrador del Sistema";
            perf4.modulo = "Seguridad";
            perf4.descripcion = "Encargado de llevar un control de la seguridad y parametros.";
            perfiles.Add(perf4);

            perf5.nombrePerfil = "Asistente de Almacén";
            perf5.modulo = "Almacén";
            perf5.descripcion = "Encargado de registrar las salidas y entradas de productos al almacen.";
            perfiles.Add(perf5);

            perf1.nombrePerfil = "Asistente de Ventas";
            perf1.modulo = "Ventas";
            perf1.descripcion = "Encargado del mantenimiento de la información de los clientes.";
            perfiles.Add(perf1);

            perf3.nombrePerfil = "Jefe de Tienda";
            perf3.modulo = "Almacen, Ventas";
            perf3.descripcion = "Encargado de controlar los movimientos de almacen y de las ventas.";
            perfiles.Add(perf3);

            perf2.nombrePerfil = "Vendedor";
            perf2.modulo = "Ventas";
            perf2.descripcion = "Encargado de realizar las ventas a los clientes.";
            perfiles.Add(perf2);
            
            return perfiles;
        }


    }
}
