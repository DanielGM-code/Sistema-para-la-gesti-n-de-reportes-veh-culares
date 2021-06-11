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

namespace SGRV.GUIDireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para RegistrarUsuario.xaml
    /// </summary>
    public partial class RegistrarUsuario : Window
    {
        String username;
        List<Delegacion> delegaciones;
        public string[] cargos { get; set; }
        public RegistrarUsuario(String username)
        {

            InitializeComponent();
            this.username = username;
            delegaciones = DelegacionDAO.getAllDelegaciones();
            cb_delegacion.ItemsSource = delegaciones;
            cargos = new string[] { "Administrativo", "Agente de transito", "Perito", "Soporte" };
            DataContext = this;
 
        }

        private void button_Registrar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                if(pb_password.Password == pb_confirmarPassword.Password)
                {
                    Usuario usuario = new Usuario();
                    usuario.Username = tb_username.Text;
                    usuario.Contraseña = pb_password.Password;
                    usuario.Cargo = cb_cargo.SelectedItem.ToString();
                    Delegacion delegacion = (Delegacion) cb_delegacion.SelectedItem;
                    usuario.IdDelegacion = delegacion.IdDelegacion;
                    usuario.Correo = tb_correo.Text;
                    usuario.Estado = "Activo";
                    UsuarioDAO.addUsuario(usuario);
                    switch (usuario.Cargo)
                    {
                        case "Administrativo":
                            Administrativo administrativo = new Administrativo();
                            administrativo.Nombre = tb_username.Text;
                            administrativo.Correo = tb_correo.Text;
                            administrativo.Estado = "Activo";
                            AdministrativoDAO.addAdministrativo(administrativo);
                            break;
                        case "Soporte":
                            Soporte soporte = new Soporte();
                            soporte.Nombre = tb_username.Text;
                            soporte.Correo = tb_correo.Text;
                            soporte.Estado = "Activo";
                            SoporteDAO.addSoporte(soporte);
                            break;
                        case "Agente de Tránsito":
                            AgenteDeTransito agenteDeTransito = new AgenteDeTransito();
                            agenteDeTransito.Nombre = tb_username.Text;
                            agenteDeTransito.Correo = tb_correo.Text;
                            agenteDeTransito.Estado = "Activo";
                            AgenteDeTransitoDAO.addAgenteDeTransito(agenteDeTransito);
                            break;
                        case "Perito":
                            Perito perito = new Perito();
                            perito.Nombre = tb_username.Text;
                            perito.Correo = tb_correo.Text;
                            perito.Estado = "Activo";
                            PeritoDAO.addPerito(perito);
                            break;
                    }
                    MessageBox.Show("Se ha registrado al usuario de manera exitosa.");
                    vaciarCampos();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben coincidir");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {
            MenuDireccionGeneral ventanaMenu = new MenuDireccionGeneral(username);
            ventanaMenu.Show();
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

        private bool validarCampos()
        {
            return (tb_username.Text == "" ||
               pb_password.Password == "" ||
               tb_correo.Text == "" ||
               cb_cargo.SelectedItem == null ||
               cb_delegacion.SelectedItem == null) ? false : true;
        }

        private void vaciarCampos()
        {
            tb_username.Text = "";
            tb_correo.Text = "";
            pb_password.Password = "";
            cb_cargo.SelectedItem = null;
            cb_delegacion.SelectedItem = null;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
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
    }
}
