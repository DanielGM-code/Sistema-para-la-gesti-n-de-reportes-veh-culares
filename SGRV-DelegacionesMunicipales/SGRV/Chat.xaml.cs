using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SGRV
{
    /// <summary>
    /// Lógica de interacción para Chat.xaml
    /// </summary>
    public partial class Chat : Window
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream networkStream = default(NetworkStream);
        String usuario;

        public Chat()
        {
            InitializeComponent();
        }

        public Chat(String nombreUsuario)
        {
            InitializeComponent();
            this.usuario = nombreUsuario;
            try
            {
                clientSocket.Connect("127.0.0.1", 1234);
                networkStream = clientSocket.GetStream();
                byte[] outstream = Encoding.ASCII.GetBytes(nombreUsuario + "$");
                networkStream.Write(outstream, 0, outstream.Length);
                networkStream.Flush();
                Thread threadListen = new Thread(escucharMensajes);
                threadListen.Start();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }


        private void escucharMensajes()
        {
            while (true)
            {
                networkStream = clientSocket.GetStream();
                byte[] instream = new byte[65537];
                networkStream.Read(instream, 0, clientSocket.ReceiveBufferSize);

                string returnData = Encoding.ASCII.GetString(instream);

                int cutIndex = returnData.IndexOf("%");
                if (cutIndex >0)
                { 
                    String remitente = returnData.Substring(0, cutIndex);
                    String mensaje = returnData.Substring(cutIndex + 1, (returnData.Length - cutIndex) -1);
                    insertarMensaje(remitente, mensaje);
                }
                else
                {
                    insertarMensaje(returnData, "");
                }
            
               
            }
        }

        private void btn_enviar_Click(object sender, RoutedEventArgs e)
        {
            if(tb_mensaje.Text != "")
            {
                byte[] outstream = Encoding.ASCII.GetBytes(tb_mensaje.Text + "$");
                networkStream.Write(outstream, 0, outstream.Length);
                networkStream.Flush();
                tb_mensaje.Text = "";
            }
            else
            {
                MessageBox.Show("El mensaje no puede estar vacío.");
            }
        }

        private void insertarMensaje(String remitente, String mensaje)
        {
            Dispatcher.Invoke((ThreadStart)delegate
            {
                Label lbRemitente = new Label();
                lbRemitente.FontSize = 10;
                if (mensaje == "")
                {
                    lbRemitente.Content = String.Format("Se ha unido al chat: {0}", remitente);
                    lbRemitente.Width = 120;
                    lbRemitente.HorizontalAlignment = HorizontalAlignment.Center;
                    sp_chat.Dispatcher.Invoke((ThreadStart)delegate {
                        sp_chat.Children.Add(lbRemitente);
                    });
                }
                else
                {
                    lbRemitente.Content = String.Format("{0}:", remitente);
                    lbRemitente.Width = 60;
                    lbRemitente.HorizontalAlignment = (remitente == usuario) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
                    lbRemitente.HorizontalContentAlignment = (remitente == usuario) ? HorizontalAlignment.Right : HorizontalAlignment.Left;

                    TextBox tbMensaje = new TextBox();
                    tbMensaje.Text = mensaje;
                    tbMensaje.Height = 35;
                    tbMensaje.TextWrapping = TextWrapping.Wrap;
                    tbMensaje.IsEnabled = false;
                    tbMensaje.FontSize = 12;
                    tbMensaje.HorizontalAlignment = (remitente == usuario) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
                    tbMensaje.HorizontalContentAlignment = (remitente == usuario) ? HorizontalAlignment.Right : HorizontalAlignment.Left;
                    Thickness thickness = tbMensaje.Margin;
                    thickness.Left = 0;
                    thickness.Top = 0;
                    thickness.Right = 15;
                    thickness.Bottom = 0;

                    sp_chat.Dispatcher.Invoke((ThreadStart)delegate
                    {
                        sp_chat.Children.Add(lbRemitente);
                        sp_chat.Children.Add(tbMensaje);
                    });
                }
            });
            
        }

        private void btn_cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
