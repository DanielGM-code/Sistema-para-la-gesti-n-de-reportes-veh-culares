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
    /// Lógica de interacción para ModificarConductor.xaml
    /// </summary>
    public partial class ModificarConductor : Window
    {
        List<Conductor> conductores;
        Conductor conductorSeleccionado;
        String username;

        public ModificarConductor(String username)
        {
            InitializeComponent();
            this.username = username;
            conductores = new List<Conductor>();
            llenarTabla();
        }


        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Conductor conductor = new Conductor();
                conductor.IdConductor = conductorSeleccionado.IdConductor;
                conductor.Nombre = tb_nombre.Text;
                conductor.FechaNacimiento = (DateTime)dp_fehcaNacimiento.SelectedDate;
                conductor.NumeroLicencia = tb_licencia.Text;
                conductor.Telefono = tb_telefono.Text;
                conductor.Estado = "Activo";

                try
                {
                    if (conductorSeleccionado != null)
                    {
                        ConductorDAO.updateConductor(conductor);
                        MessageBox.Show("Conductor modificado de manera exitosa.");
                        vaciarCampos();
                        llenarTabla();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
                }

            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private bool validarCampos()
        {
            return (tb_nombre.Text == "" ||
                    tb_licencia.Text == "" ||
                    tb_telefono.Text == "" ||
                    dp_fehcaNacimiento.SelectedDate == null) ? false : true;
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
            if (busqueda != "")
            {
                List<Conductor> conductoresFiltrados = new List<Conductor>();
                foreach (Conductor conductor in conductores)
                {
                    if (conductor.Nombre.ToLower() == busqueda.ToLower() ||
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

        private void tb_licencia_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tb_telefono_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
