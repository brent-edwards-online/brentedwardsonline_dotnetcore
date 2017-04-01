using System.Threading.Tasks;

namespace BrentEdwardsOnlineDotNetCore.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
