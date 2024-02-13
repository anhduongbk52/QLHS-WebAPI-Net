namespace Model.Models
{    public enum LoginResult
    {
        Success,
        InvalidUsernameOrPassword,
        AccountLocked,
        MAX_ATTEMPT_COUNT
    }
}
