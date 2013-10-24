using pe.edu.pucp.ferretinsoft.model;
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public class MV_RegistrarVentaViewModel : INotifyPropertyChanged
    {

        private Cliente _cliente;
        public Cliente cliente
        {
            get 
            {
                return _cliente;
            }
            set
            {
                _cliente = value;
                NotifyPropertyChanged("cliente");
            }
        }

        public String nroDocCliente
        {
            get
            {
                if (cliente != null && int.Parse(cliente.nroDoc) > 0)
                {
                    return cliente.nroDoc + "";
                }
                else
                {
                    return "";
                }
            }
            set
            {
                if (value.Length > 0)
                {
                    cliente = ClienteService.obtenerClienteByNroDoc(value);
                }
                else
                {
                    cliente = null;
                }
                NotifyPropertyChanged("nroDocCliente");
                NotifyPropertyChanged("widthClienteBar");
            }
        }
        public GridLength widthClienteBar
        {
            get
            {
                return cliente == null ? new GridLength(0) : GridLength.Auto;
            }
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        #endregion
    }

    /// <summary>
    /// Lógica de interacción para MV_RegistrarVentaWindow.xaml
    /// </summary>
    public partial class MV_RegistrarVentaWindow : Window
    {

        MV_RegistrarVentaViewModel MV_RegistrarVentaViewModel = new MV_RegistrarVentaViewModel();

        public MV_RegistrarVentaWindow()
        {
            DataContext = MV_RegistrarVentaViewModel;
            InitializeComponent();
        }

        private void pagarBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_PagoWindow pw = new MV_PagoWindow();
            pw.Owner = this;
            pw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buscarProformaBtn_Click(object sender, RoutedEventArgs e)
        {
            MV_AdministrarProformasWindow profWindow = new MV_AdministrarProformasWindow();
            profWindow.Show();
        }


        private void buscarClienteBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nuevoProductoBtn_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
