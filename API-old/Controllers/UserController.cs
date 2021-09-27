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
    [Route("api/twitter-user/{user}")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUserService _userService;

        public UserController(IConfiguration configuration, IUserService userService)
        {
            _configuration = configuration;
            _userService = userService;
        }

        public async Task<IActionResult> getUser(string user)
        {

            string bearerToken = Environment.GetEnvironmentVariable("TWITTER_BEARER_TOKEN");

            var result = await _userService.GetUserData(bearerToken, user);

            return Ok(result);
        }

    }
}
