using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SGRV.modelo.database
{
    class ConexionBD
    {
        private static String SERVER = "sgrv-db.c4srryp4em55.us-east-2.rds.amazonaws.com";
        private static String PORT = "1433";
        private static String DATABASE = "SGRV";
        private static String USER = "adminSGRV";
        private static String PASSWORD = "=-8&emjanpVKP4d";

        public static SqlConnection getConnection()
        {
            SqlConnection conexion = null;
            try
            {
                String urlconn = String.Format("Data Source = {0},{1}; " +
                    "Initial Catalog = {2};" +
                    "User ID = {3}; " +
                    "Password = {4};", SERVER, PORT, DATABASE, USER, PASSWORD);
                conexion = new SqlConnection(urlconn);
                conexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excepcion: " + e.Message);
            }

            if(conexion != null)
            {
                Console.WriteLine("Conexion Exitosa");
            }
            else
            {
                Console.WriteLine("Conexion Fallida");
            }
            return conexion;
        }
    }
}
