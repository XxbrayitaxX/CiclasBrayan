using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Logica
{
    public class EmailService
    {
        public void EnviarCorreoVerificacion(string destino, string codigoVerificacion)
        {
            try
            {
                var cliente = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential("brayanaguirresena@gmail.com", "xadj ljyc prex xjhw"),
                    EnableSsl = true
                };

                var mensaje = new MailMessage
                {
                    From = new MailAddress("brayanaguirresena@gmail.com", "CiclasApp"),
                    Subject = "Verificación de cuenta - CiclasApp",
                    Body = $"Tu código de verificación es: {codigoVerificacion}",
                    IsBodyHtml = false
                };

                mensaje.To.Add(destino);

                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al enviar correo: " + ex.Message);
            }
        }
    }
}

