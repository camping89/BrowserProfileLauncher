using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.Entities;

namespace BrowserProfileLauncher.Application.MapperProfiles
{
    public class ProfileGroupMapperProfile : Profile
    {
        public ProfileGroupMapperProfile()
        {
            CreateMap<ProfileGroup, ProfileGroupModel>()
                .ForMember(x => x.ProfilesCount, opt => opt.MapFrom(src => src.BrowserProfiles.Count));

            CreateMap<IPagedList<ProfileGroup>, PagedList<ProfileGroupModel>>();

            CreateMap<ProfileGroupModel, ProfileGroup>();
        }
    }
}
