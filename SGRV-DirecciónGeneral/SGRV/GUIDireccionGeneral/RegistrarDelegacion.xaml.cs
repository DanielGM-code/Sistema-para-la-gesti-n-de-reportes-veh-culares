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
    /// Lógica de interacción para RegistrarDelegacion.xaml
    /// </summary>
    public partial class RegistrarDelegacion : Window
    {
        public string[] municipios { get; set; }

        public RegistrarDelegacion()
        {
            InitializeComponent();
            municipios = new string[] {
                "Acajete", "Acatlán", "Acayucan",
                "Actopan", "Acula", "Acutzingo",
                "Agua Dulce", "Álamo Temapache",
                "Alpatláhuac", "Alto Lucero de Gutiérrez Barrios",
                "Altotonga", "Amatitlán", "Amatlán de los Reyes", 
                "Ángel R. Cabada", "Apazapan", "Aquila",
                "Astacinga", "Atlahuilco", "Atoyac", "Atzacan",
                "Atzalan", "Ayahualulco", "Banderilla", 
                "Benito Juárez", "Boca del Río", "Calcahualco",
                "Camarón de Tejeda", "Camerino Z. Mendoza",
                "Carlos A. Carrillo", "Carrillo Puerto",
                "Castillo de Teayo", "Catemaco", "Cazones de Herrera",
                "Cerro Azul", "Chacaltianguis", "Chalma", "Chiconamel",
                "Chiconquiaco", "Chicotepec", "Chinameca",
                "Chinampa de Gorostiza", "Chocomán", "Chontla",
                "Chumatlán", "Citlaltépetl", "Cocoatzintla",
                "Coahuitlán", "Coatepec", "Coatzacoalcos",
                "Coatzintla", "Coetzala", "Colipa", "Comapa",
                "Córdoba", "Cosamaloapan de Carpio", "Cosautlán de Carvajal",
                "Coscomatepec", "Cosoleacaque", "Cotaxtla", "Coxquihui",
                "Coyutla", "Chichapa", "Cuitláhuac", "El Higo",
                "Emiliano Zapata", "Espinal", "Filomeno Mata",
                "Fortín", "Gutiérrez Zamora", "Hidalgotitlán",
                "Huatusco", "Huayacocotla", "Hueyapan de Ocampo",
                "Huiloapan de Cuauhtémoc", "Ignacio de la Llave", "Ilamatlán",
                "Isla", "Ixcatepec", "Ixhuacán de los Reyes", "Ixhuatlán de Madero",
                "Ixhuatlán del Café", "Ixhuatlán del Sureste", "Ixhuatlancillo",
                "Ixmatlahuacan", "Ixtaczoquitlán", "Jalacingo", "Jalcomulco",
                "Jáltipan", "Jamapa", "Jesús Carranza", "Jilotepec",
                "José Azueta", "Juan Rodríguez Clara", "Juchique de Ferrer",
                "La Antigua", "La Perla", 
            };
            DataContext = this;
        }

        private void button_Registrar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Regresar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Chat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_CerrarSesion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_MinimizarVentana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_CerrarVentana_Click(object sender, RoutedEventArgs e)
        {

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
