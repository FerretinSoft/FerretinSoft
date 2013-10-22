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
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;

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
            //perfilDg.ItemsSource = PerfilService.obtenerListaPerfiles();
            
            
        }

        private void nuevoPerfilBtn_click(object sender, RoutedEventArgs e)
        {
            perfilesTab.SelectedIndex = 1;
        }

        private void edPerfilBtn_Click(object sender, RoutedEventArgs e)
        {
            perfilesTab.SelectedIndex = 1;
        }        

    }
}
