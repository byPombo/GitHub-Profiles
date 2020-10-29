using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProfile
{
    interface IAuthService
    {
        [Get("/login/oauth/authorize")]
        Task GetAddressAsync();
    }
}
