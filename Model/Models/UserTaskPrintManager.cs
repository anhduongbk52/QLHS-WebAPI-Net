using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class UserTaskPrintManager
{
    public int Id { get; set; }

    public int UserTaskId { get; set; }

    public int PageNumber { get; set; }

    public int PrintCount { get; set; }

    public DateTime? TimePrint { get; set; }

    public string? PrinterName { get; set; }

    public bool? Success { get; set; }

    public bool? Revoked { get; set; }

    public int? PrintedRevoked { get; set; }

    public DateTime? TimeDisposed { get; set; }

    public int? UserDisposedId { get; set; }

    public virtual UserTask UserTask { get; set; } = null!;
}
