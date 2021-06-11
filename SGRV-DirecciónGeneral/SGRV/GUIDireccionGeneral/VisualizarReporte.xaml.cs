using SGRV;
using SGRV.GUIDireccionGeneral;
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

namespace DireccionGeneral.GUIDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para VisualizarReporte.xaml
    /// </summary>
    public partial class VisualizarReporte : Window
    {
        String username;
        List<Reporte> reportes;
        List<Reporte> reportesFiltrados;
        private Reporte reporteSeleccionado;
        private List<Conductor> conductoresSeleccionados;
        private List<Vehiculo> vehiculosSeleccionados;
        List<String> directoriosCreados;
        List<Image> fotografias;
        public VisualizarReporte(String username)
        {
            InitializeComponent();
            this.username = username;
            conductoresSeleccionados = new List<Conductor>();
            vehiculosSeleccionados = new List<Vehiculo>();
            reportes = new List<Reporte>();
            reportesFiltrados = new List<Reporte>();
            directoriosCreados = new List<string>();
            fotografias = new List<Image>();
            llenarTablaReportes();

        }

        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuDireccionGeneral ventanaMenuDireccionGeneral = new MenuDireccionGeneral(username);
            ventanaMenuDireccionGeneral.Show();
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
                foreach (FileInfo fileInfo in fileInfos)
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
            DictaminarReporte ventanaDictamen = new DictaminarReporte(reporteSeleccionado.IdReporte);
            ventanaDictamen.Show();
        }

        private void llenarTablaReportes()
        {
            dg_reportes.ItemsSource = ReporteDAO.getAllReportes();
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

        private void filtrarTabla()
        {
            reportes = ReporteDAO.getAllReportes();
            String busqueda = tb_reporte.Text;

            foreach (Reporte reporte in reportes)
            {
                if (reporte.Direccion.ToLower() == busqueda.ToLower() ||
                    reporte.Estado.ToLower() == busqueda.ToLower() ||
                    reporte.Fecha.ToString() == busqueda ||
                    reporte.Fecha.ToString().ToLower().Contains(busqueda))
                {
                    reportesFiltrados.Add(reporte);
                }
            }

            if (reportesFiltrados.Count > 0)
            {
                dg_reportes.ItemsSource = reportesFiltrados;
            }
            else
            {
                llenarTablaReportes();
            }
        }

        private void button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            filtrarTabla();
        }
    }
}
