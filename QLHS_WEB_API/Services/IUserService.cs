using Model.Models;

namespace QLHS_WEB_API.Services
{
    public interface IUserService
    {
        string GetFullNameByUserName(string userName);
        User GetUserById(int id);
        LoginResult Validate(string  userName, string password);
    }
}
