using SGRV;
using SGRV.GUIDireccionGeneral;
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

namespace DireccionGeneral.GUIDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para EliminarDelegacion.xaml
    /// </summary>
    public partial class EliminarDelegacion : Window
    {
        List<Delegacion> delegaciones;
        Delegacion delegacionSeleccionada;

        public EliminarDelegacion()
        {
            InitializeComponent();
            delegaciones = new List<Delegacion>();
            llenarTabla();
        }

        private void button_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (delegacionSeleccionada != null)
                {
                    DelegacionDAO.removeDelegacion(delegacionSeleccionada);
                    MessageBox.Show("Delegación eliminada de manera exitosa.");
                    vaciarCampos();
                    llenarTabla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            }
        }

        private bool validarCampos()
        {
            return (tb_nombre.Text == "" ||
                    tb_codigoPostal.Text == "" ||
                    tb_correo.Text == "" ||
                    tb_direccion.Text == "" ||
                    tb_municipio.Text == "" ||
                    tb_telefono.Text == "") ? false : true;
        }

        private void vaciarCampos()
        {
            tb_nombre.Text = "";
            tb_codigoPostal.Text = "";
            tb_correo.Text = "";
            tb_direccion.Text = "";
            tb_municipio.Text = "";
            tb_telefono.Text = "";
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
            MenuDireccionGeneral ventanaMenuDireccionGeneral = new MenuDireccionGeneral();
            ventanaMenuDireccionGeneral.Show();
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

        private void llenarTabla()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            dg_DelegacionesMunicipales.AutoGenerateColumns = false;
            dg_DelegacionesMunicipales.ItemsSource = delegaciones;
        }

        private void clic_delegacion_item(object sender, SelectionChangedEventArgs e)
        {
            delegacionSeleccionada = (Delegacion)dg_DelegacionesMunicipales.SelectedItem;
            if (delegacionSeleccionada != null)
            {
                tb_nombre.Text = delegacionSeleccionada.Nombre;
                tb_codigoPostal.Text = delegacionSeleccionada.CodigoPostal;
                tb_correo.Text = delegacionSeleccionada.Correo;
                tb_direccion.Text = delegacionSeleccionada.Direccion;
                tb_municipio.Text = delegacionSeleccionada.Municipio;
                tb_telefono.Text = delegacionSeleccionada.Telefono;
            }
        }
    }
}
