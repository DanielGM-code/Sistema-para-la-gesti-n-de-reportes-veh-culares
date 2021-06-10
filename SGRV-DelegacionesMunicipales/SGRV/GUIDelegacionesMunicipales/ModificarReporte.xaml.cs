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
    /// Lógica de interacción para ModificarReporte.xaml
    /// </summary>
    public partial class ModificarReporte : Window
    {
        private Reporte reporteSeleccionado;
        private List<Conductor> conductoresSeleccionados;
        private List<Vehiculo> vehiculosSeleccionados;
        private Conductor conductorSeleccionado;
        private Vehiculo vehiculoSeleccionado;
        private Conductor conductorElegido;
        private Vehiculo vehiculoElegido;

        public ModificarReporte()
        {
            InitializeComponent();
            llenarTablaReportes();
            llenarTablaConductores();
            conductoresSeleccionados = new List<Conductor>();
            vehiculosSeleccionados = new List<Vehiculo>();
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

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void seleccionar_conductor(object sender, SelectionChangedEventArgs e)
        {

        }

        private void clic_reporte(object sender, SelectionChangedEventArgs e)
        {
            reporteSeleccionado = (Reporte)dg_reportes.SelectedItem;
            

            if(reporteSeleccionado != null)
            {
                dp_fecha.SelectedDate = reporteSeleccionado.Fecha;
                tb_Descripcion.Text = reporteSeleccionado.Descripcion;
                tb_direccion.Text = reporteSeleccionado.Direccion;

                conductoresSeleccionados = new List<Conductor>();
                List<ConductoresReporte> conductoresDelReporte = ConductoresReporteDAO.getAllConductoresReportesByIdReporte(reporteSeleccionado.IdReporte);
                Conductor conductor;
                foreach(ConductoresReporte conductoresReporte in conductoresDelReporte)
                {
                    conductor = ConductorDAO.getConductoraById(conductoresReporte.IdConductor);
                    conductoresSeleccionados.Add(conductor);
                }

                vehiculosSeleccionados = new List<Vehiculo>();
                List<VehiculosReporte> vehiculosDelReporte = VehiculosReporteDAO.getAllVehiculosReporteByIdReporte(reporteSeleccionado.IdReporte);
                Vehiculo vehiculo;
                foreach(VehiculosReporte vehiculosReporte in vehiculosDelReporte)
                {
                    vehiculo = VehiculoDAO.getVehiculoById(vehiculosReporte.IdVehiculo);
                    vehiculosSeleccionados.Add(vehiculo);
                }

                actualizarTablaConductoresSeleccionados();
                actualizarTablaVehiculosSeleccionados();
            }
        }

        private void clic_Conductor(object sender, SelectionChangedEventArgs e)
        {
            conductorSeleccionado = (Conductor)dg_conductores.SelectedItem;
            if (conductorSeleccionado != null)
            {
                llenarTablaVehiculos(conductorSeleccionado);
            }
        }

        private void dg_vehiculosSeleccionados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_agregarFotografia_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_ModificarReporte_Click(object sender, RoutedEventArgs e)
        {

        }


        private void btn_eliminarConductor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_eliminarVehiculo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void clic_vehiculo(object sender, SelectionChangedEventArgs e)
        {

        }

        private void llenarTablaReportes()
        {
            dg_reportes.ItemsSource = ReporteDAO.getAllReportes();
        }

        private void llenarTablaConductores()
        {
            dg_conductores.ItemsSource = ConductorDAO.getAllConductores();
        }

        private void llenarTablaVehiculos(Conductor conductor)
        {
            dg_vehiculos.ItemsSource = VehiculoDAO.getAllVehiculosByIdConductor(conductor.IdConductor);
        }

        private void actualizarTablaConductoresSeleccionados()
        {
            List<Conductor> conductors = new List<Conductor>();
            foreach (Conductor conductor in conductoresSeleccionados)
            {
                conductors.Add(conductor);
            }
            dg_conductoresSeleccionados.ItemsSource = conductors;
        }

        private void actualizarTablaVehiculosSeleccionados()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            foreach (Vehiculo vehiculo in vehiculosSeleccionados)
            {
                vehiculos.Add(vehiculo);
            }
            dg_vehiculosSeleccionados.ItemsSource = vehiculos;
        }
    }
}
