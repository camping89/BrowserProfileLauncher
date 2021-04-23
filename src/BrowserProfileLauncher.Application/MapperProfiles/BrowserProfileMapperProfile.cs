using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.Entities;

namespace BrowserProfileLauncher.Application.MapperProfiles
{
    public class BrowserProfileMapperProfile : Profile
    {
        public BrowserProfileMapperProfile()
        {
            CreateMap<BrowserProfile, BrowserProfileModel>()
                .ForMember(x => x.GroupName, opt => opt.MapFrom(src => src.Group.GroupName));

            CreateMap<IPagedList<BrowserProfile>, PagedList<BrowserProfileModel>>();

            CreateMap<BrowserProfileModel, BrowserProfile>();
        }
    }
}
