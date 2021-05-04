using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using BrowserProfileLauncher.Application.Models;
using System;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.Accounts
{
    public interface IAccountService
    {
        Task<UserModel> LoginAsync(string username, string password);
        Task<UserModel> GetById(Guid userId);
        IPagedList<UserModel> GetPagedList(int pageSize = 10, int pageIndex = 0);
        Task ChangePassword(Guid userId, string newPassword);
        Task Create(UserModel model);
        Task Update(UserModel model);
        Task Delete(Guid userId);
    }
}
