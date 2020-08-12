using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using EASendMail;
using System.Threading.Tasks;

namespace Cotizador.Common
{
    public class Funciones
    {
        public static bool sendEmail() {
            try
            {
                SmtpMail oMail = new SmtpMail("TryIt");

                // Your gmail email address
                oMail.From = "jespinoza2292@gmail.com";
                // Set recipient email address
                oMail.To = "jespinoza2292@gmail.com;raul.gamio.perez@gmail.com";

                // Set email subject
                oMail.Subject = "Test Envio de Correo";
                // Set email body
                oMail.TextBody = "Este es un correo de prueba!";

                // Gmail SMTP server address
                SmtpServer oServer = new SmtpServer("smtp.gmail.com");

                // Gmail user authentication
                // For example: your email is "gmailid@gmail.com", then the user should be the same
                oServer.User = "XXX@gmail.com";
                oServer.Password = "XXX";

                // Set 465 port
                oServer.Port = 465;

                // detect SSL/TLS automatically
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;


                SmtpClient oSmtp = new SmtpClient();
                oSmtp.SendMail(oServer, oMail);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
