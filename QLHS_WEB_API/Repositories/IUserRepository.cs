using Model.Models;

namespace QLHS_WEB_API.Repositories
{
    public interface IUserRepository
    {
        string GetFullNameByUserName(string userName);     
    }
}
