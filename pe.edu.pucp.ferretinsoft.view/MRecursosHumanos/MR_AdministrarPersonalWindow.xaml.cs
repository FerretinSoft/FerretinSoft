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

namespace pe.edu.pucp.ferretinsoft.view.MRecursosHumanos
{
    /// <summary>
    /// Lógica de interacción para MR_AdministrarPersonalWindow.xaml
    /// </summary>
    public partial class MR_AdministrarPersonalWindow : Window
    {
        public MR_AdministrarPersonalWindow()
        {
            InitializeComponent();
        }

        private void nuevoEmpleadoBtn_Click(object sender, RoutedEventArgs e)
        {
            personalTab.SelectedIndex = 1;
        }

        private void edEmpleadoBtn_Click(object sender, RoutedEventArgs e)
        {
            personalTab.SelectedIndex = 1;
        }
    }
}
