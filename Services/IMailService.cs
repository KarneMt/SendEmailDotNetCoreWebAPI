using SendEmailDotNetCoreWebAPI.Model;
using System.Threading.Tasks;

namespace SendEmailDotNetCoreWebAPI.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
        
    }
}
