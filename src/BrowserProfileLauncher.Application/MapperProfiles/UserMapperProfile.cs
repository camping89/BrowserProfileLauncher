using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;

namespace BrowserProfileLauncher.Application.MapperProfiles
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserModel>();

            CreateMap<IPagedList<User>, PagedList<UserModel>>();

            CreateMap<UserModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(src => $"{src.Id}@email.com"))
                .ForMember(x => x.EmailConfirmed, opt => opt.MapFrom(src => true));
        }
    }
}
