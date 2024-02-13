namespace Model.Models
{
    using System;

    [Flags]
    public enum LogType : int
    {
        NONE = 0,
        LOGIN = 1,
        LOGOUT = 2,
        CREATE_USER = 3,
        EDIT_USER = 4,
        DELETE_USER = 5,
        LOCK_USER = 6,
        UNLOCK_USER = 7,
        CHANGE_PERMISSION = 8,
        PRINT_DOCUMENT = 9,
        SIGN_DOCUMENT = 10,
        CREATE_TASK = 11,
        MODIFY_TASK = 12,
        DELETE_TASK = 13,
        ADD_USER_TO_TASK = 14,
        ADD_DOCUMENT_TO_TASK = 15,
        DELETE_DOCUMENT = 16,
        START_SERVICE = 17,
        STOP_SERVICE = 18,
        RESTART_SERVICE = 19,
        SETUP_SSL = 20,
        SETUP_USER_DATA_DIR = 21,
        REVOKE_TASK = 22,
        CHANGE_DEFAULT_PASSWORD = 23,
        CHANGE_USER_PASSWORD = 24
    }
}
