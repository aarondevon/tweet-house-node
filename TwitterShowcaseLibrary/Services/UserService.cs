using System.Threading.Tasks;
using TwitterShowcaseLibrary.Models;
using TwitterShowcaseLibrary.Twitter;

namespace TwitterShowcaseLibrary.Services
{
    public class UserService : IUserService
    {
        private readonly IGetUserData _getUserData;

        public UserService(IGetUserData getUserData)
        {
            _getUserData = getUserData;
        }

        public async Task<TwitterUserModel> GetUserData(string bearerToken, string screenName)
        {
            return await _getUserData.ReturnUserData(bearerToken, screenName);
        }
    }
}
