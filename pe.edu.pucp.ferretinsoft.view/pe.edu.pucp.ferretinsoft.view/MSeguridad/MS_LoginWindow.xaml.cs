﻿using System;
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
using pe.edu.pucp.ferretinsoft.controller.Services;
using pe.edu.pucp.ferretinsoft.model;
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;


namespace pe.edu.pucp.ferretinsoft.view.MSeguridad
{
    /// <summary>
    /// Interaction logic for MS_LoginWindow.xaml
    /// </summary>
    public partial class MS_LoginWindow : Window
    {
        private String nombreUsuario;
        private String contrasena;
        public static UsuarioSistema usuarioLog;


        public MS_LoginWindow()
        {

            InitializeComponent();
            if (Console.CapsLock)
            {
                statusLabel.Content = "Mayusculas Activadas";
            }

        }

        private void iniSesionBtn_Click(object sender, RoutedEventArgs e)
        {
            login();
        }

        private void tboxNombreUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.nombreUsuario = tboxNombreUsuario.Text.ToString();

        }

        private void pwboxContrasena_PasswordChanged(object sender, RoutedEventArgs e)
        {
            this.contrasena = pwboxContrasena.Password.ToString();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (Console.CapsLock)
            {
                statusLabel.Content = "Mayusculas Activadas";
            }

            if (!Console.CapsLock)
            {
                statusLabel.Content = "";
            }

            if (Keyboard.IsKeyDown(Key.Enter)) login();
        }

        private void login()
        {

            IList usuarios = UsuarioService.obtenerListaUsuarios();


            foreach (UsuarioSistema value in usuarios)
            {
                if (value.nombreUsuario == this.nombreUsuario && value.contraseña == this.contrasena)
                {
                    usuarioLog = value;
                    MainWindow mainW = new MainWindow(usuarioLog);
                    this.Close();
                    mainW.Show();

                }
                else
                {
                    if (String.IsNullOrEmpty(this.nombreUsuario) && String.IsNullOrEmpty(this.contrasena))
                    {

                        lbLoginError.Content = "Ingrese un nombre de usuario y contraseña.";

                    }
                    else if (String.IsNullOrEmpty(this.nombreUsuario))
                    {

                        lbLoginError.Content = "Ingrese un nombre de usuario.";

                    }
                    else if (String.IsNullOrEmpty(this.contrasena))
                    {

                        lbLoginError.Content = "Ingrese una contraseña.";

                    }
                    else if (!String.IsNullOrEmpty(this.nombreUsuario) && !String.IsNullOrEmpty(this.contrasena))
                    {

                        lbLoginError.Content = "Nombre de Usuario y Contraseña invalidos.";

                    }

                }
            }


        }


    }
}
