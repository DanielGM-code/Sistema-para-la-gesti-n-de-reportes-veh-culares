using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WinSCP;

namespace SGRV.modelo.database
{
    class ConexionSFTP
    {
        private static Protocol PROTOCOL = Protocol.Sftp;
        private static int PORT_NUMBER = 22;
        private static String HOSTNAME = "s-1d58539369434fd89.server.transfer.us-east-2.amazonaws.com";
        private static String USERNAME = "adminSGRV";
        private static String PASSWORD = "ssh-rsa 2048 71:92:22:b8:7a:44:86:69:f9:ee:7f:52:60:f4:e3:b7";
        private static String PASSWORD2 = "ssh-rsa 2048 f7:ce:43:02:00:83:c2:20:00:2e:db:05:3a:66:de:56";

        public static string FileMask { get; private set; }

        public static Session getSesion()
        {
            Session session = new Session();
            try
            {

                SessionOptions sessionOptions = new SessionOptions
                {
                    Protocol = PROTOCOL,
                    PortNumber = PORT_NUMBER,
                    HostName = HOSTNAME,
                    UserName = USERNAME,
                    Password = PASSWORD2,
                    //SshPrivateKeyPath = "C:/Users/angel/source/repos/DanielGM-code/Sistema-para-la-gesti-n-de-reportes-veh-culares/SGRV-DelegacionesMunicipales/SGRV/modelo/database/privada.ppk",
                    GiveUpSecurityAndAcceptAnySshHostKey = true
                };

                session.Open(sessionOptions);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
            return session;
        }

        public static void subirArchivo(String filePath, String filename)
        {
            Session session = getSesion();
            if (session.Opened)
            {
                try
                {
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;
                    transferOptions.FilePermissions = null;
                    transferOptions.PreserveTimestamp = false;
                    transferOptions.ResumeSupport.State = TransferResumeSupportState.Off;
                    TransferOperationResult operationResult;
                    String remotePath = String.Format("/sgrv/Fotografias/{0}", filename);
                    bool removeAction = false;
                    session.PutFileToDirectory(filePath, remotePath, removeAction, transferOptions);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    throw;
                }
                finally
                {
                    session.Close();
                }
            }
        }
        public static void bajarArchivo(String filePath, String foldername)
        {
            Session session = getSesion();
            if (session.Opened)
            {
                try
                {
                    String remotePath = String.Format("/sgrv/Fotografias/{0}", foldername);
                    session.GetFilesToDirectory(remotePath, filePath);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    throw;
                }
                finally
                {
                    session.Close();
                }
            }
        }
    }
}
