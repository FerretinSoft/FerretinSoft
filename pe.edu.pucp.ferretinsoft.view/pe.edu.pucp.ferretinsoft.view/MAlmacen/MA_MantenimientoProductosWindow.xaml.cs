using pe.edu.pucp.ferretinsoft.controller.Services;
using pe.edu.pucp.ferretinsoft.model;
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;
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
    public partial class MA_MantenimientoProductosWindow : Window
    {
        public MA_MantenimientoProductosWindow()
        {
            InitializeComponent();
            //IList<Categorias> listaCat=CategoriasService.obtenerCategorias();
            //this.categoriaCombo.DisplayMemberPath = "nombre";
            //this.categoriaCombo.SelectedValuePath = "id";
            //this.categoriaCombo.ItemsSource=listaCat;
            gridProductos.ItemsSource = listaProductos();
        }

        public IList<Categorias> listaCategorias()
        {
            return CategoriasService.obtenerCategorias();
        }

        public IList<Producto> listaProductos()
        {
            IList<Producto> listProd=ProductoService.obtenerListaProductos();

            return listProd;
        }

        private void nuevoProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            mantenimientoTab.SelectedIndex = 1;
        }

        private void editarProductoBtn_Click(object sender, RoutedEventArgs e)
        {
            mantenimientoTab.SelectedIndex = 1;
        }

        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            Producto p = new Producto();
            p.nombre = this.txtNombre.Text;
            
            //if (this.chkActivo && this.chkInactivo)
            //{
            //    p.estado=
            //}
            //else
            //{
            //    if (this.chkActivo)
            //    else
                
            //}
            
            gridProductos.ItemsSource = ProductoService.obtenerProductoPorNombre(p);
        }

        
                

        
    }
}
