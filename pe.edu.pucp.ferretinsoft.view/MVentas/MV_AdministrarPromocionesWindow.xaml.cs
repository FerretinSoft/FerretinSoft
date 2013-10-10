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
    /// Lógica de interacción para MV_AdministrarPromocionesWindow.xaml
    /// </summary>
    public partial class MV_AdministrarPromocionesWindow : Window
    {
        public MV_AdministrarPromocionesWindow()
        {
            InitializeComponent();
            promocionesGrid.ItemsSource = ListaPromociones();
        }

        private List<Promocion> ListaPromociones()
        {
            List<Promocion> promociones = new List<Promocion>();
            promociones.Add(new Promocion
            {
                Codigo = 000000256325,
                Nombre = "3 x 2 en todo Pinturas",
                FechaDesde = "01/10/2013",
                FechaHasta = "31/10/2013",
                Estado = "Activo"
            });
            promociones.Add(new Promocion
            {
                Codigo = 000000256325,
                Nombre = "15% Descuento Mayólicas Celima",
                FechaDesde = "01/10/2013",
                FechaHasta = "15/10/2013",
                Estado = "Activo"
            });
            promociones.Add(new Promocion
            {
                Codigo = 000000256325,
                Nombre = "10% Descuento en Taladros",
                FechaDesde = "15/10/2013",
                FechaHasta = "31/10/2013",
                Estado = "Inactivo"
            });
            promociones.Add(new Promocion
            {
                Codigo = 000000256325,
                Nombre = "2x1 En Desarmadores Rubicon",
                FechaDesde = "15/10/2013",
                FechaHasta = "31/10/2013",
                Estado = "Inactivo"
            });
            return promociones;
        }
        private void editarPromocionBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 1;
        }

        private void nuevaPromocionBtn_Click(object sender, RoutedEventArgs e)
        {
            VentasTab.SelectedIndex = 1;
        }
    }
}
