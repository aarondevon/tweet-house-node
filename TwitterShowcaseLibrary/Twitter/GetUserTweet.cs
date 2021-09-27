using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public class GetUserTweet : IGetUserTweet
    {
        public async Task<List<TweetModel>> ReturnTweetDataBasedOnUser(string bearerToken, string user)
        {
            using(var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

                var url = new Uri($"https://api.twitter.com/1.1/statuses/user_timeline.json?screen_name={user}&count=25&tweet_mode=extended");
                var response = await client.GetAsync(url);

                string json;

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }

                List<TweetModel> tweetData = JsonConvert.DeserializeObject<List<TweetModel>>(json);

                return tweetData;
            }
        
        }
    }
}
