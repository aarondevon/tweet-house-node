using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public interface IGetTweetBasedOnKeyword
    {
        Task<StatusModel> ReturnTweetDataBasedOnKeyword(string bearerToken, string keyword);
    }
}
