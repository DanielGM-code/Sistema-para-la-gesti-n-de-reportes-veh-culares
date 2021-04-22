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

namespace SGRV.GUIDelegacionesMunicipales
{
    /// <summary>
    /// Lógica de interacción para RegistrarVehiculo.xaml
    /// </summary>
    public partial class RegistrarVehiculo : Window
    {
        public RegistrarVehiculo()
        {
            InitializeComponent();
        }


        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuDelegacionMunicipal ventanaMenu = new MenuDelegacionMunicipal();
            ventanaMenu.Show();
            this.Close();
        }

        private void button_Chat_Click(object sender, RoutedEventArgs e)
        {
            Chat ventanaChat = new Chat();
            ventanaChat.Show();
        }

        private void button_CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
            this.Close();
        }

        private void button_Aceptar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_NuevoVehiculo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
