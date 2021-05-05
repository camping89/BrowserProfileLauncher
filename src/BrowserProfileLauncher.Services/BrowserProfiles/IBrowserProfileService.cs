using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using BrowserProfileLauncher.Application.Models;
using System;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.BrowserProfiles
{
    public interface IBrowserProfileService
    {
        IPagedList<BrowserProfileModel> GetPagedList(UserModel user, int pageSize = 10, int pageIndex = 0);
        Task Create(BrowserProfileModel browserProfile);
        Task Update(Guid userId, BrowserProfileModel browserProfile);
        Task Delete(Guid userId, Guid profileId);
        Task<bool> Ping(Guid profileId);
        bool Ping(BrowserProfileModel profile);
        void Launch(BrowserProfileModel profile, string customAgent = null);
    }
}
