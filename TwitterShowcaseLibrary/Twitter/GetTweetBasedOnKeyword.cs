using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public class GetTweetBasedOnKeyword : IGetTweetBasedOnKeyword
    {
        public async Task<StatusModel> ReturnTweetDataBasedOnKeyword(string bearerToken, string keyword)
        {
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                var url = new Uri($"https://api.twitter.com/1.1/search/tweets.json?q={keyword}&result_type=popular&tweet_mode=extended&count=15");
                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                return JsonConvert.DeserializeObject<StatusModel>(json);
            }
        }
    }
}
