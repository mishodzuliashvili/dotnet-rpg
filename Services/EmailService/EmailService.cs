using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MimeKit;

namespace dotnet_rpg.Services.EmailService
{
    public class EmailService : IEmailService
    {
        public async Task<ServiceResponse<GetEmailDto>> SendEmail(SendEmailDto email)
        {
            var my_email = new MimeMessage();
            my_email.From.Add(MailboxAddress.Parse("kaci.frami@ethereal.email"));
            my_email.To.Add(MailboxAddress.Parse(email.To));
            my_email.Subject = email.Subject;
            my_email.Body = new TextPart(MimeKit.Text.TextFormat.Plain) { Text = email.Body };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate("kaci.frami@ethereal.email", "bQt8F1Pb62dBcAwqJ5");
            await smtp.SendAsync(my_email);
            smtp.Disconnect(true);

            return new ServiceResponse<GetEmailDto>
            {
                Data = new GetEmailDto
                {
                    To = email.To,
                    Subject = email.Subject,
                    Body = email.Body
                }
            };
        }
    }
}