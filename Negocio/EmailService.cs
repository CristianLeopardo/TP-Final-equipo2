using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("TecnoClinicaProgramacion@gmail.com", "uctpwzdjhtkfamhw");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp.gmail.com";
        }

        public void ArmarCorreo(string correo, string asunto, string clave)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@tecnoclinica.com");
            email.To.Add(correo);
            email.Subject = asunto;
            email.Body = clave;
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
