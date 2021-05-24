using System;
using System.Collections.Generic;
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
                    Password = PASSWORD,
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

        public static void subirArchivo(String filePath)
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
                    String remotePath = "/sgrv/Fotografias/prueba.png";
                    bool removeAction = false;
                    operationResult = session.PutFiles(filePath, remotePath, removeAction, transferOptions);
                    operationResult.Check();
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
