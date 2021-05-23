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
    /// Lógica de interacción para RegistrarVehiculo.xaml
    /// </summary>
    public partial class RegistrarVehiculo : Window
    {
        List<Conductor> conductors;
        Conductor conductorSeleccionado;

        public RegistrarVehiculo()
        {
            InitializeComponent();
            conductors = new List<Conductor>();
            llenarTabla();
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

        private void button_Registrar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
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
                VehiculoDAO.addVehiculo(vehiculo);
                MessageBox.Show("Vehículo registrado con éxito.");
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private void llenarTabla()
        {
            conductors = ConductorDAO.getAllConductores();
            dg_conductores.AutoGenerateColumns = false;
            dg_conductores.ItemsSource = conductors;
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


        private void clic_conductor_item(object sender, SelectionChangedEventArgs e)
        {
            conductorSeleccionado = (Conductor)dg_conductores.SelectedItem;
            tb_nombreConductor.Text = conductorSeleccionado.Nombre;
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
    }
}
