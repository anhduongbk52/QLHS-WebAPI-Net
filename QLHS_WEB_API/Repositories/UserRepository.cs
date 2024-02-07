using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace QLHS_WEB_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly EemcdrContext _eemcdrContext;
        public UserRepository(EemcdrContext eemcdrContext)
        {
            _eemcdrContext = eemcdrContext;
        }
        public string GetFullNameByUserName(string userName)
        {
            return _eemcdrContext.Users
            .Where(x => x.UserName == userName)
            .FirstOrDefault().FullName;           
        }
    }
}
