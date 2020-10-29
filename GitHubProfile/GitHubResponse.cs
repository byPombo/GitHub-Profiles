using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace GitHubProfile
{
    public class GitHubResponse
    {
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("followers")]
        public int Followers { get; set; }
        [JsonProperty("public_repos")]
        public int Public_Repos { get; set; }
    }
}
