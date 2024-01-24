using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class LoginManager
{
    public int Id { get; set; }

    public int LoginUserId { get; set; }

    public DateTime LoginTime { get; set; }

    public string? LoginIp { get; set; }

    public string? ComputerName { get; set; }

    public int LogType { get; set; }

    public bool? Trusted { get; set; }

    public string? Description { get; set; }

    public string? ApplicationVersion { get; set; }

    public string? ApplicationName { get; set; }

    public virtual User LoginUser { get; set; } = null!;
}
