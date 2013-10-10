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
using System.Data;


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

            List<ProductoProveedor> catalogoProv1 = new List<ProductoProveedor>();
            ProductoProveedor prodProv1_1 = new ProductoProveedor();
            ProductoProveedor prodProv1_2 = new ProductoProveedor();
            ProductoProveedor prodProv1_3 = new ProductoProveedor();

            prodProv1_1.producto = "Cemento Premium";
            prodProv1_1.unidad = "1 TN";
            prodProv1_1.precio = "1000";
            prodProv1_1.tiempoEentrega = "30 dias";
            catalogoProv1.Add(prodProv1_1);


            prodProv1_2.producto = "Cemento Regular";
            prodProv1_2.unidad = "1 TN";
            prodProv1_2.precio = "800";
            prodProv1_2.tiempoEentrega = "20 dias";
            catalogoProv1.Add(prodProv1_2);

            prodProv1_3.producto = "Ladrillo Rojo";
            prodProv1_3.unidad = "Millar";
            prodProv1_3.precio = "500";
            prodProv1_3.tiempoEentrega = "15 dias";
            catalogoProv1.Add(prodProv1_3);

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
                    tlfContacto = "99384577",
                    catalogo = catalogoProv1
                }
             );


            List<ProductoProveedor> catalogoProv2 = new List<ProductoProveedor>();
            ProductoProveedor prodProv2_1 = new ProductoProveedor();
            ProductoProveedor prodProv2_2 = new ProductoProveedor();

            prodProv2_1.producto = "Foco 50W";
            prodProv2_1.unidad = "Caja 100 und.";
            prodProv2_1.precio = "350";
            prodProv2_1.tiempoEentrega = "10 dias";
            catalogoProv2.Add(prodProv2_1);

            prodProv2_2.producto = "Foco Ahorrador";
            prodProv2_2.unidad = "Caja 50 und.";
            prodProv2_2.precio = "200";
            prodProv2_2.tiempoEentrega = "10 dias";
            catalogoProv2.Add(prodProv2_2);

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
                    tlfContacto = "980988264",
                    catalogo = catalogoProv2
                }
            );

            return proveedores;
        }

        public void rucProveedor_Click(object sender, RoutedEventArgs e)
        {
            
            var rowData = ((Hyperlink)e.OriginalSource).DataContext as Proveedor;

            rucTxtBox.Text = rowData.codigo;
            razSocTxtBox.Text = rowData.razSoc;
            domTxtBox.Text = rowData.domicilio;
            tlfTxtBox.Text = rowData.telefono;
            pagWebTxtBox.Text = rowData.pagWeb;
            contactoTxtBox.Text = rowData.nombContacto;
            contactoTlfTxtBox.Text = rowData.tlfContacto;
            idTxtBox.Text = rowData.ID;
            rubroCbx.SelectedIndex = 0;
            tipoProvCbx.SelectedIndex = 0;
            departCbx.SelectedIndex = 0;
            provinciaCbx.SelectedIndex = 0;
            distritoCbx1.SelectedIndex = 0;
            cpCbx.SelectedIndex = 0;
            dgwCatalogo.ItemsSource = rowData.catalogo;
            proveedorTab.SelectedIndex = 1;
        }
    }
}
