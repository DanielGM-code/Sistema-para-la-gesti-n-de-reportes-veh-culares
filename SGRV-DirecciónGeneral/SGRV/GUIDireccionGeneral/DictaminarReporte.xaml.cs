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
    /// Lógica de interacción para DictaminarReporte.xaml
    /// </summary>
    public partial class DictaminarReporte : Window
    {
        List<Perito> peritos;
        Perito peritoSeleccionado;

        public int idReporte { get; set; }

        public DictaminarReporte(int idReporte)
        {
            InitializeComponent();

            peritos = PeritoDAO.getAllPeritos();
            cb_perito.ItemsSource = peritos;

            tb_Folio.Text = idReporte.ToString();
        }

        private void button_RegistrarDictamen_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Dictamen dictamen = new Dictamen();
                dictamen.Descripcion = tb_Descripcion.Text;
                peritoSeleccionado = (Perito)cb_perito.SelectedItem;
                dictamen.IdPerito = peritoSeleccionado.IdPerito;
                dictamen.Estado = "Inactivo";
                string hora = DateTime.Now.ToString("t");
                dictamen.Hora = hora;

                try
                {
                    DictamenDAO.updateDictamen(dictamen);
                    MessageBox.Show("Dictamen realizado de manera exitosa.");
                    this.Close();
                }
                catch (Exception x)
                {
                    MessageBox.Show("Ocurrió un error, inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Asegúrese de llenar todos los campos.");
            }
        }

        private bool validarCampos()
        {
            return (tb_Descripcion.Text == "" ||
                    cb_perito.SelectedItem == null) ? false : true;
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
