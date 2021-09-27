using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Twitter
{
    public interface IGetUserData
    {
        Task<TwitterUserModel> ReturnUserData(string bearerToken, string screenName);
    }
}
