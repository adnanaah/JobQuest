using System.Net.Mail;
using System.Net;

namespace SeminarskiRad_JobQuest.Services
{
    public class MailService
    {
        private readonly IConfiguration _configuration;

        public MailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendAsync(string recipientMail, string messageSubject, string messageBody, bool isBodyHtml = false)
        {
            if (string.IsNullOrEmpty(recipientMail) || !IsValidEmail(recipientMail))
                throw new ArgumentException("Invalid email address.");

            string host = _configuration.GetValue<string>("MailServer:Host");
            int port = _configuration.GetValue<int>("MailServer:Port");
            string from = _configuration.GetValue<string>("MailServer:From");
            string password = _configuration.GetValue<string>("MailServer:Password");

            using (var email = new MailMessage())
            {
                email.From = new MailAddress(from);
                email.To.Add(recipientMail);
                email.Subject = messageSubject;
                email.Body = messageBody;
                email.IsBodyHtml = isBodyHtml;

                using (var smtpClient = new SmtpClient(host, port))
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Timeout = 20000;
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(from, password);

                    try
                    {
                        await smtpClient.SendMailAsync(email);
                    }
                    catch (SmtpException smtpEx)
                    {
                        Console.WriteLine($"SMTP error: {smtpEx.Message}");
                        throw;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error sending email: {ex.Message}");
                        throw;
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
