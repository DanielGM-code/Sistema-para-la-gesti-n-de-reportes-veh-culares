using Microsoft.Win32;
using SGRV.modelo.dao;
using SGRV.modelo.database;
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
    /// Lógica de interacción para RegistrarReporte.xaml
    /// </summary>
    public partial class RegistrarReporte : Window
    {
        List<Conductor> conductores;
        List<Conductor> conductoresSeleccionados;
        Conductor conductorSeleccionado;
        Conductor conductorElegido;
        List<Vehiculo> vehiculos;
        List<Vehiculo> vehiculosSeleccionados;
        Vehiculo vehiculoSeleccionado;
        Vehiculo vehiculoElegido;
        public RegistrarReporte()
        {
            InitializeComponent();
            conductores = new List<Conductor>();
            conductoresSeleccionados = new List<Conductor>();
            vehiculos = new List<Vehiculo>();
            vehiculosSeleccionados = new List<Vehiculo>();
            vehiculosSeleccionados = new List<Vehiculo>();
            llenarTablaConductores();
        }

        private void button_RegistrarReporte_Click(object sender, RoutedEventArgs e)
        {
            Image image = new Image();
            Uri uri = new Uri("/GUIDelegacionesMunicipales/plus_icon_gray.png", UriKind.Relative);
            image.Source = new BitmapImage(uri);
            image.Width = 100;
            image.Height = 100;
            wp_imagenes.Children.Add(image);

            //stackPanel.UpdateLayout();
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

        private void btn_image_1_Click(object sender, RoutedEventArgs e)
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
                    fileExtension = filePath.Substring(filePath.Length - 4,4);
                    //Uri uri = new Uri(filePath);
                    //img_1.Source = new BitmapImage(uri);
                    //paths.Add(filePath);
                    //isSelectedImage1 = true;
                    //habilitarBoton(btn_image_2, img_2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            conductoresSeleccionados.Remove(conductorSeleccionado);
        }

        private void clic_Conductor(object sender, SelectionChangedEventArgs e)
        {
            conductorSeleccionado = (Conductor)dg_conductoresSeleccionados.SelectedItem;
            MessageBox.Show(conductorSeleccionado.Nombre);
        }

        private void seleccionar_conductor(object sender, SelectionChangedEventArgs e)
        {
            conductorElegido = (Conductor)dg_conductores.SelectedItem;
            llenarTablaVehiculos(conductorElegido);
        }

        private void actualizarTablaConductoresSeleccionados()
        {
            List<Conductor> conductors = conductoresSeleccionados;
            MessageBox.Show("" + conductors.Count);
            dg_conductoresSeleccionados.ItemsSource = conductors;
        }

        private void actualizarTablaVehiculosSeleccionados()
        {
            List<Vehiculo> vehiculos = vehiculosSeleccionados;
            MessageBox.Show("" + vehiculos.Count);
            dg_vehiculosSeleccionados.ItemsSource = vehiculos;
        }

        private void clic_vehiculo(object sender, SelectionChangedEventArgs e)
        {
            vehiculoElegido = (Vehiculo)dg_vehiculos.SelectedItem;
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
}
