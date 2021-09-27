using System.Collections.Generic;
using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public interface IGetUserTweet
    {
        Task<List<TweetModel>> ReturnTweetDataBasedOnUser(string bearerToken, string user);
    }
}
