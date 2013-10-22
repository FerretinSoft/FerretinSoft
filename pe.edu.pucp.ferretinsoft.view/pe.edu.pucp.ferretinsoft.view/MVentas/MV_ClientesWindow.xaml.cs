using System;
using System.Collections;
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
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;

namespace pe.edu.pucp.ferretinsoft.view.MVentas
{
    /// <summary>
    /// Lógica de interacción para MV_ClientesWindow.xaml
    /// </summary>
    public partial class MV_ClientesWindow : Window
    {
        
        public MV_ClientesWindow()
        {
            InitializeComponent();
            clientesGrid.ItemsSource = ClienteService.obtenerListaClientes();
            
        }

        private IList ListaClientes()
        {

            IList clientes = ClienteService.obtenerListaClientes();
            return clientes;
        }

        public void numDocumento_Click(object sender, RoutedEventArgs e)
        {

            var rowData = ((Hyperlink)e.OriginalSource).DataContext as Cliente;

            numDocTxtBox.Text = (rowData.codigo)+"";
            nombreClienteTxtBox.Text = rowData.nombre;
            if (rowData.tipoDocumento == "DNI")
                documentoCombo.SelectedIndex = 0;
            else
                documentoCombo.SelectedIndex = 1;
            if (rowData.tipoCliente == "Natural")
                tipoClienteCombo.SelectedIndex = 0;
            else
                tipoClienteCombo.SelectedIndex = 1;

            apellidoClienteTxtBox.Text = rowData.apellidoPaterno;
            telefonoClienteTxtBox.Text = rowData.telefonoCliente;
            emailClienteTxtBox.Text = rowData.emailCliente;
            puntosActualClienteTxtBox.Text = rowData.puntosCliente+"";
             puntosGanadosClienteTxtBox.Text = rowData.puntosGanadosCliente+"";
             puntosUsadosClienteTxtBox.Text = rowData.puntosUsadosCliente+"";
             ultCompraClienteTxtBox.Text = rowData.ultimaCompraCliente;
             totalComprasClienteTxtBox.Text=rowData.totalComprasCliente+"";
             vendedorClienteTxtBox.Text=rowData.registradoCliente;
             direccionClienteTxtBox.Text=rowData.direccionCliente;
            clientesTab.SelectedIndex = 1;
        }

        public MV_ClientesWindow(MV_AdministrarVentasWindow MV_AdministrarVentasWindow)
        {
            InitializeComponent();
           
            
            Show();
        }

        private void nuevoClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 1;
        }

        private void edClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            clientesTab.SelectedIndex = 0;
        }

        private void cancelarListaClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {
            Cliente cliente = new Cliente();
            if (numDocSearchTxtBox.Text != "")
                cliente.nroDoc = Convert.ToInt32(numDocSearchTxtBox.Text);
            else
                cliente.nroDoc = -1;
            Console.WriteLine(numDocSearchTxtBox.Text);
            cliente.nombre = nombreClienteSearchTxtBox.Text;
            cliente.apellidoPaterno = apPatClienteSearchTxtBox.Text;
            cliente.apellidoMaterno = apMatClienteSearchTxtBox.Text;
            ComboBoxItem typeItem = (ComboBoxItem)docCombo.SelectedItem;
            cliente.tipoDocumento = typeItem.Content.ToString();
            clientesGrid.ItemsSource = ClienteService.obtenerListaClientesBy(cliente);

        }
    }
}
