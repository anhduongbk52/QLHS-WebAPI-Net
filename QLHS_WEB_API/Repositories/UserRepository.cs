using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace QLHS_WEB_API.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static int LOGIN_ATTEMPT_MAX = 5;
        private readonly EemcdrContext _eemcdrContext;
        public UserRepository(EemcdrContext eemcdrContext)
        {
            _eemcdrContext = eemcdrContext;
        }
        public string GetFullNameByUserName(string userName)
        {
            var user= _eemcdrContext.Users
            .Where(x => x.UserName == userName)
            .FirstOrDefault();
            return user?.FullName??"";
        }

        public User GetUserById(int id)
        {
            var user= _eemcdrContext.Users
            .Where(x => x.Id == id)
            .FirstOrDefault();
            return user ?? throw new Exception("Can not find user with Id="+id);
        }

        public LoginResult Validate(string userName, string password)
        {
            User? user = _eemcdrContext.Users.FirstOrDefault(x => x.UserName.ToUpper() == userName.ToUpper());
            if (user is null)
            {
                return LoginResult.InvalidUsernameOrPassword;
            }
            else
            {
                if (user.AttemptCount >= LOGIN_ATTEMPT_MAX)
                {
                    return LoginResult.MAX_ATTEMPT_COUNT;
                }
                else
                if (user.Password.SequenceEqual(Convert.FromBase64String(password)))
                {
                    if (user.IsLocked==true)
                    {
                        return LoginResult.AccountLocked;
                    }
                    else
                    {
                        user.LastLogin = DateTime.Now;
                        user.AttemptCount = 0;
                        user.Status = UserStatus.ACTIVED | UserStatus.ONLINE;
                        _eemcdrContext.SaveChanges();
                        return LoginResult.Success;
                    }
                }
                else
                {
                    user.AttemptCount++;
                    _eemcdrContext.Logs.Add(new Log
                    {
                        UserId = user.Id,
                        Created = DateTime.Now,
                        Description = $"Tài khoản {userName} nhập sai mật khẩu",
                        LogType = LogType.LOGIN
                    });
                    _eemcdrContext.SaveChanges();
                    return LoginResult.InvalidUsernameOrPassword;
                }
            }
        }
    }
}
