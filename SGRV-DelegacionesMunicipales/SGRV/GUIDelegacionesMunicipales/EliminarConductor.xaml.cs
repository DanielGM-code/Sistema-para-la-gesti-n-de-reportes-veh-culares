using SGRV.modelo.dao;
using SGRV.modelo.poco;
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
    /// Lógica de interacción para EliminarConductor.xaml
    /// </summary>
    public partial class EliminarConductor : Window
    {
        List<Conductor> conductores;
        Conductor conductorSeleccionado;
        String username;

        public EliminarConductor(String username)
        {
            InitializeComponent();
            this.username = username;
            conductores = new List<Conductor>();
            llenarTabla();
        }

        private void button_Eliminar_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if(conductorSeleccionado != null)
                {
                    ConductorDAO.removeConductor(conductorSeleccionado);
                    MessageBox.Show("Conductor eliminado de manera exitosa.");
                    vaciarCampos();
                    llenarTabla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            }
        }

        private void vaciarCampos()
        {
            tb_nombre.Text = "";
            tb_licencia.Text = "";
            tb_telefono.Text = "";
            dp_fehcaNacimiento.SelectedDate = null;
        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuDelegacionMunicipal ventanaMenuDelegacionMunicipal = new MenuDelegacionMunicipal(username);
            ventanaMenuDelegacionMunicipal.Show();
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

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void llenarTabla()
        {
            conductores = ConductorDAO.getAllConductores();
            dg_conductores.AutoGenerateColumns = false;
            dg_conductores.ItemsSource = conductores;
        }

        private void clic_conductor_item(object sender, SelectionChangedEventArgs e)
        {
            conductorSeleccionado = (Conductor)dg_conductores.SelectedItem;
            if (conductorSeleccionado != null)
            {
                
                tb_nombreConductor.Text = conductorSeleccionado.Nombre;
                tb_nombre.Text = conductorSeleccionado.Nombre;
                tb_licencia.Text = conductorSeleccionado.NumeroLicencia;
                tb_telefono.Text = conductorSeleccionado.Telefono;
                DateTime fechaNacimiento = conductorSeleccionado.FechaNacimiento;
                dp_fehcaNacimiento.SelectedDate = fechaNacimiento;
            }
        }

        private void button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            String busqueda = tb_nombreConductor.Text;
            if(busqueda != "")
            {
                List<Conductor> conductoresFiltrados = new List<Conductor>();
                foreach(Conductor conductor in conductores)
                {
                    if(conductor.Nombre.ToLower() == busqueda.ToLower() ||
                        conductor.NumeroLicencia == busqueda ||
                        conductor.Telefono == busqueda ||
                        conductor.Nombre.ToLower().Contains(busqueda.ToLower()))
                    {
                        conductoresFiltrados.Add(conductor);
                    }
                }
                dg_conductores.ItemsSource = conductoresFiltrados;
                
            }
            else
            {
                llenarTabla();
            }
        }
    }
}
