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

namespace SGRV.GUIDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para RegistrarDelegacion.xaml
    /// </summary>
    public partial class RegistrarDelegacion : Window
    {
        public RegistrarDelegacion()
        {
            InitializeComponent();
        }

        private void button_Registrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Chat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_CerrarSesion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
