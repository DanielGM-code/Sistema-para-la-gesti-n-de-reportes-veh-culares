﻿using SGRV.modelo.dao;
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
    /// Lógica de interacción para ModificarDelegacion.xaml
    /// </summary>
    public partial class ModificarDelegacion : Window
    {
        String username;
        List<Delegacion> delegaciones;
        List<Delegacion> delegacionesFiltradas;
        Delegacion delegacionSeleccionada;
        public string[] municipios { get; set; }

        public ModificarDelegacion(String username)
        {
            InitializeComponent();
            this.username = username;
            delegaciones = new List<Delegacion>();
            delegacionesFiltradas = new List<Delegacion>();
            llenarTabla();
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

        private void button_Modificar_Click(object sender, RoutedEventArgs e)
        {
            if (validarCampos())
            {
                Delegacion delegacion = new Delegacion();
                delegacion.IdDelegacion = delegacionSeleccionada.IdDelegacion;
                delegacion.Estado = "Activo";
                delegacion.Nombre = tb_nombre.Text;
                delegacion.CodigoPostal = tb_codigoPostal.Text;
                delegacion.Correo = tb_correo.Text;
                delegacion.Direccion = tb_direccion.Text;
                delegacion.Municipio = cb_municipio.Text;
                delegacion.Telefono = tb_telefono.Text;

                try
                {
                    if (delegacionSeleccionada != null)
                    {
                        DelegacionDAO.updateDelegacion(delegacion);
                        MessageBox.Show("Delegación modificada de manera exitosa.");
                        vaciarCampos();
                        llenarTabla();
                    }
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
            return (tb_nombre.Text == "" ||
                    tb_codigoPostal.Text == "" ||
                    tb_correo.Text == "" ||
                    tb_direccion.Text == "" ||
                    cb_municipio.SelectedItem == null ||
                    tb_telefono.Text == "") ? false : true;
        }

        private void vaciarCampos()
        {
            tb_nombre.Text = "";
            tb_codigoPostal.Text = "";
            tb_correo.Text = "";
            tb_direccion.Text = "";
            cb_municipio.SelectedItem = null;
            tb_telefono.Text = "";
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
            MenuDireccionGeneral ventanaMenuDireccionGeneral = new MenuDireccionGeneral(username);
            ventanaMenuDireccionGeneral.Show();
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

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void llenarTabla()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            dg_DelegacionesMunicipales.AutoGenerateColumns = false;
            dg_DelegacionesMunicipales.ItemsSource = delegaciones;
        }

        private void clic_delegacion_item(object sender, SelectionChangedEventArgs e)
        {
            delegacionSeleccionada = (Delegacion)dg_DelegacionesMunicipales.SelectedItem;
            if (delegacionSeleccionada != null)
            {
                tb_nombre.Text = delegacionSeleccionada.Nombre;
                tb_codigoPostal.Text = delegacionSeleccionada.CodigoPostal;
                tb_correo.Text = delegacionSeleccionada.Correo;
                tb_direccion.Text = delegacionSeleccionada.Direccion;
                cb_municipio.Text = delegacionSeleccionada.Municipio;
                tb_telefono.Text = delegacionSeleccionada.Telefono;
            }
        }

        private void filtrarTabla()
        {
            delegaciones = DelegacionDAO.getAllDelegaciones();
            String busqueda = tb_nombreDelegacion.Text;

            foreach (Delegacion delegacion in delegaciones)
            {
                if (delegacion.Nombre.ToLower() == busqueda.ToLower() ||
                    delegacion.CodigoPostal == busqueda ||
                    delegacion.Correo.ToLower() == busqueda.ToLower() ||
                    delegacion.Direccion.ToLower() == busqueda.ToLower() ||
                    delegacion.Municipio.ToLower() == busqueda.ToLower() ||
                    delegacion.Telefono == busqueda)
                {
                    delegacionesFiltradas.Add(delegacion);
                }
            }

            if (delegacionesFiltradas.Count > 0)
            {
                dg_DelegacionesMunicipales.ItemsSource = delegacionesFiltradas;
            }
            else
            {
                llenarTabla();
            }
        }

        private void button_Buscar_Click(object sender, RoutedEventArgs e)
        {
            filtrarTabla();
        }

        private void tb_codigoPostal_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tb_telefono_keyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
