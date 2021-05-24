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
        public MenuDelegacionMunicipal()
        {
            InitializeComponent();
        }

        private void button_RegistrarConductor_Click(object sender, RoutedEventArgs e)
        {
            RegistrarConductor ventanaRegistrarConductor = new RegistrarConductor();
            ventanaRegistrarConductor.Show();
            this.Close();
        }

        private void button_RegistrarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            RegistrarVehiculo ventanaRegistrarVehiculo = new RegistrarVehiculo();
            ventanaRegistrarVehiculo.Show();
            this.Close();
        }

        private void button_RegistrarReporte_Click(object sender, RoutedEventArgs e)
        {
            RegistrarReporte ventanaRegistrarReporte = new RegistrarReporte();
            ventanaRegistrarReporte.Show();
            this.Close();
        }

        private void button_HistorialReportes_Click(object sender, RoutedEventArgs e)
        {
            HistorialReportes ventanaHistorialReportes = new HistorialReportes();
            ventanaHistorialReportes.Show();
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

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
