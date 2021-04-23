using BrowserProfileLauncher.Application.Models;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.Accounts
{
    public interface IAccountService
    {
        Task<UserModel> LoginAsync(string username, string password);
    }
}
