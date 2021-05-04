using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.BrowserProfiles
{
    public class BrowserProfileService : IBrowserProfileService
    {
        private readonly IUnitOfWork<BrowserProfileLauncherDbContext> _unitOfWork;
        private readonly IMapper _mapper;

        private readonly BrowserProfileLauncherDbContext _context;

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
                                           .GetFirstOrDefaultAsync(predicate: x => x.UserId == userId && x.Id == profileId, disableTracking: false);

            if (profile != null)
            {
                _unitOfWork.GetRepository<BrowserProfile>().Delete(profileId);
                await _unitOfWork.SaveChangesAsync();
            }
        }

        public IPagedList<BrowserProfileModel> GetPagedList(UserModel user, int pageSize = 10, int pageIndex = 0)
        {
            var pagedList = _unitOfWork.GetRepository<BrowserProfile>()
                                  .GetPagedList(predicate: x => x.UserId == user.Id || (x.GroupId != null && user.ProfileGroupIds.Contains(x.GroupId.Value)),
                                                     pageSize: pageSize,
                                                     pageIndex: pageIndex,
                                                     orderBy: x => x.OrderBy(y => y.ProfileName),
                                                     include: x => x.Include(y => y.Group));

            return _mapper.Map<IPagedList<BrowserProfile>, PagedList<BrowserProfileModel>>(pagedList);
        }

        public async Task<bool> Ping(Guid profileId)
        {
            var profile = await _unitOfWork.GetRepository<BrowserProfile>().GetFirstOrDefaultAsync(predicate: x => x.Id == profileId);
            if (profile != null)
            {
                return Ping(profile.ProxyIp, profile.ProxyPort, profile.ProxyUsername, profile.ProxyPassword);
            }
            return false;
        }

        public bool Ping(BrowserProfileModel profile)
        {
            return Ping(profile.ProxyIp, profile.ProxyPort.GetValueOrDefault(), profile.ProxyUsername, profile.ProxyPassword);
        }

        private bool Ping(string proxyIp, int proxyPort, string proxyUsername, string proxyPassword)
        {
            var proxy = new WebProxy(proxyIp, proxyPort)
            {
                Credentials = new NetworkCredential(proxyUsername, proxyPassword)
            };
            var req = WebRequest.Create("http://ip-api.com/json");
            req.Proxy = proxy;

            try
            {
                var resp = req.GetResponse();
                var json = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                var myip = (string)JObject.Parse(json)["query"];

                return myip == proxyIp;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task Update(Guid userId, BrowserProfileModel browserProfile)
        {
            var foundProfile = await _unitOfWork.GetRepository<BrowserProfile>()
                                           .GetFirstOrDefaultAsync(predicate: x => x.UserId == userId && x.Id == browserProfile.Id);

            if (foundProfile != null)
            {
                _mapper.Map(browserProfile, foundProfile);
                foundProfile.ModifiedTime = DateTime.UtcNow;
            }
            _unitOfWork.GetRepository<BrowserProfile>().Update(foundProfile);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
