using Arch.EntityFrameworkCore.UnitOfWork;
using Arch.EntityFrameworkCore.UnitOfWork.Collections;
using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.DbContexts;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<BrowserProfileLauncherIdentityDbContext> _unitOfWork;

        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper, IUnitOfWork<BrowserProfileLauncherIdentityDbContext> unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task ChangePassword(Guid userId, string newPassword)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user != null)
            {
                await _userManager.RemovePasswordAsync(user);
                await _userManager.AddPasswordAsync(user, newPassword);
            }
        }

        public async Task Create(UserModel model)
        {
            var user = _mapper.Map<User>(model);
            await _userManager.CreateAsync(user, model.Password);
        }

        public async Task Delete(Guid userId)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                await _userManager.DeleteAsync(user);
            }
        }

        public async Task<UserModel> GetById(Guid userId)
        {
            var user = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == userId);
            if (user != null)
            {
                var userModel = _mapper.Map<User, UserModel>(user);
                userModel.RoleNames = await _userManager.GetRolesAsync(user);
                userModel.ProfileGroupIds = (await _userManager.GetClaimsAsync(user)).Where(x => x.Type == "ProfileGroup").Select(x => Guid.Parse(x.Value)).ToList();
                return userModel;
            }
            return null;
        }

        public IPagedList<UserModel> GetPagedList(int pageSize = 10, int pageIndex = 0)
        {
            var pagedList = _unitOfWork.GetRepository<User>()
                                       .GetPagedList(pageSize: pageSize,
                                                      pageIndex: pageIndex,
                                                      orderBy: x => x.OrderBy(y => y.UserName));

            return _mapper.Map<PagedList<UserModel>>(pagedList);
        }

        public async Task<UserModel> LoginAsync(string username, string password)
        {
            var user = await _userManager.FindByNameAsync(username);
            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, password, false);
                if (result.Succeeded)
                {
                    var userModel = _mapper.Map<User, UserModel>(user);
                    userModel.RoleNames = await _userManager.GetRolesAsync(user);
                    userModel.ProfileGroupIds = (await _userManager.GetClaimsAsync(user)).Where(x => x.Type == "ProfileGroup").Select(x => Guid.Parse(x.Value)).ToList();
                    return userModel;
                }
            }
            return null;
        }

        public async Task Update(UserModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                var userClaims = await _userManager.GetClaimsAsync(user);
                var profileGroupClaims = userClaims.Where(x => x.Type == "ProfileGroup");
                if (profileGroupClaims != null)
                {
                    await _userManager.RemoveClaimsAsync(user, profileGroupClaims);
                }

                if (model.ProfileGroupIds.Any())
                {
                    var newClaims = model.ProfileGroupIds.Select(profileGroupId => new Claim("ProfileGroup", profileGroupId.ToString()));
                    await _userManager.AddClaimsAsync(user, newClaims);
                }
            }
        }
    }
}
