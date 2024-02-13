using System;


namespace Model.Models
{
    [Flags]
    public enum UserStatus : int
    {
        DEACTIVE = 0,
        ACTIVED = 1,
        ONLINE = 2,
        OFFLINE = 4,
        NOT_LOGGED_YET = 8
    }
}
