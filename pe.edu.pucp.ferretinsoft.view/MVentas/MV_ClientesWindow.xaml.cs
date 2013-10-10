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
            clientesGrid.ItemsSource = ListaClientes();
            
        }

        private List<Cliente> ListaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            clientes.Add(new Cliente
            {
               
                    Codigo = 000000526358,
                    Nombre = "Simón",
                    Apellido ="Bolivar",
                    TipoDocumento = "RUC",
                    TipoCliente = "Jurídico",
                    TelefonoCliente = "5550555",
                    EmailCliente = "simon.elInmortal@gmail.com",
                    PuntosCliente = 100,
                    PuntosGanadosCliente = 1000,
                    PuntosUsadosCliente = 900,
                    UltimaCompraCliente = "15/09/2013",
                    TotalComprasCliente = 5,
                    RegistradoCliente = "Josefina Alfaro",
                    DireccionCliente = "Avenida Los Libertadores Nro 200 Int. 405"
            });
            clientes.Add(new Cliente
            {
                    Codigo = 0000008569524,
                    Nombre = "Daniel",
                    Apellido = "Alcides Carrión",
                    TipoDocumento = "RUC",
                    TipoCliente = "Jurídico",
                    TelefonoCliente = "1020304",
                    EmailCliente = "daniel.elSanador@gmail.com",
                    PuntosCliente = 500,
                    PuntosGanadosCliente = 5000,
                    PuntosUsadosCliente = 4500,
                    UltimaCompraCliente = "01/09/2013",
                    TotalComprasCliente = 20,
                    RegistradoCliente = "Josefina Alfaro",
                    DireccionCliente = "Av. Los Curadores 3era Etapa"
            });
            clientes.Add(new Cliente
            {     
                    Codigo = 70456862,
                    Nombre = "Ignacio",
                    Apellido = "De Loyola",
                    TipoDocumento = "DNI",
                    TipoCliente = "Natural",
                    TelefonoCliente = "4240745",
                    EmailCliente = "ignacio.elBueno@gmail.com",
                    PuntosCliente = 1800,
                    PuntosGanadosCliente = 5000,
                    PuntosUsadosCliente = 3200,
                    UltimaCompraCliente = "10/09/2013",
                    TotalComprasCliente = 10,
                    RegistradoCliente = "Josefina Alfaro",
                    DireccionCliente = "Calle El Mas Bueno 515 Dpto 202"
            });

            return clientes;
        }

        public void numDocumento_Click(object sender, RoutedEventArgs e)
        {

            var rowData = ((Hyperlink)e.OriginalSource).DataContext as Cliente;

            numDocTxtBox.Text = (rowData.Codigo)+"";
            nombreClienteTxtBox.Text = rowData.Nombre;
            if (rowData.TipoDocumento == "DNI")
                documentoCombo.SelectedIndex = 0;
            else
                documentoCombo.SelectedIndex = 1;
            if (rowData.TipoCliente == "Natural")
                tipoClienteCombo.SelectedIndex = 0;
            else
                tipoClienteCombo.SelectedIndex = 1;

            apellidoClienteTxtBox.Text = rowData.Apellido;
            telefonoClienteTxtBox.Text = rowData.TelefonoCliente;
            emailClienteTxtBox.Text = rowData.EmailCliente;
            puntosActualClienteTxtBox.Text = rowData.PuntosCliente+"";
             puntosGanadosClienteTxtBox.Text = rowData.PuntosGanadosCliente+"";
             puntosUsadosClienteTxtBox.Text = rowData.PuntosUsadosCliente+"";
             ultCompraClienteTxtBox.Text = rowData.UltimaCompraCliente;
             totalComprasClienteTxtBox.Text=rowData.TotalComprasCliente+"";
             vendedorClienteTxtBox.Text=rowData.RegistradoCliente;
             direccionClienteTxtBox.Text=rowData.DireccionCliente;
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
    }
}
