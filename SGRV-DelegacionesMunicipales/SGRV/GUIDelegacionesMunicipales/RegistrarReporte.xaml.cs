using Microsoft.Win32;
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

namespace SGRV.GUIDelegacionesMunicipales
{
    /// <summary>
    /// Lógica de interacción para RegistrarReporte.xaml
    /// </summary>
    public partial class RegistrarReporte : Window
    {
        String username;
        List<Conductor> conductores;
        List<Conductor> conductoresSeleccionados;
        Conductor conductorSeleccionado;
        Conductor conductorElegido;
        List<Vehiculo> vehiculos;
        List<Vehiculo> vehiculosSeleccionados;
        Vehiculo vehiculoSeleccionado;
        Vehiculo vehiculoElegido;
        List<Image> images;
        List<Reporte> reportes;

        public RegistrarReporte(String username)
        {
            InitializeComponent();
            this.username = username;
            conductores = new List<Conductor>();
            conductoresSeleccionados = new List<Conductor>();
            vehiculos = new List<Vehiculo>();
            vehiculosSeleccionados = new List<Vehiculo>();
            vehiculosSeleccionados = new List<Vehiculo>();
            images = new List<Image>();
            reportes = new List<Reporte>();
            llenarTablaConductores();
        }

        private void button_RegistrarReporte_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                if (conductoresSeleccionados.Count > 0)
                {
                    if (vehiculosSeleccionados.Count > 0)
                    {
                        if (images.Count >= 3)
                        {
                            Reporte reporte = new Reporte();
                            reporte.Direccion = tb_direccion.Text;
                            reporte.Descripcion = tb_descripcion.Text;
                            reporte.Fecha = (DateTime)dp_fecha.SelectedDate;
                            reporte.Estado = "Activo";
                            ReporteDAO.addReporte(reporte);

                            int ultimoReporte = ReporteDAO.getLastIndex();

                            Dictamen dictamen = new Dictamen();
                            dictamen.Descripcion = "";
                            dictamen.Estado = "Activo";
                            dictamen.Fecha = (DateTime)dp_fecha.SelectedDate;
                            string hora = DateTime.Now.ToString("t");
                            dictamen.Hora = hora;
                            dictamen.IdPerito = 0;
                            dictamen.IdReporte = ultimoReporte;
                            dictamen.Folio = ultimoReporte;
                            DictamenDAO.addDictamen(dictamen);

                            

                            VehiculosReporte vehiculosReporte;
                            foreach (Vehiculo vehiculo in vehiculosSeleccionados)
                            {
                                vehiculosReporte = new VehiculosReporte();
                                vehiculosReporte.IdReporte = ultimoReporte;
                                vehiculosReporte.IdVehiculo = vehiculo.IdVehiculo;
                                VehiculosReporteDAO.addVehiculosReporte(vehiculosReporte);
                            }

                            ConductoresReporte conductoresReporte;
                            foreach (Conductor conductor in conductoresSeleccionados)
                            {
                                conductoresReporte = new ConductoresReporte();
                                conductoresReporte.IdReporte = ultimoReporte;
                                conductoresReporte.IdConductor = conductor.IdConductor;
                                ConductoresReporteDAO.addConductoresReporte(conductoresReporte);
                            }

                            try
                            {
                                foreach (Image imagen in images)
                                {
                                    String filepath = imagen.Source.ToString().Substring(8);
                                    String filename = String.Format("Reporte{0}", ultimoReporte);
                                    ConexionSFTP.subirArchivo(filepath, filename);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                throw;
                            }
                            MessageBox.Show("Registro exitoso.");
                            limpiarCampos(); 
                        }
                        else
                        {
                            MessageBox.Show("Debe seleccionar al menos 3 fotografías.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe elegir al menos un vehículo.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe elegir al menos un Conductor");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private void limpiarCampos()
        {
            tb_direccion.Text = "";
            tb_descripcion.Text = "";
            llenarTablaConductores();
            conductoresSeleccionados = new List<Conductor>();
            vehiculosSeleccionados = new List<Vehiculo>();
            actualizarTablaConductoresSeleccionados();
            actualizarTablaVehiculosSeleccionados();
            dp_fecha.SelectedDate = null;
            images = new List<Image>();
            wp_imagenes.Children.Clear();
            Conductor conductor = new Conductor();
            conductor.IdConductor = 0;
            llenarTablaVehiculos(conductor);
        }

        private void button_agregarFotografia_Click(object sender, RoutedEventArgs e)
        {
            if (wp_imagenes.Children.Count < 8)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                String filePath;
                String fileExtension;
                try
                {
                    openFileDialog.Multiselect = false;
                    openFileDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";
                    Nullable<bool> result = openFileDialog.ShowDialog();
                    if (result == true)
                    {
                        filePath = openFileDialog.FileName;
                        fileExtension = filePath.Substring(filePath.Length - 4, 4);


                        Image fotografia = new Image();
                        Uri uri = new Uri(filePath);
                        fotografia.Source = new BitmapImage(uri);
                        fotografia.Width = 100;
                        fotografia.Height = 100;
                        wp_imagenes.Children.Add(fotografia);
                        images.Add(fotografia);
                        String direccion = fotografia.Source.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El número máximo de fotografías por reporte es 8.");
            }
        }

        private void llenarTablaVehiculos(Conductor conductor)
        {
            vehiculos = VehiculoDAO.getAllVehiculosByIdConductor(conductor.IdConductor);
            dg_vehiculos.ItemsSource = vehiculos;
        }

        private void llenarTablaConductores()
        {
            conductores = ConductorDAO.getAllConductores();
            dg_conductores.ItemsSource = conductores;
        }

        private void btn_eliminarConductor_Click(object sender, RoutedEventArgs e)
        {
            if (conductorSeleccionado != null)
            {
                int idConductor = conductorSeleccionado.IdConductor;
                List<Vehiculo> vehiculosAEliminar = new List<Vehiculo>();
                foreach (Vehiculo vehiculo in vehiculosSeleccionados)
                {
                    if (vehiculo.IdConductor == idConductor)
                    {
                        vehiculosAEliminar.Add(vehiculo);
                    }
                }
                foreach (Vehiculo vehiculo in vehiculosAEliminar)
                {
                    vehiculosSeleccionados.Remove(vehiculo);
                }
                conductoresSeleccionados.Remove(conductorSeleccionado);
                actualizarTablaConductoresSeleccionados();
                actualizarTablaVehiculosSeleccionados();
                conductorSeleccionado = null;
            }
        }

        private void clic_Conductor(object sender, SelectionChangedEventArgs e)
        {
            conductorSeleccionado = (Conductor)dg_conductoresSeleccionados.SelectedItem;
        }

        private void seleccionar_conductor(object sender, SelectionChangedEventArgs e)
        {
            conductorElegido = (Conductor)dg_conductores.SelectedItem;
            if (conductorElegido != null)
            {
                llenarTablaVehiculos(conductorElegido); 
            }
        }

        private void actualizarTablaConductoresSeleccionados()
        {
            List<Conductor> conductors = new List<Conductor>();
            foreach(Conductor conductor in conductoresSeleccionados)
            {
                conductors.Add(conductor);
            }
            dg_conductoresSeleccionados.ItemsSource = conductors;
        }

        private void actualizarTablaVehiculosSeleccionados()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            foreach(Vehiculo vehiculo in vehiculosSeleccionados)
            {
                vehiculos.Add(vehiculo);
            }
            dg_vehiculosSeleccionados.ItemsSource = vehiculos;
        }

        private void clic_vehiculo(object sender, SelectionChangedEventArgs e)
        {
            vehiculoElegido = (Vehiculo)dg_vehiculos.SelectedItem;
            if (vehiculoElegido  != null)
            {
                if (!conductoresSeleccionados.Contains(conductorElegido))
                {
                    conductoresSeleccionados.Add(conductorElegido);
                }
                if (!vehiculosSeleccionados.Contains(vehiculoElegido))
                {
                    vehiculosSeleccionados.Add(vehiculoElegido);
                }
                actualizarTablaConductoresSeleccionados();
                actualizarTablaVehiculosSeleccionados();

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

        private bool validarCampos()
        {
            return
                (tb_direccion.Text == "" ||
                tb_descripcion.Text == "") ? false : true;
        }

        private void dg_vehiculosSeleccionados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehiculo vehiculo = (Vehiculo) dg_vehiculosSeleccionados.SelectedItem;
            if (vehiculo != null)
            {
                vehiculoSeleccionado = vehiculo;
            }
        }

        private void btn_eliminarVehiculo_Click(object sender, RoutedEventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                int idConductor = vehiculoSeleccionado.IdConductor;
                vehiculosSeleccionados.Remove(vehiculoSeleccionado);
                List<Vehiculo> vehiculos = new List<Vehiculo>();
                int vehiculosDelConductor = 0;
                foreach(Vehiculo vehiculo in vehiculosSeleccionados)
                {
                    if(vehiculo.IdConductor == idConductor)
                    {
                        vehiculosDelConductor++;
                    }
                }
                if(vehiculosDelConductor == 0)
                {
                    Conductor conductorAEliminar = new Conductor();
                    foreach(Conductor conductor in conductoresSeleccionados)
                    {
                        if (conductor.IdConductor == idConductor)
                        {
                            conductorAEliminar = conductor;
                            break;
                        }
                    }

                    conductoresSeleccionados.Remove(conductorAEliminar);
                }
                actualizarTablaVehiculosSeleccionados();
                actualizarTablaConductoresSeleccionados();
                vehiculoSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un vehículo para eliminarlo de la lista.");
            }
        }
    }
}
