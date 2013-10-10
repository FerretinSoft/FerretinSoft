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

namespace pe.edu.pucp.ferretinsoft.view.MSeguridad
{
    /// <summary>
    /// Interaction logic for MS_AuditoriaWindow.xaml
    /// </summary>
    public partial class MS_AuditoriaWindow : Window
    {
        public MS_AuditoriaWindow()
        {
            InitializeComponent();
            auditoriasDg.ItemsSource = ListAuditorias();
        }

        public List<Auditoria> ListAuditorias(){
            List<Auditoria> auditorias = new List<Auditoria>();            
            Auditoria auditoria_1 = new Auditoria();
            auditoria_1.ip = "192.168.1.102";
            auditoria_1.macAddress = "C8-F7-33-00-39-BD";
            auditoria_1.hora = "22:15";
            auditoria_1.fecha = "10/10/2013";
            auditoria_1.perfil = "Administrador del Sistema";
            auditoria_1.transaccion = "Modificación Parámetros";
            auditoria_1.nombreUsuario = "FJLuis";
            auditorias.Add(auditoria_1);

            Auditoria auditoria_2 = new Auditoria();
            auditoria_2.ip = "192.168.1.112";
            auditoria_2.macAddress = "C8-F8-34-00-39-BD";
            auditoria_2.hora = "14:15";
            auditoria_2.fecha = "05/10/2013";
            auditoria_2.perfil = "Asistente de Ventas";
            auditoria_2.transaccion = "Registro de Devolución";
            auditoria_2.nombreUsuario = "GMCarmen";
            auditorias.Add(auditoria_2);

            Auditoria auditoria_3 = new Auditoria();
            auditoria_3.ip = "192.168.1.105";
            auditoria_3.macAddress = "C3-F3-34-01-39-BD";
            auditoria_3.hora = "16:15";
            auditoria_3.fecha = "02/10/2013";
            auditoria_3.perfil = "Asistente de Ventas";
            auditoria_3.transaccion = "Registro de Devolución";
            auditoria_3.nombreUsuario = "GRRosio";
            auditorias.Add(auditoria_3);

            return auditorias;
        }
    }
}
