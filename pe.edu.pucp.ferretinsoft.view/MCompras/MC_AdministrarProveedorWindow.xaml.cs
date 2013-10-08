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
using Microsoft.Win32;
using pe.edu.pucp.ferretinsoft.model;


namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Lógica de interacción para MC_AdministrarProveedorWindow.xaml
    /// </summary>
    public partial class MC_AdministrarProveedorWindow : Window
    {
        public MC_AdministrarProveedorWindow()
        {
            InitializeComponent();
            proveedoresDg.ItemsSource = ListProveedores();

        }

        private void importarProducto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dirDialog = new OpenFileDialog();
            dirDialog.ShowDialog();
        }

        private void nuevoProveedorBtn_Click(object sender, RoutedEventArgs e)
        {
            proveedorTab.SelectedIndex = 1;
        }

        private void nuevoProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AgregarProdCatalogoWindow prdCat = new MC_AgregarProdCatalogoWindow();
            prdCat.Owner = this;
            prdCat.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            proveedorTab.SelectedIndex = 0;
        }

        private List<Proveedor> ListProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            proveedores.Add(new Proveedor()
                {
                    ID = "101",
                    tipoProv = "Empresa",
                    codigo = "20112355101",
                    razSoc = "Aceros Arequipa",
                    rubro = "Cemento",
                    domicilio = "Av. La Marina 1167",
                    dep = "Lima",
                    prov = "Lima",
                    dist = "Lima",
                    cp = "Lima 13",
                    telefono = "4570889",
                    pagWeb = "www.acerosarequipa.com.pe",
                    nombContacto = "Juan Perez",
                    tlfContacto = "99384577"
                }
             );

            proveedores.Add(new Proveedor()
                {
                    ID = "201",
                    tipoProv = "Persona",
                    codigo = "23004511231",
                    razSoc = "Philips",
                    rubro = "Electricidad",
                    domicilio = "Av. La Paz 2688",
                    dep = "Lima",
                    prov = "Lima",
                    dist = "Ate Vitarte",
                    cp = "Lima 18",
                    telefono = "4204789",
                    pagWeb = "www.philips.com.pe",
                    nombContacto = "Pedro Gonzales",
                    tlfContacto = "980988264"
                }
            );

            return proveedores;
        }

    }
}
