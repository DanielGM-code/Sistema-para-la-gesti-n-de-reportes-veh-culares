using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SGRV.modelo.database;

namespace SGRV.modelo.dao
{
    class FotografiaDAO
    {
        public static List<Fotografia> getAllFotografias()
        {
            List<Fotografia> fotografias = new List<Fotografia>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Fotografia";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Fotografia fotografia = new Fotografia();
                        fotografia.IdFotografia = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        fotografia.RutaArchivo = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        fotografia.IdReporte = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
                        fotografias.Add(fotografia);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return fotografias;
        }

        public static Fotografia getFotografiaById(int idFotografia)
        {
            Fotografia fotografia = new Fotografia();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Fotografia WHERE idFotografia = {0}", idFotografia);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        fotografia.IdFotografia = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        fotografia.RutaArchivo = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        fotografia.IdReporte = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return fotografia;
        }

        public static void addFotografia(Fotografia fotografia)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String rutaArchivo = fotografia.RutaArchivo;
                    String estado = fotografia.Estado;
                    String query = String.Format("INSERT INTO Fotografia (rutaArchivo, estado) VALUES ('{0}', '{1})", rutaArchivo, estado);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void removeFotografia(Fotografia fotografia)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idFotografia = fotografia.IdFotografia;
                    String query = String.Format("UPDATE Fotografia SET estado = 'Eliminado' WHERE idFotografia = {0}", idFotografia);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int getUltimoId()
        {
            int ultimoId = 0;
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT TOP 1 idFotografia FROM Fotografia Order BY idFotografia DESC";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        ultimoId = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return ultimoId;
        }
    }
}
