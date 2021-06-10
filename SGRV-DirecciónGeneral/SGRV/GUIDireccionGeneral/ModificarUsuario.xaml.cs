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
    /// Lógica de interacción para ModificarUsuario.xaml
    /// </summary>
    public partial class ModificarUsuario : Window
    {
        List<Usuario> usuarios;
        List<Delegacion> delegaciones;
        Usuario usuarioSeleccionado;

        public string[] cargos { get; set; }

        public ModificarUsuario()
        {
            InitializeComponent();

            usuarios = new List<Usuario>();
            cargos = new string[] { "Administrativo", "Agente de transito", "Perito", "Soporte" }; 
            DataContext = this;

            delegaciones = DelegacionDAO.getAllDelegaciones();
            cb_delegacion.ItemsSource = delegaciones;

            llenarTabla();
        }

        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = usuarioSeleccionado.IdUsuario;
                usuario.Username = tb_username.Text;
                usuario.Cargo = cb_cargo.SelectedItem.ToString();
                Delegacion delegacion = (Delegacion)cb_delegacion.SelectedItem;
                usuario.IdDelegacion = delegacion.IdDelegacion;
                usuario.Correo = tb_correo.Text;
                usuario.Estado = "Activo";

                try
                {
                    if (usuarioSeleccionado != null)
                    {
                        UsuarioDAO.updateUsuario(usuario);
                        MessageBox.Show("Usuario modificado de manera exitosa.");
                        vaciarCampos();
                        llenarTabla();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
                }
            }
        }

        private bool validarCampos()
        {
            return (tb_username.Text == "" ||
               tb_correo.Text == "" ||
               cb_cargo.SelectedItem == null ||
               cb_delegacion.SelectedItem == null) ? false : true;
        }

        private void vaciarCampos()
        {
            tb_username.Text = "";
            tb_correo.Text = "";
            cb_cargo.SelectedItem = null;
            cb_delegacion.SelectedItem = null;
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
                tb_username.Text = usuarioSeleccionado.Username;
                cb_cargo.SelectedItem = usuarioSeleccionado.Cargo;
                cb_delegacion.SelectedItem = usuarioSeleccionado.Delegacion;
            }
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
