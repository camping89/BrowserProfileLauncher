using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.BrowserProfiles
{
    public class BrowserProfileService : IBrowserProfileService
    {
        private readonly IUnitOfWork<BrowserProfileLauncherDbContext> _unitOfWork;
        private readonly IMapper _mapper;

        public BrowserProfileService(IUnitOfWork<BrowserProfileLauncherDbContext> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task Create(BrowserProfileModel browserProfile)
        {
            var entity = _mapper.Map<BrowserProfile>(browserProfile);
            await _unitOfWork.GetRepository<BrowserProfile>().InsertAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task Delete(Guid userId, Guid profileId)
        {
            var profile = await _unitOfWork.GetRepository<BrowserProfile>()
                                           .GetFirstOrDefaultAsync(predicate: x => x.UserId == userId && x.Id == profileId);

            if (profile != null)
            {
                _unitOfWork.GetRepository<BrowserProfile>().Delete(profile);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public IPagedList<BrowserProfileModel> GetPagedList(Guid userId, int pageSize = 10, int pageIndex = 0)
        {
            try
            {
                var pagedList = _unitOfWork.GetRepository<BrowserProfile>()
                                      .GetPagedList(predicate: x => x.UserId == userId,
                                                         pageSize: pageSize,
                                                         pageIndex: pageIndex,
                                                         orderBy: x => x.OrderBy(y => y.ProfileName),
                                                         include: x => x.Include(y => y.Group));

                return _mapper.Map<IPagedList<BrowserProfile>, PagedList<BrowserProfileModel>>(pagedList);

            }
            catch (Exception exception)
            {

                throw exception;
            }
        }

        public async Task Update(Guid userId, BrowserProfileModel browserProfile)
        {
            var foundProfile = await _unitOfWork.GetRepository<BrowserProfile>()
                                           .GetFirstOrDefaultAsync(predicate: x => x.UserId == userId && x.Id == browserProfile.Id);

            if (foundProfile != null)
            {
                //foundProfile.ProfileName = browserProfile.ProfileName;
                //foundProfile.ProxyIp = browserProfile.ProxyIp;
                //foundProfile.ProxyPort = browserProfile.ProxyPort;
                //foundProfile.ProxyUsername = browserProfile.ProxyUsername;
                //foundProfile.ProxyPassword = browserProfile.ProxyPassword;
                //foundProfile.ProxyProtocol = browserProfile.ProxyProtocol;
                _mapper.Map(browserProfile, foundProfile);
                foundProfile.ModifiedTime = DateTime.UtcNow;
            }
            _unitOfWork.GetRepository<BrowserProfile>().Update(foundProfile);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
