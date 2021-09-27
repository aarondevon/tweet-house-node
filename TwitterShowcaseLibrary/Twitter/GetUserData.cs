using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public class GetUserData : IGetUserData
    {
        public async Task<TwitterUserModel> ReturnUserData(string bearerToken, string screenName)
        {
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                var url = new Uri($"https://api.twitter.com/1.1/users/show.json?screen_name={screenName}");
                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
                return JsonConvert.DeserializeObject<TwitterUserModel>(json);
            }
        }
    }
}
