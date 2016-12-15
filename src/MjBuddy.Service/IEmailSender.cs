using System.Threading.Tasks;

namespace MjBuddy.Service
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
