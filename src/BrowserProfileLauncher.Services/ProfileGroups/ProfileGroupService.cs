using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.ProfileGroups
{
    public class ProfileGroupService : IProfileGroupService
    {
        private readonly IUnitOfWork<BrowserProfileLauncherDbContext> _unitOfWork;
        private readonly IMapper _mapper;

        public ProfileGroupService(IUnitOfWork<BrowserProfileLauncherDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Create(ProfileGroupModel groupModel)
        {
            var entity = _mapper.Map<ProfileGroup>(groupModel);
            await _unitOfWork.GetRepository<ProfileGroup>().InsertAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(Guid groupId)
        {
            var group = await _unitOfWork.GetRepository<ProfileGroup>()
                                           .GetFirstOrDefaultAsync(predicate: x => x.Id == groupId, disableTracking: false);

            if (group != null)
            {
                _unitOfWork.GetRepository<ProfileGroup>().Delete(group);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public List<ProfileGroupModel> GetAll()
        {
            var groups = _unitOfWork.GetRepository<ProfileGroup>().GetAll().ToList();
            return _mapper.Map<List<ProfileGroupModel>>(groups);
        }

        public IPagedList<ProfileGroupModel> GetPagedList(int pageSize = 10, int pageIndex = 0)
        {
            var pagedList = _unitOfWork.GetRepository<ProfileGroup>()
                                       .GetPagedList(pageSize: pageSize,
                                                      include: x => x.Include(y => y.BrowserProfiles),
                                                      pageIndex: pageIndex,
                                                      orderBy: x => x.OrderBy(y => y.GroupName));

            return _mapper.Map<PagedList<ProfileGroupModel>>(pagedList);
        }

        public async Task Update(ProfileGroupModel groupModel)
        {
            var foundGroup = await _unitOfWork.GetRepository<ProfileGroup>()
                                         .GetFirstOrDefaultAsync(predicate: x => x.Id == groupModel.Id);

            if (foundGroup != null)
            {
                _mapper.Map(groupModel, foundGroup);
                foundGroup.ModifiedTime = DateTime.UtcNow;
            }
            _unitOfWork.GetRepository<ProfileGroup>().Update(foundGroup);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
