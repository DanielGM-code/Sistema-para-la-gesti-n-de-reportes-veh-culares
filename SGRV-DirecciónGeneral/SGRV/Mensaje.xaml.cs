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

namespace DireccionGeneral
{
    /// <summary>
    /// Lógica de interacción para Mensaje.xaml
    /// </summary>
    public partial class Mensaje : Window
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private void button_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_cerrarVentana_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
