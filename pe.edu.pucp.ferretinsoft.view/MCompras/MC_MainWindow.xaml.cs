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

namespace pe.edu.pucp.ferretinsoft.view.MCompras
{
    /// <summary>
    /// Interaction logic for MC_MainWindow.xaml
    /// </summary>
    public partial class MC_MainWindow : Window
    {
        public MC_MainWindow()
        {
            InitializeComponent();
        }

        private void adminProveedoresBtn_Click(object sender, RoutedEventArgs e)
        {
            MC_AdministrarProveedorWindow MCadmp = new MC_AdministrarProveedorWindow();
            MCadmp.Show();
        }
    }
}
