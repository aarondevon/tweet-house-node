using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Services;

namespace API.Controllers
{
    [Route("api/keyword/{keyword}")]
    [ApiController]
    public class TwitterKeywordController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IKeywordTweetService _keywordTweetService;
        
        public TwitterKeywordController(IConfiguration configuration, IKeywordTweetService keywordTweetService)
        {
            _configuration = configuration;
            _keywordTweetService = keywordTweetService;
        }

        public async Task<IActionResult> getKeywordTweet(string keyword)
        {
            string bearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN");

            var result = await _keywordTweetService.GetTweetDataBasedOnKeyword(bearerToken, keyword);

            return Ok(result);
        }
    }
}
