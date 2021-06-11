using DireccionGeneral.GUIDireccionGeneral;
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

namespace SGRV.GUIDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para MenuDireccionGeneral.xaml
    /// </summary>
    public partial class MenuDireccionGeneral : Window
    {
        public MenuDireccionGeneral()
        {
            InitializeComponent();
            button_RegistrarUsuario.Visibility = Visibility.Hidden;
            button_ModificarUsuario.Visibility = Visibility.Hidden;
            button_EliminarUsuario.Visibility = Visibility.Hidden;

            button_VisualizarReporte.Visibility = Visibility.Hidden;

            button_RegistrarDelegacion.Visibility = Visibility.Hidden;
            button_ModificarDelegacion.Visibility = Visibility.Hidden;
            button_EliminarDelegacion.Visibility = Visibility.Hidden;
        }


        private void button_Usuario_Click(object sender, RoutedEventArgs e)
        {
            button_Usuario.Visibility = Visibility.Hidden;
            button_RegistrarUsuario.Visibility = Visibility.Visible;
            button_ModificarUsuario.Visibility = Visibility.Visible;
            button_EliminarUsuario.Visibility = Visibility.Visible;

            button_VisualizarReporte.Visibility = Visibility.Hidden;

            button_RegistrarDelegacion.Visibility = Visibility.Hidden;
            button_ModificarDelegacion.Visibility = Visibility.Hidden;
            button_EliminarDelegacion.Visibility = Visibility.Hidden;

            button_Reporte.Visibility = Visibility.Visible;
            button_DelegacionesMunicipales.Visibility = Visibility.Visible;
        }

        private void button_Reporte_Click(object sender, RoutedEventArgs e)
        {
            button_Reporte.Visibility = Visibility.Hidden;
            button_VisualizarReporte.Visibility = Visibility.Hidden;

            button_RegistrarUsuario.Visibility = Visibility.Hidden;
            button_ModificarUsuario.Visibility = Visibility.Hidden;
            button_EliminarUsuario.Visibility = Visibility.Hidden;

            button_RegistrarDelegacion.Visibility = Visibility.Hidden;
            button_ModificarDelegacion.Visibility = Visibility.Hidden;
            button_EliminarDelegacion.Visibility = Visibility.Hidden;

            button_Usuario.Visibility = Visibility.Visible;
            button_DelegacionesMunicipales.Visibility = Visibility.Visible;
        }

        private void button_DelegacionesMunicipales_Click(object sender, RoutedEventArgs e)
        {
            button_DelegacionesMunicipales.Visibility = Visibility.Hidden;
            button_RegistrarDelegacion.Visibility = Visibility.Visible;
            button_ModificarDelegacion.Visibility = Visibility.Visible;
            button_EliminarDelegacion.Visibility = Visibility.Visible;

            button_RegistrarUsuario.Visibility = Visibility.Hidden;
            button_ModificarUsuario.Visibility = Visibility.Hidden;
            button_EliminarUsuario.Visibility = Visibility.Hidden; 

            button_VisualizarReporte.Visibility = Visibility.Hidden;

            button_Usuario.Visibility = Visibility.Visible;
            button_Reporte.Visibility = Visibility.Visible;
        }

        private void button_RegistrarUsuario_Click(object sender, RoutedEventArgs e)
        {
            RegistrarUsuario ventanaRegistrarUsuario = new RegistrarUsuario();
            ventanaRegistrarUsuario.Show();
            this.Close();
        }

        private void button_RegistrarDelegacion_Click(object sender, RoutedEventArgs e)
        {
            RegistrarDelegacion ventanaRegistrarDelegacionMunicipal = new RegistrarDelegacion();
            ventanaRegistrarDelegacionMunicipal.Show();
            this.Close();
        }

        private void button_ModificarUsuario_Click(object sender, RoutedEventArgs e)
        {
            ModificarUsuario ventanaModificarUsuario = new ModificarUsuario();
            ventanaModificarUsuario.Show();
            this.Close();
        }

        private void button_VisualizarReporte_Click(object sender, RoutedEventArgs e)
        {
            VisualizarReporte ventanaVisualizarReporte = new VisualizarReporte();
            ventanaVisualizarReporte.Show();
            this.Close();
        }

        private void button_ModificarDelegacion_Click(object sender, RoutedEventArgs e)
        {
            ModificarDelegacion ventanaModificarDelegacionMunicipal = new ModificarDelegacion();
            ventanaModificarDelegacionMunicipal.Show();
            this.Close();
        }

        private void button_EliminarUsuarior_Click(object sender, RoutedEventArgs e)
        {
            EliminarUsuario ventanaEliminarUsuario = new EliminarUsuario();
            ventanaEliminarUsuario.Show();
            this.Close();
        }

        private void button_EliminarDelegacion_Click(object sender, RoutedEventArgs e)
        {
            EliminarDelegacion ventanaEliminarDelegacionMunicipal = new EliminarDelegacion();
            ventanaEliminarDelegacionMunicipal.Show();
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

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
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
