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
    /// Lógica de interacción para EliminarUsuario.xaml
    /// </summary>
    public partial class EliminarUsuario : Window
    {
        List<Usuario> usuarios;
        Usuario usuarioSeleccionado;

        public EliminarUsuario()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            llenarTabla();
        }

        private void button_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (usuarioSeleccionado != null)
                {
                    UsuarioDAO.removeUsuario(usuarioSeleccionado);
                    string mensaje = "Delegación eliminada de manera exitosa.";
                    Mensaje ventanaMensaje = new Mensaje(mensaje);
                    ventanaMensaje.Show();
                    vaciarCampos();
                    llenarTabla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            }
        }

        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (usuarioSeleccionado != null)
                {
                    UsuarioDAO.removeUsuario(usuarioSeleccionado);
                    MessageBox.Show("Usuario eliminado de manera exitosa.");
                    vaciarCampos();
                    llenarTabla();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
            }
        }

        private void vaciarCampos()
        {
            tb_username.Text = "";
            tb_Usuario.Text = "";
            tb_correo.Text = "";
            cb_cargo.Text = null;
            cb_delegacion.Text = null;
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
            usuarios = UsuarioDAO.getAllUsuarios();
            dg_Usarios.AutoGenerateColumns = false;
            dg_Usarios.ItemsSource = usuarios;
        }

        private void clic_usuario_item(object sender, SelectionChangedEventArgs e)
        {
            usuarioSeleccionado = (Usuario)dg_Usarios.SelectedItem;
            if (usuarioSeleccionado != null)
            {
                //tb_correo.Text = usuarioSeleccionado.Correo;
                tb_username.Text = usuarioSeleccionado.Username;
                tb_Usuario.Text = usuarioSeleccionado.Username;
                //cb_cargo.Text = usuarioSeleccionado.Correo;
                //cb_delegacion.Text = usuarioSeleccionado.Correo;
            }
        }


    }
}
