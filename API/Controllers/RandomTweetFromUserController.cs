using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;
using TwitterShowcaseLibrary.Services;

namespace API.Controllers
{
    [Route("api/random-tweet/{user}")]
    [ApiController]
    public class RandomTweetFromUserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserTweetService _userTweet;

        public RandomTweetFromUserController(IConfiguration configuration, IUserTweetService userTweet)
        {
            _configuration = configuration;
            _userTweet = userTweet;
        }

        private TweetModel GetRandomUserTweet(List<TweetModel> tweets)
        {
            var random = new Random();
            int index = random.Next(tweets.Count);
            return tweets[index];
        }

        public async Task<IActionResult> getUserTweet(string user)
        {
            string bearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN");

            var result = await _userTweet.GetTweetDataBasedOnUser(bearerToken, user);

            return Ok(GetRandomUserTweet(result));
        }
    }
}
