using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Sampekey.Contex;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Sampekey.Model.Identity;

namespace Sampekey.Interface
{
    public interface IUser
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> FindUserByUserName(SampekeyUserAccountRequest userAccountRequest);
        Task<IdentityResult> CreateUser(SampekeyUserAccountRequest userAccountRequest);
        Task<IdentityResult> AddDefaultRoleToUser(User user);
        Task<IList<Claim>> GetClaimsFromUser(User user);
        Task<IList<string>> GetRolesFromUser(User user);
    }
}

