using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Newtonsoft.Json.Linq;


namespace RockyProject.Utility
{
    public class EmailSender : IEmailSender  
    {
        private readonly IConfiguration _configuration;
        public MailJetSettings _mailJetSettings { get; set; }
        public EmailSender (IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendEmailAsync(string email,string subject , string htmlMessage)
        {
            return Execute(email,subject,htmlMessage);
        }
        public async Task Execute(string email,string subject,string body)
        {

            //MailjetClient client = new MailjetClient(Environment.GetEnvironmentVariable("****************************1234"), Environment.GetEnvironmentVariable("****************************abcd"))
            //{

            //};
            _mailJetSettings = _configuration.GetSection("MailJet").Get<MailJetSettings>();
            MailjetClient client = new MailjetClient("_mailJetSettings.ApiKey", "_mailJetSettings.SecretKey")
            {
                //Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            { 
                Resource = Send.Resource,
            }
             .Property(Send.Messages, new JArray {
     new JObject {
      {
       "From",
       new JObject {
        {"Email", "hugecolonyeee123@proton.me"},
        {"Name", "Abdullah"}
       }
      }, {
       "To",
       new JArray {
        new JObject {
         {
          "Email",
         email  
         }, {
          "Name",
         "hugecolony"
         }
        }
       }
      }, {
       "Subject",
       subject
      },  {
       "HTMLPart",
       body
       }
     }
             });
             await client.PostAsync(request);

        }
    }
}
