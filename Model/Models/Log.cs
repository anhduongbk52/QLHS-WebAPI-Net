using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Log
{
    public int Id { get; set; }

    public DateTime Created { get; set; }

    public int UserId { get; set; }

    public string? Ipaddress { get; set; }

    public int? Port { get; set; }

    public string? Description { get; set; }

    public LogType LogType { get; set; }

    public virtual User User { get; set; } = null!;
}
