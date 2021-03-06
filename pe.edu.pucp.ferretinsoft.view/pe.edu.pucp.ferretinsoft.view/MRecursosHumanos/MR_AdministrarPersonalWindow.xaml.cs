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
using pe.edu.pucp.ferretinsoft.model;
using System.Windows.Shapes;
using System.ComponentModel;
using Project_FerretinSoft.pe.edu.pucp.ferretinsoft.controller.Services;

namespace pe.edu.pucp.ferretinsoft.view.MRecursosHumanos
{

    public class MR_AdministrarPersonalViewModel : INotifyPropertyChanged
    {

        public IEnumerable<UbigeoDepartamento> departamento
        {
            get
            {
                return UbigeoService.departamentos;
            }
        }
        private int _selectedDepartamento;
        public int selectedDepartamento
        {
            get
            {
                return _selectedDepartamento>0?_selectedDepartamento:0;
            }
            set
            {
                _selectedDepartamento = value;
                NotifyPropertyChanged("selectedDepartamento");
                NotifyPropertyChanged("provincia");
                NotifyPropertyChanged("distrito");
            }
        }

        public IEnumerable<UbigeoProvincia> provincia
        {
            get
            {
                return UbigeoService.departamentos.ElementAt(selectedDepartamento).UbigeoProvincia;
            }
        }
        private int _selectedProvincia;
        public int selectedProvincia
        {
            get
            {
                return _selectedProvincia>0?_selectedProvincia:0;
            }
            set
            {
                _selectedProvincia = value;
                NotifyPropertyChanged("distrito");
            }
        }

        public IEnumerable<UbigeoDistrito> distrito
        {
            get
            {
                return UbigeoService.departamentos.ElementAt(selectedDepartamento).UbigeoProvincia.ElementAt(selectedProvincia).UbigeoDistrito;
            }
        }
        private int selectedDistrito { get; set; }


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
    /// Lógica de interacción para MR_AdministrarPersonalWindow.xaml
    /// </summary>
    public partial class MR_AdministrarPersonalWindow : Window
    {
        MR_AdministrarPersonalViewModel MR_AdministrarPersonalViewModel = new MR_AdministrarPersonalViewModel();
 
        public MR_AdministrarPersonalWindow()
        {
            InitializeComponent();
            personalDg.ItemsSource = ListPersonal();
            DataContext = MR_AdministrarPersonalViewModel;
        }

        private void nuevoEmpleadoBtn_Click(object sender, RoutedEventArgs e)
        {
            personalTab.SelectedIndex = 1;
        }

        private void edEmpleadoBtn_Click(object sender, RoutedEventArgs e)
        {
            personalTab.SelectedIndex = 1;
        }

        private List<Personal> ListPersonal()
        {
            List<Personal> personal = new List<Personal>();

            Personal per1 = new Personal();
            Personal per2 = new Personal();
            Personal per3 = new Personal();

            per1.codigo = "000001";
            per1.dni = "23453412";
            per1.nombreCompleto = "Heidy Hernandez Breton";
            per1.nombre = "Heidy";
            per1.apPat = "Hernandez";
            per1.apMat = "Breton";
            per1.cargo = "Jefe de Tienda";
            per1.tienda = "Tienda 1";
            per1.direccion = "Av. Constructores 1150";
            per1.telefono = "923456231";
            personal.Add(per1);

            per2.codigo = "000002";
            per2.dni = "45342312";
            per2.nombreCompleto = "Luis Ezpinoza Sanchez";
            per2.nombre = "Luis ";
            per2.apPat = "Ezpinoza ";
            per2.apMat = "Sanchez";            
            per2.cargo = "Asistente Venta";
            per2.tienda = "Tienda 3";
            per2.direccion = "Av. Universitaria 590";
            per2.telefono = "999009131";
            personal.Add(per2);

            per3.codigo = "000003";
            per3.dni = "81453412";
            per3.nombreCompleto = "Juan Carlos Condori Tipula";
            per3.nombre = "Juan Carlos ";
            per3.apPat = "Condori ";
            per3.apMat = "Tipula";
            per3.cargo = "Jefe de RRHH";
            per3.tienda = "Tienda 5";
            per3.direccion = "Av. Palmares 9021";
            per3.telefono = "800080808";
            personal.Add(per3);

            return personal;
        }

        public void codigoPersonal_Click(object sender, RoutedEventArgs e)
        {

            var rowData = ((Hyperlink)e.OriginalSource).DataContext as Personal;

            codTxtBox.Text = rowData.codigo;
            dniTxtBox.Text = rowData.dni;
            nomTxtBox.Text = rowData.nombre;
            apPatTxtBox.Text = rowData.apPat;
            apMatTxtBox.Text = rowData.apMat;
            telf1TxtBox.Text = rowData.telefono;
            telf2TxtBox.Text = rowData.telefono;
            dirTxtBox.Text = rowData.direccion;                       

            personalTab.SelectedIndex = 1;
        }

    }
}
