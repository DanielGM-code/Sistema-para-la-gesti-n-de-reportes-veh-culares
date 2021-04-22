using SGRV.GUIDelegacionesMunicipales;
using SGRV.GUIDireccionGeneral;
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
            MenuDelegacionMunicipal menu = new MenuDelegacionMunicipal();
            menu.Show();
            this.Close();
        }
    }
}
