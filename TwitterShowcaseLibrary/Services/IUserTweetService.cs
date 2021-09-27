using System.Collections.Generic;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Services
{
    public interface IUserTweetService
    {
        Task<List<TweetModel>> GetTweetDataBasedOnUser(string bearerToken, string user);
    }
}
