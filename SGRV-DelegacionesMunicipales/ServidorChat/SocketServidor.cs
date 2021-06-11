using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServidorChat
{
    class SocketServidor
    {
        public static int tamañoBuffer = 65537;
        public static Hashtable listaClientes = new Hashtable();

        public static void Conectar()
        {
            TcpListener serverSocket = new TcpListener(1234);
            TcpClient clientSocket = default(TcpClient);
            int contador = 0;

            serverSocket.Start();
            Console.WriteLine("Servidor a la escucha");

            while (true)
            {
                contador++;
                clientSocket = serverSocket.AcceptTcpClient();
                byte[] bytesRecibidos = new byte[tamañoBuffer];
                string mensajeCliente = "";
                NetworkStream networkStream = clientSocket.GetStream();
                networkStream.Read(bytesRecibidos, 0, clientSocket.ReceiveBufferSize);
                mensajeCliente = Encoding.ASCII.GetString(bytesRecibidos);
                mensajeCliente = mensajeCliente.Substring(0, mensajeCliente.IndexOf("$"));
                listaClientes.Add(mensajeCliente, clientSocket);

                notificarClientes(mensajeCliente, mensajeCliente, false);
                ClienteRemoto clienteRemoto = new ClienteRemoto();
                clienteRemoto.inicializarCliente(clientSocket, mensajeCliente);
            }
        }

        public static void notificarClientes(String mensaje, string nombreCliente, bool flag)
        {
            foreach(DictionaryEntry item in listaClientes)
            {
                TcpClient broadcastSocket;
                broadcastSocket = (TcpClient)item.Value;
                NetworkStream broadcastStream = broadcastSocket.GetStream();
                Byte[] broadcastBytes = null;

                broadcastBytes = Encoding.ASCII.GetBytes(((flag) ? nombreCliente + "%" : "") + mensaje);

                broadcastStream.Write(broadcastBytes, 0, broadcastBytes.Length);
                broadcastStream.Flush();
            }
        }
    }

    public class ClienteRemoto
    {
        TcpClient clientSocket;
        String nombreCliente;
        int tamañoBuffer = 65537;

        public void inicializarCliente(TcpClient clientSocket, String nombreCliente)
        {
            this.clientSocket = clientSocket;
            this.nombreCliente = nombreCliente;
            Thread ctThread = new Thread(escucharChat);
            ctThread.Start();
        }

        private void escucharChat()
        {
            byte[] bytesFrom = new byte[tamañoBuffer];
            string datoFromCliente = null;
            while (true)
            {
                try
                {
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, clientSocket.ReceiveBufferSize);
                    datoFromCliente = Encoding.ASCII.GetString(bytesFrom);
                    datoFromCliente = datoFromCliente.Substring(0, datoFromCliente.IndexOf("$"));

                    SocketServidor.notificarClientes(datoFromCliente, nombreCliente, true);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
