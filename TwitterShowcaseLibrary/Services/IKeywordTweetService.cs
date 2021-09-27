using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Services
{
    public interface IKeywordTweetService
    {
        Task<StatusModel> GetTweetDataBasedOnKeyword(string bearerToken, string keyword);
    }
}
