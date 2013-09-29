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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pe.edu.pucp.ferretinsoft.view
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void comprasBtn_Click(object sender, RoutedEventArgs e)
        {
            MCompras.MC_MainWindow MCWindow = new MCompras.MC_MainWindow();
            MCWindow.Show();
        }

        private void confBtn_Click(object sender, RoutedEventArgs e)
        {
            MSeguridad.MS_MainWindow MSWindow = new MSeguridad.MS_MainWindow();
            MSWindow.Show();
        }
    }
}
