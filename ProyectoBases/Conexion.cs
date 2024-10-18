using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProyectoBases
{
    internal class Conexion
    {
        // Definir la cadena de conexión como una constante en la clase
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=ProyectoCine;Trusted_Connection=True;";
        
        public Conexion() { }

        // Método para ejecutar un SP que no devuelve datos
        public void EjecutarSP(string nombreSP, Dictionary<string, object> parametros)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                        
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el SP", ex);
                }
            }
        }

        // Método para ejecutar un SP que devuelve datos
        public DataTable EjecutarSPConResultado(string nombreSP, Dictionary<string, object> parametros)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(nombreSP, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar el SP", ex);
                }
            }

        }

    }
}
