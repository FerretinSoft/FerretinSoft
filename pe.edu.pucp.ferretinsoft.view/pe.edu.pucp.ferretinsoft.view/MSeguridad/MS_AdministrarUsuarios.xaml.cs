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
using System.Data;

namespace pe.edu.pucp.ferretinsoft.view.MSeguridad
{
    /// <summary>
    /// Interaction logic for MS_AdministrarUsuarios.xaml
    /// </summary>
    public partial class MS_AdministrarUsuarios : Window
    {
        public MS_AdministrarUsuarios()
        {
            InitializeComponent();
            usuariosDg.ItemsSource = listUsuarios();
        }

        private void nuevoUsuarioBtn_Click(object sender, RoutedEventArgs e)
        {
            usuariosTab.SelectedIndex = 1;
        }

        private void edUsuarioBtn_Click(object sender, RoutedEventArgs e)
        {
            usuariosTab.SelectedIndex = 1;
        }

        private void privilegiosBtn_Click(object sender, RoutedEventArgs e)
        {
            //PrivilegiosWindow pw = new PrivilegiosWindow();
            //pw.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MS_GenerarContraseñaWindow cw = new MS_GenerarContraseñaWindow();
            cw.ShowDialog();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private List<UsuarioSistema> listUsuarios()
        {
            List<UsuarioSistema> listaUsuarios = new List<UsuarioSistema>();
            UsuarioSistema usuario_1 = new UsuarioSistema();
            UsuarioSistema usuario_2 = new UsuarioSistema();
            UsuarioSistema usuario_3 = new UsuarioSistema();
            UsuarioSistema usuario_4 = new UsuarioSistema();

            usuario_1.nombre = "Josefina Liz";
            usuario_1.apellidoP = "Solorzano";
            usuario_1.apellidoM = "Narvaez";
            usuario_1.codigo = "100001";
            usuario_1.estado = "Activo";            
            usuario_1.nombreUsuario = "SNJosefina";
            listaUsuarios.Add(usuario_1);

            usuario_2.nombre = "Cesar Luis";
            usuario_2.apellidoP = "Flores";
            usuario_2.apellidoM = "Gutiérrez";
            usuario_2.codigo = "100002";
            usuario_2.estado = "Activo";            
            usuario_2.nombreUsuario = "FGCesar";
            listaUsuarios.Add(usuario_2);

            usuario_3.nombre = "Pedro Pablo";
            usuario_3.apellidoP = "Cervantes";
            usuario_3.apellidoM = "Rodriguez";
            usuario_3.codigo = "100003";
            usuario_3.estado = "Inactivo";            
            usuario_3.nombreUsuario = "CRPedro";
            listaUsuarios.Add(usuario_3);

            usuario_4.nombre = "Jose Luis";
            usuario_4.apellidoP = "Fernandez";
            usuario_4.apellidoM = "Martinez";
            usuario_4.codigo = "100004";
            usuario_4.estado = "Inactivo";            
            usuario_4.nombreUsuario = "FMJose";
            listaUsuarios.Add(usuario_4);

            return listaUsuarios;
        }

    }
}
