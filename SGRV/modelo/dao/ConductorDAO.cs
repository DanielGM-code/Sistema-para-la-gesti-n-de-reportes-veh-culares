using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SGRV.modelo.database;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SGRV.modelo.dao
{
    class ConductorDAO
    {
        public static List<Conductor> getAllConductores()
        {
            List<Conductor> conductores = new List<Conductor>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Conductor";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Conductor conductor = new Conductor();
                        conductor.IdConductor = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductor.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        conductor.FechaNacimiento = (!dataReader.IsDBNull(2)) ? dataReader.GetDateTime(2) : new DateTime();
                        conductor.NumeroLicencia = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        conductor.Telefono = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        conductor.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        conductores.Add(conductor);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return conductores;
        }

        public static Conductor getConductoraById(int idConductor)
        {
            Conductor conductor = new Conductor();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Conductor WHERE idConductor = {0}", idConductor);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        conductor.IdConductor = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductor.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        conductor.FechaNacimiento = (!dataReader.IsDBNull(1)) ? dataReader.GetDateTime(2) : new DateTime();
                        conductor.NumeroLicencia = (!dataReader.IsDBNull(1)) ? dataReader.GetString(3) : "";
                        conductor.Telefono = (!dataReader.IsDBNull(1)) ? dataReader.GetString(4) : "";
                        conductor.Estado = (!dataReader.IsDBNull(1)) ? dataReader.GetString(5) : "";
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
            return conductor;
        }

        public static void addConductor(Conductor conductor)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = conductor.Nombre;
                    DateTime fechaNacimiento = conductor.FechaNacimiento;
                    String numeroLicencia = conductor.NumeroLicencia;
                    String telefono = conductor.Telefono;
                    String estado = conductor.Estado;
                    String query = String.Format("INSERT INTO Conductor (nombre, fechaNacimiento, numeroLicencia, telefono, estado) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", nombre, fechaNacimiento.ToString("yyyy-MM-dd"), numeroLicencia, telefono, estado);
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

        public static void removeConductor(Conductor conductor)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idConductor = conductor.IdConductor;
                    String query = String.Format("UPDATE Conductor SET estado = 'Eliminado' WHERE idConductor = {0}", idConductor);
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
