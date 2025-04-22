using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using Modelo.Entity;
using MySql.Data.MySqlClient;

namespace Logica
{
    public class ClienteController
    {
        // Guardar cliente en la base de datos
        public int GuardarCliente(string nombre, string correo, string contraseña, bool verificado, string codigoVerificacion)
        {
            BaseDeDatos db = new BaseDeDatos();
            int resultado = db.GuardarCliente(nombre, correo, contraseña, verificado, codigoVerificacion);

            // Si el cliente se guardó correctamente, enviar el correo
            if (resultado > 0)
            {
                EnviarCorreoVerificacion(correo, codigoVerificacion);
            }

            return resultado;
        }

        // Mostrar lista de clientes
        public List<ClienteEntity> MostrarClientes()
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.MostrarClientes();
        }

        // Iniciar sesión de cliente
        public ClienteEntity IniciarSesion(string correo, string contraseña)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.ValidarLogin(correo, contraseña);  // Verifica solo si el usuario está verificado
        }


        // Método para enviar el correo de verificación
        public void EnviarCorreoVerificacion(string destinatario, string codigoVerificacion)
        {
            EmailService emailService = new EmailService(); // Crear instancia de EmailService
            emailService.EnviarCorreoVerificacion(destinatario, codigoVerificacion);
        }

        public bool VerificarCodigo(string correo, string codigoVerificacion)
        {
            BaseDeDatos db = new BaseDeDatos();
            return db.VerificarCodigoEnBaseDeDatos(correo, codigoVerificacion);
        }
    }


}

