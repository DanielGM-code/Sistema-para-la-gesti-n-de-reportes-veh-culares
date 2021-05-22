using SGRV.GUIDelegacionesMunicipales;
using SGRV.GUIDireccionGeneral;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SGRV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button_IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            if (validadCampos())
            {
                String username = tb_username.Text;
                String contraseña = pb_password.Password;

                Usuario usuario = UsuarioDAO.getUsuarioByUsername(username);
                if (usuario.IdUsuario != 0)
                {
                    if (usuario.Contraseña == contraseña)
                    {
                        switch (usuario.Cargo)
                        {
                            case "Soporte":
                            case "Administrativo":
                                MenuDireccionGeneral menuDireccionGeneral = new MenuDireccionGeneral();
                                menuDireccionGeneral.Show();
                                this.Close();
                                break;
                            case "AgenteDeTransito":
                            case "Perito":
                                MenuDelegacionMunicipal menuDelegacionMunicipal = new MenuDelegacionMunicipal();
                                menuDelegacionMunicipal.Show();
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }

            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
            
        }

        private bool validadCampos()
        {
            return (tb_username.Text == "" || pb_password.Password == "") ? false : true;
        }

        private void Login_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }

        private void button_cerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
