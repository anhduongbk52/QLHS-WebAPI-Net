using QLHS_WEB_API.Repositories;

namespace QLHS_WEB_API.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string GetFullNameByUserName(string userName)
        {
            return _userRepository.GetFullNameByUserName(userName);
        }
    }
}
