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
    class VehiculoDAO
    {
        public static List<Vehiculo> getAllVehiculos()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Vehiculo";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo();
                        vehiculo.IdVehiculo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculo.Marca = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        vehiculo.Modelo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        vehiculo.Ano = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        vehiculo.Color = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        vehiculo.NombreAseguradora = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        vehiculo.PolizaSeguro =(!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        vehiculo.Placas = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        vehiculo.IdConductor = (!dataReader.IsDBNull(8)) ? dataReader.GetInt32(8) : 0;
                        vehiculo.Estado = (!dataReader.IsDBNull(9)) ? dataReader.GetString(9) : "";
                        vehiculos.Add(vehiculo);
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
            return vehiculos;
        }

        public static List<Vehiculo> getAllVehiculosByIdConductor (int idConductor)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Vehiculo WHERE idConductor = {0}", idConductor);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Vehiculo vehiculo = new Vehiculo();
                        vehiculo.IdVehiculo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculo.Marca = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        vehiculo.Modelo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        vehiculo.Ano = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        vehiculo.Color = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        vehiculo.NombreAseguradora = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        vehiculo.PolizaSeguro = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        vehiculo.Placas = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        vehiculo.IdConductor = (!dataReader.IsDBNull(8)) ? dataReader.GetInt32(8) : 0;
                        vehiculo.Estado = (!dataReader.IsDBNull(9)) ? dataReader.GetString(9) : "";
                        vehiculos.Add(vehiculo);
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
            return vehiculos;
        }

        public static Vehiculo getVehiculoById(int idVehiculo)
        {
            Vehiculo vehiculo = new Vehiculo();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Vehiculo WHERE idVehiculo = {0}", idVehiculo);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        vehiculo.IdVehiculo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculo.Marca = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        vehiculo.Modelo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        vehiculo.Ano = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        vehiculo.Color = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        vehiculo.NombreAseguradora = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        vehiculo.PolizaSeguro = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        vehiculo.Placas = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        vehiculo.IdConductor = (!dataReader.IsDBNull(8)) ? dataReader.GetInt32(8) : 0;
                        vehiculo.Estado = (!dataReader.IsDBNull(9)) ? dataReader.GetString(9) : "";
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
            return vehiculo;
        }

        public static void addVehiculo(Vehiculo vehiculo)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String marca = vehiculo.Marca;
                    String modelo = vehiculo.Modelo;
                    String ano = vehiculo.Ano;
                    String color = vehiculo.Color;
                    String nombreAseguradora = vehiculo.NombreAseguradora;
                    String polizaSeguro = vehiculo.PolizaSeguro;
                    String placas = vehiculo.Placas;
                    int idConductor = vehiculo.IdConductor;
                    String estado = vehiculo.Estado;
                    String query = String.Format("INSERT INTO Vehiculo (marca, modelo, año, color, nombreAseguradora, polizaSeguro, placas, idConductor, estado) " +
                        "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}')", marca, modelo, ano, color, nombreAseguradora, polizaSeguro, placas, idConductor, estado);
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

        public static void removeVehiculo(Vehiculo vehiculo)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idVehiculo = vehiculo.IdVehiculo;
                    String query = String.Format("UPDATE Vehiculo SET estado = 'Eliminado' WHERE idVehiculo = {0}", idVehiculo);
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
