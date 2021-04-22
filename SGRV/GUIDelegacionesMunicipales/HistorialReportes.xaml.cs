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
    /// Lógica de interacción para HistorialReportes.xaml
    /// </summary>
    public partial class HistorialReportes : Window
    {
        public HistorialReportes()
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

        private void button_button_Modificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_button_Eliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_VerDictamen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
