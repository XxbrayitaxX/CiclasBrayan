using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entity;
using MySql.Data.MySqlClient;

namespace Modelo
{
    public class BaseDeDatos : ConexionMySql
    {
            public int GuardarCliente(string nombre, string correo, string contraseña, bool verificado, string codigoVerificacion)
            {
                MySqlCommand cmd = GetConnection().CreateCommand();
                cmd.CommandText = "INSERT INTO Cliente (nombre, correo, contraseña, verificado, codigo_verificacion) " +
                                  "VALUES (@nombre, @correo, @contraseña, @verificado, @codigoVerificacion)";
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@verificado", verificado);
                cmd.Parameters.AddWithValue("@codigoVerificacion", codigoVerificacion);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas;
            }
        
        public List<ClienteEntity> MostrarClientes()
        {
            List<ClienteEntity> listaClientes = new List<ClienteEntity>();

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClienteEntity cliente = new ClienteEntity();
                cliente.nombre = reader["nombre"].ToString();
                cliente.correo = reader["correo"].ToString();
                cliente.contraseña = reader["contraseña"].ToString();
                listaClientes.Add(cliente);
            }

            return listaClientes;
        }

        public ClienteEntity ValidarLogin(string correo, string contraseña)
        {
            ClienteEntity cliente = null;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Cliente WHERE correo = @correo AND contraseña = @contraseña AND verificado = true";
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new ClienteEntity();
                cliente.nombre = reader["nombre"].ToString();
                cliente.correo = reader["correo"].ToString();
                cliente.contraseña = reader["contraseña"].ToString();
            }

            return cliente;
        }


        public bool VerificarCodigoEnBaseDeDatos(string correo, string codigoVerificacion)
        {
            try
            {
                MySqlCommand cmd = GetConnection().CreateCommand();
                cmd.CommandText = "UPDATE Cliente SET verificado = true WHERE correo = @correo AND codigo_verificacion = @codigoVerificacion";
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@codigoVerificacion", codigoVerificacion);

                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;  // Asegura que al menos una fila haya sido actualizada
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al verificar el código: " + ex.Message);
                return false;
            }
        }

        public bool UsuarioEstaVerificado(string correo)
        {
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT verificado FROM Cliente WHERE correo = @correo";
            cmd.Parameters.AddWithValue("@correo", correo);

            var resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                return Convert.ToBoolean(resultado);
            }

            return false;
        }

        public ClienteEntity IniciarSesion(string correo, string contraseña)
        {
            ClienteEntity cliente = null;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM Cliente WHERE correo = @correo AND contraseña = @contraseña AND verificado = true";
            cmd.Parameters.AddWithValue("@correo", correo);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                cliente = new ClienteEntity();
                cliente.nombre = reader["nombre"].ToString();
                cliente.correo = reader["correo"].ToString();
                cliente.contraseña = reader["contraseña"].ToString();
            }

            return cliente;
        }


    }

}