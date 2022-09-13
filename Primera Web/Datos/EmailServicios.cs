using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class EmailServicios
    {
        private MailMessage email;
        private SmtpClient server;
        public EmailServicios()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential();
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "En breve...";
        }
        public void ArmarEnvio(string EmailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress(EmailDestino);
            email.To.Add("carlosdiegosalas@gmail.com");
            email.Subject = asunto;
            email.Body = cuerpo;
        }
        public void Enviar()
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
