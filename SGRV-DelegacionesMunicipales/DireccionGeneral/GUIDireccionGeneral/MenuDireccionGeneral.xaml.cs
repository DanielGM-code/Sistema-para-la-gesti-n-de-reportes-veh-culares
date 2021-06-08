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
        }

        private void button_RegistroUsuarios_Click(object sender, RoutedEventArgs e)
        {
            RegistrarUsuario ventanaRegistrarUsuario = new RegistrarUsuario();
            ventanaRegistrarUsuario.Show();
            this.Close();
        }

        private void button_RegistroDelegacionesMunicipales_Click(object sender, RoutedEventArgs e)
        {
            RegistrarDelegacionMunicipal ventanaRegistrarDelegacionMunicipal = new RegistrarDelegacionMunicipal();
            ventanaRegistrarDelegacionMunicipal.Show();
            this.Close();
        }

        private void button_VizualizarReportes_Click(object sender, RoutedEventArgs e)
        {
            VizualizarReporte VentanaVizualizarReporte = new VizualizarReporte();
            VentanaVizualizarReporte.Show();
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

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
