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
        List<Usuario> usuarios;

        public RegistrarUsuario()
        {
            InitializeComponent();
            usuarios = new List<Usuario>();
            llenarTabla();
            llenarComboboxes();
        }

        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Eliminar_Click(object sender, RoutedEventArgs e)
        {

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
                    usuario.Estado = "Activo";
                    UsuarioDAO.addUsuario(usuario);
                    switch (usuario.Cargo)
                    {
                        case "Administrativo":
                            Administrativo administrativo = new Administrativo();
                            administrativo.Nombre = tb_Nombre.Text;
                            administrativo.Correo = tb_correo.Text;
                            administrativo.Estado = "Activo";
                            AdministrativoDAO.addAdministrativo(administrativo);
                            break;
                        case "Soporte":
                            Soporte soporte = new Soporte();
                            soporte.Nombre = tb_Nombre.Text;
                            soporte.Correo = tb_correo.Text;
                            soporte.Estado = "Activo";
                            SoporteDAO.addSoporte(soporte);
                            break;
                        case "Agente de Tránsito":
                            AgenteDeTransito agenteDeTransito = new AgenteDeTransito();
                            agenteDeTransito.Nombre = tb_Nombre.Text;
                            agenteDeTransito.Correo = tb_correo.Text;
                            agenteDeTransito.Estado = "Activo";
                            AgenteDeTransitoDAO.addAgenteDeTransito(agenteDeTransito);
                            break;
                        case "Perito":
                            Perito perito = new Perito();
                            perito.Nombre = tb_Nombre.Text;
                            perito.Correo = tb_correo.Text;
                            perito.Estado = "Activo";
                            PeritoDAO.addPerito(perito);
                            break;
                    }
                    MessageBox.Show("Se ha registrado al usuario de manera exitosa.");
                    llenarTabla();
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
            MenuDireccionGeneral ventanaMenu = new MenuDireccionGeneral();
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

        private void llenarTabla()
        {
            usuarios = UsuarioDAO.getAllUsuarios();
            dg_usuarios.AutoGenerateColumns = false;
            dg_usuarios.ItemsSource = usuarios;
        }

        private bool validarCampos()
        {
            return (tb_Nombre.Text == "" ||
               tb_username.Text == "" ||
               cb_cargo.SelectedItem == null ||
               cb_delegacion.SelectedItem == null) ? false : true;
        }

        private void llenarComboboxes()
        {
            List<String> cargos = new List<string>();
            cargos.Add("Administrativo");
            cargos.Add("Soporte");
            cargos.Add("Agente de Tránsito");
            cargos.Add("Perito");
            cb_cargo.ItemsSource = cargos;

            List<Delegacion> delegacions = DelegacionDAO.getAllDelegaciones();
            cb_delegacion.ItemsSource = delegacions;
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
