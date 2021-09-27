using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;

namespace TwitterShowcaseLibrary.Services
{
    public interface IUserService
    {
        Task<TwitterUserModel> GetUserData(string bearerToken, string screenName);
    }
}
