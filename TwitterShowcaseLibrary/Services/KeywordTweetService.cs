using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;
using TwitterShowcaseLibrary.Twitter;

namespace TwitterShowcaseLibrary.Services
{
    public class KeywordTweetService : IKeywordTweetService
    {
        private readonly IGetTweetBasedOnKeyword _getTweetBasedOnKeyword;

        public KeywordTweetService(IGetTweetBasedOnKeyword getTweetBasedOnKeyword)
        {
            _getTweetBasedOnKeyword = getTweetBasedOnKeyword;
        }

        public async Task<StatusModel> GetTweetDataBasedOnKeyword(string bearerToken, string keyword)
        {
            return await _getTweetBasedOnKeyword.ReturnTweetDataBasedOnKeyword(bearerToken, keyword);
        }
    }
}
