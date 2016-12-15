using System.Threading.Tasks;

namespace MjBuddy.Service
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
