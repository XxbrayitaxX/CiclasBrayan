using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modelo
{
    using System;
    using MySql.Data.MySqlClient;

    public class ConexionMySql
    {
        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMySql()
        {
            // Cadena de conexión a tu base de datos local
            cadenaConexion = "Database=BDciclasBrayan;Datasource=localhost;User Id=root;Password=";
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }

            return connection;
        }
    }

}
