using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace Farmacias.Service.Jwt
{
    public class EmailService
    {
        //crearse una cuenta en https://www.mailgun.com/ poner sus credenciales en las siguientes variables
        /// Servidor de mensajeria https://www.mailgun.com/
        private readonly string _smtpServer = "smtp.mailgun.org";

        private readonly int _smtpPort = 587;
        private readonly string _smtpUser = "postmaster@sandboxa6f54468544c4b608eda516df11b44bd.mailgun.org";
        private readonly string _smtpPass = "b7cf9373c13f94813a8338c562b4a06a-afce6020-1155f5a3";

        public async Task SendVerificationEmailAsync(string email, string token)
        {
            var message = new MailMessage();
            message.From = new MailAddress("no-reply@tudominio.com");
            message.To.Add(email);
            message.Subject = "Token de validación";
            message.Body = $"Este es tu token de validación: {token}";
            message.IsBodyHtml = true;

            using (var client = new SmtpClient(_smtpServer, _smtpPort))
            {
                client.Credentials = new NetworkCredential(_smtpUser, _smtpPass);
                client.EnableSsl = true;

                await client.SendMailAsync(message);
            }
        }

        public string GenerateVerificationToken()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                var bytes = new byte[32];
                rng.GetBytes(bytes);
                return Convert.ToBase64String(bytes);
            }
        }
    }
}