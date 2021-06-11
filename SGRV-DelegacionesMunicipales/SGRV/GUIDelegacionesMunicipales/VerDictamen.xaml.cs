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

namespace DelegacionesMunicipales.GUIDelegacionesMunicipales
{
    /// <summary>
    /// Lógica de interacción para VerDictamen.xaml
    /// </summary>
    public partial class VerDictamen : Window
    {
        List<Perito> peritos;
        Perito peritoSeleccionado;
        private int folio;

        private int idReporte;

        public VerDictamen(int idReporte)
        {
            InitializeComponent();
            this.idReporte = idReporte;
            llenarCampos();
        }

        private void llenarCampos()
        {
            Dictamen dictamen = DictamenDAO.getDictamenByIdReporte(idReporte);

            folio = dictamen.Folio;
            peritos = PeritoDAO.getAllPeritos();
            cb_perito.ItemsSource = peritos;
            dp_fecha.SelectedDate = dictamen.Fecha;
            tb_Folio.Text = dictamen.IdReporte.ToString();

            if (dictamen.Estado == "Inactivo")
            {
                tb_Descripcion.Text = dictamen.Descripcion;
                for (int i = 0; i < peritos.Count; i++)
                {
                    cb_perito.SelectedIndex = i;
                    Perito perito = (Perito)cb_perito.SelectedItem;
                    if (perito.IdPerito == dictamen.IdPerito)
                    {
                        break;
                    }
                    tb_Descripcion.IsEnabled = false;
                    cb_perito.IsEnabled = false;
                }


            }
            else
            {
                MessageBox.Show("Dictamen en curso");
                this.Close();
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

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
