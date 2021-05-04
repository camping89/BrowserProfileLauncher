using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.Entities;
using System.Collections.Generic;

namespace BrowserProfileLauncher.Application.MapperProfiles
{
    public class ProfileGroupMapperProfile : Profile
    {
        public ProfileGroupMapperProfile()
        {
            CreateMap<ProfileGroup, ProfileGroupModel>()
                .ForMember(x => x.ProfilesCount, opt => opt.MapFrom(src => src.BrowserProfiles.Count));

            CreateMap<IPagedList<ProfileGroup>, PagedList<ProfileGroupModel>>();

            CreateMap<List<ProfileGroup>, List<ProfileGroupModel>>();

            CreateMap<ProfileGroupModel, ProfileGroup>();
        }
    }
}
