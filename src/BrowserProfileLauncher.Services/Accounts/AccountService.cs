using AutoMapper;
using BrowserProfileLauncher.Application.Models;
using BrowserProfileLauncher.Core.EntityFramework.Entities.Identities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BrowserProfileLauncher.Services.Accounts
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMapper _mapper;
        public AccountService(UserManager<User> userManager, SignInManager<User> signInManager, IMapper mapper)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _mapper = mapper;
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
    }
}
