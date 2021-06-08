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
    /// Lógica de interacción para ModificarVehiculo.xaml
    /// </summary>
    public partial class ModificarVehiculo : Window
    {
        List<Conductor> conductors;
        List<Vehiculo> vehiculo;
        List<Vehiculo> vehiculos;
        Conductor conductorSeleccionado;
        Vehiculo vehiculoSeleccionado;

        public ModificarVehiculo()
        {
            InitializeComponent();
            conductors = new List<Conductor>();
            llenarTablaConductores();
        }

        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if(validarCampos())
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Marca = tb_marca.Text;
                vehiculo.Modelo = tb_modelo.Text;
                vehiculo.Ano = tb_año.Text;
                vehiculo.Color = tb_color.Text;
                vehiculo.NombreAseguradora = tb_nombreAseguradora.Text;
                vehiculo.PolizaSeguro = tb_numeroPolizaSeguro.Text;
                vehiculo.Placas = tb_numeroPlacas.Text;
                vehiculo.IdConductor = conductorSeleccionado.IdConductor;
                vehiculo.Estado = "Activo";
                try
                {
                    //VehiculoDAO.addVehiculo(vehiculo);
                    //MessageBox.Show("Vehículo registrado con éxito.");
                    //limpiarCampos();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message + "Ocurrió un error");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private void llenarTablaConductores()
        {
            conductors = ConductorDAO.getAllConductores();
            dg_conductores.AutoGenerateColumns = false;
            dg_conductores.ItemsSource = conductors;
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
                conductorSeleccionado = (Conductor)dg_conductores.SelectedItem;
                llenarTablaVehiculos(conductorSeleccionado);
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
                tb_año.Text = vehiculoSeleccionado.Ano;
                tb_color.Text = vehiculoSeleccionado.Color;
                tb_marca.Text = vehiculoSeleccionado.Marca;
                tb_modelo.Text = vehiculoSeleccionado.Modelo;
                tb_nombreAseguradora.Text = vehiculoSeleccionado.NombreAseguradora;
                tb_numeroPlacas.Text = vehiculoSeleccionado.Placas;
                tb_numeroPolizaSeguro.Text = vehiculoSeleccionado.PolizaSeguro;
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
                    tb_numeroPolizaSeguro.Text == "" ||
                    tb_nombreConductor.Text == "") ? false : true;
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
            MenuDelegacionMunicipal ventanaMenuDelegacionMunicipal = new MenuDelegacionMunicipal();
            ventanaMenuDelegacionMunicipal.Show();
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
    }
}
