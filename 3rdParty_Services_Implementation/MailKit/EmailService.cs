using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdParty_Services_Implementation.MailKit
{
    public class EmailService : IEmailService
    {
        public async Task SendEmailAsync(string toEmail, string subject, string body)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Your mail title", "Your root email\r\n")); //minhnvse172756@
            emailMessage.To.Add(new MailboxAddress("", toEmail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = body };

            using (var client = new SmtpClient())
            {
                // Connect to the SMTP server
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                // Authenticate with your email and App Password
                await client.AuthenticateAsync("Your root email", "gxlf jvio clpb gsto"); // Use your Gmail Password here

                // Send the email
                await client.SendAsync(emailMessage);

                // Disconnect from the SMTP server
                await client.DisconnectAsync(true);
            }
        }
    }
}
