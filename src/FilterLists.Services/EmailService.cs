using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace FilterLists.Services
{
    [UsedImplicitly]
    public class EmailService
    {
        private readonly SendGridClient sendGridClient;
        private readonly EmailAddress fromEmailAddress;
        private readonly EmailAddress toEmailAddress;

        public EmailService(IConfiguration configuration)
        {
            var sendGridConfig = configuration.GetSection("SendGrid");
            sendGridClient = new SendGridClient(sendGridConfig.GetValue<string>("ApiKey"));
            fromEmailAddress = new EmailAddress(sendGridConfig.GetSection("From").GetValue<string>("EmailAddress"),
                sendGridConfig.GetSection("From").GetValue<string>("Name"));
            toEmailAddress = new EmailAddress(sendGridConfig.GetSection("To").GetValue<string>("EmailAddress"),
                sendGridConfig.GetSection("To").GetValue<string>("Name"));
        }

        public async Task SendEmailAsync(string subjectBody, string message)
        {
            var msg = new SendGridMessage
            {
                From = fromEmailAddress,
                Subject = "[FilterLists] " + subjectBody,
                PlainTextContent = message
            };
            msg.AddTo(toEmailAddress);
            await sendGridClient.SendEmailAsync(msg);
        }
    }
}