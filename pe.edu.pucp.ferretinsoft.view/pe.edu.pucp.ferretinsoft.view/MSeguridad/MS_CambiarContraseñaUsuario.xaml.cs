using pe.edu.pucp.ferretinsoft.model;
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

namespace pe.edu.pucp.ferretinsoft.view.MSeguridad
{
    /// <summary>
    /// Interaction logic for MS_CambiarContraseñaUsuario.xaml
    /// </summary>
    public partial class MS_CambiarContraseñaUsuario : Window
    {
        public static UsuarioSistema usuario;

        public MS_CambiarContraseñaUsuario(UsuarioSistema usuarioLog)
        {
            InitializeComponent();
            usuario = usuarioLog;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
