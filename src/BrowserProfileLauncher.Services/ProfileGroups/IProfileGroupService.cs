using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using BrowserProfileLauncher.Application.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.ProfileGroups
{
    public interface IProfileGroupService
    {
        List<ProfileGroupModel> GetAll();
        IPagedList<ProfileGroupModel> GetPagedList(int pageSize = 10, int pageIndex = 0);
        Task Create(ProfileGroupModel groupModel);
        Task Update(ProfileGroupModel groupModel);
        Task Delete(Guid groupId);
    }
}
