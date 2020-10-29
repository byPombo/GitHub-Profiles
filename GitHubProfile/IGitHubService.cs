using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GitHubProfile
{
    interface IGitHubService
    {
        [Get("/users/{login}")]
        Task<GitHubResponse> GetAddressAsync(string login);
    }
}
