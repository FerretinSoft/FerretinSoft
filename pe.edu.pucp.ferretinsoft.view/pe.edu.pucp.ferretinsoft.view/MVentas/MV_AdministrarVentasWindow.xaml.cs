﻿using System;
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

namespace pe.edu.pucp.ferretinsoft.view.MVentas
{
    /// <summary>
    /// Lógica de interacción para MV_AdministrarVentasWindow.xaml
    /// </summary>
    public partial class MV_AdministrarVentasWindow : Window
    {
        public int selectedCodVenta = 0;

        public MV_AdministrarVentasWindow()
        {
            InitializeComponent();
            rowSelectVentaLista.Height = new GridLength(0);
            rowSelectVentaDetalle.Height = new GridLength(0);
            ventasGrid.ItemsSource = ListaVentas();
        }

        private List<Venta> ListaVentas()
        {
            Vendedor vendedor = new Vendedor
            {
                Codigo = 000000256256,
                Nombre = "José Olaya Balandra"
            };

            List<Venta> ventas = new List<Venta>();
            

            return ventas;
        }

        public MV_AdministrarVentasWindow(MV_DevolucionesWindow devolucionesWindow)
        {
            InitializeComponent();
            Owner = devolucionesWindow;
            rowSelectVentaLista.Height = GridLength.Auto;
            rowSelectVentaDetalle.Height = GridLength.Auto;
            
            seleccionarListaVentaBtn.Click += devolucionesWindow.seleccionarVenta;
            Show();
        }
        private void detalleVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 1;
        }

        MV_ClientesWindow clientesWindow;
        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            clientesWindow = new MV_ClientesWindow(this);
        }

        public void seleccionarCliente(object sender, RoutedEventArgs e)
        {
            clientesWindow.Close();
        }

        private void buscarVendedorBtn_Click(object sender, RoutedEventArgs e)
        {
            //PersonalAdminWindow pw = new PersonalAdminWindow();
            //pw.Show();
        }


        private void cerrarVentana()
        {
            this.Close();
        }

        private void cancelarListaVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            cerrarVentana();
        }

        private void editarVentaBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 1;
        }

        private void editarPromocionBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 3;
        }

        
    }
}
