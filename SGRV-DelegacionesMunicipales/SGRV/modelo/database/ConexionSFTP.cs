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
        private static String PASSWORD = "ssh-rsa 2048 SHA256:2X1kw1rcSK0Dvp0qchCHvFeSegx/umXbIErTCoFcDdo";
        private static String PASSWORD2 = "ssh-rsa 2048 46:b8:40:85:4e:ca:53:b9:d4:8f:a2:58:d8:f2:fa:ea";
        private static String PASSWORD3 = "ssh-rsa 2048 SHA256:S1oiDmLhnmjF3U3xfkev1uozGUpo+DZwyBgqsvhjYx0";

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
                    Password = PASSWORD3,
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
