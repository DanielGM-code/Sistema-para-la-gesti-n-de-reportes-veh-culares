using DireccionGeneral;
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
                "La Antigua", "La Perla", "Landero y Coss", "Las Choapas",
                "Las Minas", "Las Vigas de Ramírez", "Lerdo de Tejada",
                "Los Reyes", "Magdalena", "Maltrata", "	Manlio Fabio Altamirano",
                "Mariano Escobedo", "Martínez de la Torre", "Mecatlán",
                "Mecayapan", "Medellín", "Miahuatlán", "Minatitlán",
                "Misantla", "Mixtla de Altamirano", "Moloacán",
                "Nanchital de Lázaro Cárdenas del Río",
                "Naolinco", "Naranjal", "Naranjos Amatlán", "Nautla",
                "Nogales", "Nogales", "Oluta", "Omealca", "Orizaba",
                "Otatitlán", "Oteapan", "Ozuluama de Mascareñas", "Pajapan",
                "Pánuco", "Papantla", "Paso de Ovejas", "Paso del Macho",
                "Perote", "Platón Sánchez", "Playa Vicente", "Poza Rica de Hidalgo",
                "Pueblo Viejo", "Puente Nacional", "Rafael Delgado", "Rafael Lucio",
                "Río Blanco", "Saltabarranca", "San Andrés Tenejapan",
                "San Andrés Tuxtla", "San Juan Evangelista", "San Rafael",
                "Santiago Sochiapan", "Santiago Tuxtla", "Sayula de Alemán",
                "Sochiapa", "Soconusco", "Soledad Atzompa", "Soledad de Doblado",
                "Soteapan", "Tamalín", "Tamiahua", "Tampico Alto", "Tancoco",
                "Tantima", "Tantoyuca", "Tatahuicapan de Juárez", "Tlatatila",
                "Tecolutla", "Tehuipango", "Tempoal", "Tempoal", "Tenochtitlán",
                "Teocelo", "Tepatlaxco", "Tepetlán", "Tepetzintla",
                "Tequila", "Texcatepec", "Texhuacán", "Texistepec",
                "Tezonapa", "Tierra Blanca", "Tihuatlán", "Tlachichilco",
                "Tlacojalpan", "Tlacolulan", "Tlacotalpan", "Tlacotepec de Mejía",
                "Tlalixcoyan", "Tlalnelhuayocan", "Tlaltetela", "Tlapacoyan",
                "Tlaquilpa", "Tlilapan", "Tomatlán", "Tonayán", "Totutla",
                "Tres Valles", "Tuxpan", "Tuxtilla", "Úrsulo Galván",
                "Uxpanapa", "Vega de Alatorre", "Veracruz", "Villa Aldama",
                "Xalapa", "Xico", "Xoxocotla", "Yanga", "Yecuatla",
                "Zacualpan", "Zaragoza", "Zentla", "Zongolica",
                "Zontecomatlán de López y Fuentes", "Zozocolco de Hidalgo"
            };
            DataContext = this;
        }

        private void button_Registrar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Delegacion delegacion = new Delegacion();
                delegacion.Nombre = tb_nombre.Text;
                delegacion.Direccion = tb_direccion.Text;
                delegacion.CodigoPostal = tb_codigoPostal.Text;
                delegacion.Municipio = cb_municipio.Text;
                delegacion.Telefono = tb_telefono.Text;
                delegacion.Correo = tb_correo.Text;
                delegacion.Estado = "Activo";

                try
                {
                    DelegacionDAO.addDelegacion(delegacion);
                    string mensaje = "Se ha registrado al usuario de manera exitosa.";
                    Mensaje ventanaMensaje = new Mensaje(mensaje);
                    ventanaMensaje.Show();
                    vaciarCampos();
                }
                catch
                {
                    string mensaje = "Ha ocurrido un problema.";
                    Mensaje ventanaMensaje = new Mensaje(mensaje);
                }
            }
            else
            {
                string mensaje = "Asegúrese de llenar todos los campos.";
                Mensaje ventanaMensaje = new Mensaje(mensaje);
            }
        }

        private bool validarCampos()
        {
            return (tb_nombre.Text == "" ||
               tb_direccion.Text == "" ||
               tb_codigoPostal.Text == "" ||
               cb_municipio.SelectedItem == null ||
               tb_telefono.Text == "" ||
               tb_correo.Text == "") ? false : true;
        }

        private void vaciarCampos()
        {
            tb_nombre.Text = "";
            tb_direccion.Text = "";
            tb_codigoPostal.Text = "";
            cb_municipio.SelectedItem = null;
            tb_telefono.Text = "";
            tb_correo.Text = "";
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
    }
}
