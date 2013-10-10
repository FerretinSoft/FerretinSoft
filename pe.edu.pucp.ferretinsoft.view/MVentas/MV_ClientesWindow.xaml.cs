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
                    Nombre = "Simón Bolivar",
                    TipoDocumento = "RUC",
                    TipoCliente = "Jurídico",
                    TelefonoCliente = "5550555",
                    EmailCliente = "simon.elInmortal@gmail.com",
                    PuntosCliente = 100
            });
            clientes.Add(new Cliente
            {
                    Codigo = 0000008569524,
                    Nombre = "Daniel Alcides Carrión",
                    TipoDocumento = "DNI",
                    TipoCliente = "Jurídico",
                    TelefonoCliente = "1020304",
                    EmailCliente = "daniel.elSanador@gmail.com",
                    PuntosCliente = 500
            });
            clientes.Add(new Cliente
            {     
                    Codigo = 70456862,
                    Nombre = "Ignacio de Loyola",
                    TipoDocumento = "RUC",
                    TipoCliente = "Natural",
                    TelefonoCliente = "4240745",
                    EmailCliente = "ignacio.elBueno@gmail.com",
                    PuntosCliente = 1800
            });

            return clientes;
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
