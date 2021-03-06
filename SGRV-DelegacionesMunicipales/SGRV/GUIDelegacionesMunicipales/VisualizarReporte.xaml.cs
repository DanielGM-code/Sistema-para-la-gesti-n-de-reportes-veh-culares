using SGRV;
using SGRV.GUIDelegacionesMunicipales;
using SGRV.modelo.dao;
using SGRV.modelo.database;
using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Lógica de interacción para VisualizarReporte.xaml
    /// </summary>
    public partial class VisualizarReporte : Window
    {
        String username;
        private Reporte reporteSeleccionado;
        private List<Conductor> conductoresSeleccionados;
        private List<Vehiculo> vehiculosSeleccionados;
        List<String> directoriosCreados;
        List<Image> fotografias;
        List<Reporte> reportes;

        public VisualizarReporte(String username)
        {
            InitializeComponent();
            this.username = username;
            conductoresSeleccionados = new List<Conductor>();
            vehiculosSeleccionados = new List<Vehiculo>();
            directoriosCreados = new List<string>();
            fotografias = new List<Image>();
            reportes = new List<Reporte>();
            llenarTablaReportes();
            
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

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clic_reporte(object sender, SelectionChangedEventArgs e)
        {
            reporteSeleccionado = (Reporte)dg_reportes.SelectedItem;


            if (reporteSeleccionado != null)
            {
                wp_imagenes.Children.Clear();
                dp_fecha.SelectedDate = reporteSeleccionado.Fecha;
                tb_Descripcion.Text = reporteSeleccionado.Descripcion;
                tb_direccion.Text = reporteSeleccionado.Direccion;

                conductoresSeleccionados = new List<Conductor>();
                List<ConductoresReporte> conductoresDelReporte = ConductoresReporteDAO.getAllConductoresReportesByIdReporte(reporteSeleccionado.IdReporte);
                Conductor conductor;
                foreach (ConductoresReporte conductoresReporte in conductoresDelReporte)
                {
                    conductor = ConductorDAO.getConductoraById(conductoresReporte.IdConductor);
                    conductoresSeleccionados.Add(conductor);
                }

                vehiculosSeleccionados = new List<Vehiculo>();
                List<VehiculosReporte> vehiculosDelReporte = VehiculosReporteDAO.getAllVehiculosReporteByIdReporte(reporteSeleccionado.IdReporte);
                Vehiculo vehiculo;
                foreach (VehiculosReporte vehiculosReporte in vehiculosDelReporte)
                {
                    vehiculo = VehiculoDAO.getVehiculoById(vehiculosReporte.IdVehiculo);
                    vehiculosSeleccionados.Add(vehiculo);
                }

                String actualPath = actualPath = System.IO.Path.GetTempPath();
                String folderName = String.Format("/Reporte{0}", reporteSeleccionado.IdReporte);
                String newPath = actualPath + folderName;
                DirectoryInfo directory = Directory.CreateDirectory(newPath);
                

                ConexionSFTP.bajarArchivo(newPath, folderName);

                FileInfo[] fileInfos = directory.GetFiles();

                Image fotografia = new Image();
                foreach(FileInfo fileInfo in fileInfos)
                {
                    if (fileInfo.FullName != null)
                    {
                        Uri uri = new Uri(fileInfo.FullName);
                        fotografia = new Image();
                        fotografia.Source = new BitmapImage(uri);
                        fotografia.Width = 100;
                        fotografia.Height = 100;
                        wp_imagenes.Children.Add(fotografia);
                        fotografias.Add(fotografia);
                    }
                }
                actualizarTablaConductoresSeleccionados();
                actualizarTablaVehiculosSeleccionados();
            }
        }

        private void button_VerDictamen_Click(object sender, RoutedEventArgs e)
        {
            if (reporteSeleccionado != null)
            {
                VerDictamen ventanaVerDictamen = new VerDictamen(reporteSeleccionado.IdReporte);
                try
                {
                    ventanaVerDictamen.ShowDialog();
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un reporte.");
            }
        }

        private void llenarTablaReportes()
        {
            reportes = ReporteDAO.getAllReportes();
            dg_reportes.ItemsSource = reportes;
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

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void button_BuscarReporte_Click(object sender, RoutedEventArgs e)
        {
            String busqueda = tb_busqueda.Text.ToLower();
            if(busqueda != "")
            {
                List<Reporte> reportesFiltrados = new List<Reporte>();
                foreach(Reporte reporte in reportes)
                {
                    if (reporte.Descripcion.ToLower().Contains(busqueda) ||
                        reporte.Direccion.ToLower().Contains(busqueda) ||
                        reporte.Fecha.ToString() == busqueda){
                        reportesFiltrados.Add(reporte);
                    }
                    dg_reportes.ItemsSource = reportesFiltrados;
                }
            }
            else
            {
                llenarTablaReportes();
            }
        }
    }
}
