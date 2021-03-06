using SGRV;
using SGRV.GUIDelegacionesMunicipales;
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

namespace DelegacionesMunicipales.GUIDelegacionesMunicipales
{
    /// <summary>
    /// Lógica de interacción para ElimarVehiculo.xaml
    /// </summary>
    public partial class ElimarVehiculo : Window
    {
        String username;
        List<Conductor> conductores;
        List<Vehiculo> vehiculo;
        List<Vehiculo> vehiculos;
        Conductor conductorSeleccionado;
        Vehiculo vehiculoSeleccionado;
        public ElimarVehiculo(String username)
        {
            InitializeComponent();
            this.username = username;
            conductores = new List<Conductor>();
            llenarTablaConductores();
        }

        private void button_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (vehiculoSeleccionado != null)
                {
                    VehiculoDAO.removeVehiculo(vehiculoSeleccionado);
                    MessageBox.Show("Vehiculo eliminado de manera exitosa.");
                    limpiarCampos();
                    llenarTablaVehiculos(conductorSeleccionado);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            }
        }

        private void llenarTablaConductores()
        {
            conductores = ConductorDAO.getAllConductores();
            dg_conductores.AutoGenerateColumns = false;
            dg_conductores.ItemsSource = conductores;
        }

        private void llenarTablaVehiculos(Conductor conductor)
        {
            vehiculos = VehiculoDAO.getAllVehiculosByIdConductor(conductor.IdConductor);
            dg_vehiculos.ItemsSource = vehiculos;
        }

        private void clic_conductor_item(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                limpiarCampos();
                conductorSeleccionado = (Conductor)dg_conductores.SelectedItem;

                if (conductorSeleccionado != null)
                {
                    tb_nombreConductor.Text = conductorSeleccionado.Nombre;
                    llenarTablaVehiculos(conductorSeleccionado);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message + "Ocurrió un error");
            }

        }

        private void clic_vehiculo_item(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                vehiculoSeleccionado = (Vehiculo)dg_vehiculos.SelectedItem;
                if (vehiculoSeleccionado != null)
                {
                    tb_año.Text = vehiculoSeleccionado.Ano;
                    tb_color.Text = vehiculoSeleccionado.Color;
                    tb_marca.Text = vehiculoSeleccionado.Marca;
                    tb_modelo.Text = vehiculoSeleccionado.Modelo;
                    tb_nombreAseguradora.Text = vehiculoSeleccionado.NombreAseguradora;
                    tb_numeroPlacas.Text = vehiculoSeleccionado.Placas;
                    tb_numeroPolizaSeguro.Text = vehiculoSeleccionado.PolizaSeguro;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message + "Ocurrió un error");
            }

        }

        private bool validarCampos()
        {
            return (tb_marca.Text == "" ||
                    tb_modelo.Text == "" ||
                    tb_nombreAseguradora.Text == "" ||
                    tb_numeroPlacas.Text == "" ||
                    tb_año.Text == "" ||
                    tb_color.Text == "" ||
                    tb_numeroPolizaSeguro.Text == "") ? false : true;
        }

        private void limpiarCampos()
        {
            tb_marca.Text = "";
            tb_modelo.Text = "";
            tb_nombreAseguradora.Text = "";
            tb_numeroPlacas.Text = "";
            tb_año.Text = "";
            tb_color.Text = "";
            tb_numeroPolizaSeguro.Text = "";
            tb_nombreConductor.Text = "";
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
    }
}
