using SGRV.modelo.database;
using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SGRV.modelo.dao
{
    class DictamenDAO
    {
        public static List<Dictamen> getAllDictamentes()
        {
            List<Dictamen> dictamenes = new List<Dictamen>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Dictamen";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Dictamen dictamen = new Dictamen();
                        dictamen.Folio = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        dictamen.Descripcion = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        dictamen.FehcaYHora = (!dataReader.IsDBNull(2)) ? dataReader.GetDateTime(2) : new DateTime();
                        dictamen.IdPerito = (!dataReader.IsDBNull(3)) ? dataReader.GetInt32(3) : 0;
                        dictamen.IdReporte = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        dictamen.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        dictamenes.Add(dictamen);
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
            return dictamenes;
        }

        public static Dictamen getDictamenById(int idDictamen)
        {
            Dictamen dictamen = new Dictamen();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Dictamen WHERE folio = {0}", idDictamen);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        dictamen.Folio = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        dictamen.Descripcion = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        dictamen.FehcaYHora = (!dataReader.IsDBNull(2)) ? dataReader.GetDateTime(2) : new DateTime();
                        dictamen.IdPerito = (!dataReader.IsDBNull(3)) ? dataReader.GetInt32(3) : 0;
                        dictamen.IdReporte = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        dictamen.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
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
            return dictamen;
        }

        public static void addDictamen(Dictamen dictamen)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int folio = dictamen.Folio;
                    String descripcion = dictamen.Descripcion;
                    DateTime fechaYHora = dictamen.FehcaYHora;
                    String date = fechaYHora.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    int idPerito = dictamen.IdPerito;
                    int idReporte = dictamen.IdReporte;
                    String estado = dictamen.Estado;
                    String query = String.Format("INSERT INTO Dictamen VALUES ({0},'{1}',CONVERT(varchar, '{2}'),{3},{4},'{5}')", folio, descripcion,
                                                 date, idPerito, idReporte, estado);
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

        public static void removeDictamen(Dictamen dictamen)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int folio = dictamen.Folio;
                    String query = String.Format("UPDATE Dictamen SET estado = 'Eliminado' WHERE folio = {0}", folio);
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
    }
}
