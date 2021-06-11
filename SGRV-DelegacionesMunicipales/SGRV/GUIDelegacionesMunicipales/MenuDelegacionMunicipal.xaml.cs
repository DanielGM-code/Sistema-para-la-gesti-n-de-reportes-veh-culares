using DelegacionesMunicipales.GUIDelegacionesMunicipales;
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

namespace SGRV.GUIDelegacionesMunicipales
{
    /// <summary>
    /// Lógica de interacción para MenuDelegacionMunicipal.xaml
    /// </summary>
    public partial class MenuDelegacionMunicipal : Window
    {
        String username;

        public MenuDelegacionMunicipal( String username)
        {
            InitializeComponent();
            this.username = username;

            button_RegistrarConductor.Visibility = Visibility.Hidden;
            button_ModificarConductor.Visibility = Visibility.Hidden;
            button_EliminarConductor.Visibility = Visibility.Hidden;

            button_RegistrarVehiculo.Visibility = Visibility.Hidden;
            button_ModificarVehiculo.Visibility = Visibility.Hidden;
            button_EliminarVehiculo.Visibility = Visibility.Hidden;

            button_RegistrarReporte.Visibility = Visibility.Hidden;
            button_HistorialReporte.Visibility = Visibility.Hidden;
        }

        private void button_Conductor_Click(object sender, RoutedEventArgs e)
        {
            button_Conductor.Visibility = Visibility.Hidden;
            button_RegistrarConductor.Visibility = Visibility.Visible;
            button_ModificarConductor.Visibility = Visibility.Visible;
            button_EliminarConductor.Visibility = Visibility.Visible;

            button_RegistrarVehiculo.Visibility = Visibility.Hidden;
            button_ModificarVehiculo.Visibility = Visibility.Hidden;
            button_EliminarVehiculo.Visibility = Visibility.Hidden;

            button_RegistrarReporte.Visibility = Visibility.Hidden;
            button_HistorialReporte.Visibility = Visibility.Hidden;

            button_Vehiculo.Visibility = Visibility.Visible;
            button_Reporte.Visibility = Visibility.Visible;
        }

        private void button_Vehiculo_Click(object sender, RoutedEventArgs e)
        {
            button_Vehiculo.Visibility = Visibility.Hidden;
            button_RegistrarVehiculo.Visibility = Visibility.Visible;
            button_ModificarVehiculo.Visibility = Visibility.Visible;
            button_EliminarVehiculo.Visibility = Visibility.Visible;

            button_RegistrarConductor.Visibility = Visibility.Hidden;
            button_ModificarConductor.Visibility = Visibility.Hidden;
            button_EliminarConductor.Visibility = Visibility.Hidden;

            button_RegistrarReporte.Visibility = Visibility.Hidden;
            button_HistorialReporte.Visibility = Visibility.Hidden;

            button_Conductor.Visibility = Visibility.Visible;
            button_Reporte.Visibility = Visibility.Visible;
        }

        private void button_Reporte_Click(object sender, RoutedEventArgs e)
        {
            button_Reporte.Visibility = Visibility.Hidden;
            button_RegistrarReporte.Visibility = Visibility.Visible;
            button_HistorialReporte.Visibility = Visibility.Visible;

            button_RegistrarConductor.Visibility = Visibility.Hidden;
            button_ModificarConductor.Visibility = Visibility.Hidden;
            button_EliminarConductor.Visibility = Visibility.Hidden;

            button_RegistrarVehiculo.Visibility = Visibility.Hidden;
            button_ModificarVehiculo.Visibility = Visibility.Hidden;
            button_EliminarVehiculo.Visibility = Visibility.Hidden;

            button_Conductor.Visibility = Visibility.Visible;
            button_Vehiculo.Visibility = Visibility.Visible;
        }


        private void button_RegistrarConductor_Click(object sender, RoutedEventArgs e)
        {
            RegistrarConductor ventanaRegistrarConductor = new RegistrarConductor(username);
            ventanaRegistrarConductor.Show();
            this.Close();
        }

        private void button_RegistrarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            RegistrarVehiculo ventanaRegistrarVehiculo = new RegistrarVehiculo(username);
            ventanaRegistrarVehiculo.Show();
            this.Close();
        }

        private void button_RegistrarReporte_Click(object sender, RoutedEventArgs e)
        {
            RegistrarReporte ventanaRegistrarReporte = new RegistrarReporte(username);
            ventanaRegistrarReporte.Show();
            this.Close();
        }


        private void button_ModificarConductor_Click(object sender, RoutedEventArgs e)
        {
            ModificarConductor ventanaModificarConductor = new ModificarConductor(username);
            ventanaModificarConductor.Show();
            this.Close();
        }

        private void button_ModificarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            ModificarVehiculo ventanaModificarVehiculo = new ModificarVehiculo(username);
            ventanaModificarVehiculo.Show();
            this.Close();
        }

        private void button_ModificarReporte_Click(object sender, RoutedEventArgs e)
        {
            VisualizarReporte ventanaVisualizarReporte = new VisualizarReporte(username);
            ventanaVisualizarReporte.Show();
            this.Close();
        }


        private void button_EliminarConductor_Click(object sender, RoutedEventArgs e)
        {
            EliminarConductor ventanaEliminarConductor = new EliminarConductor(username);
            ventanaEliminarConductor.Show();
            this.Close();
        }

        private void button_EliminarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            ElimarVehiculo ventanaEliminarVehiculo = new ElimarVehiculo(username);
            ventanaEliminarVehiculo.Show();
            this.Close();
        }

        private void button_Chat_Click(object sender, RoutedEventArgs e)
        {
            Chat ventanaChat = new Chat(username);
            ventanaChat.Show();
        }

        private void button_CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            Login ventanaLogin = new Login();
            ventanaLogin.Show();
            this.Close();
        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void button_HistorialReporte_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
