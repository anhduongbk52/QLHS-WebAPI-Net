using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class RequestPermissionDocument
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public bool CanView { get; set; }

    public bool CanSave { get; set; }

    public bool CanPrint { get; set; }

    public string? Reason { get; set; }

    public int Status { get; set; }

    public DateTime TimeCreate { get; set; }

    public DateTime? TimeFinnish { get; set; }

    public string? DenyReason { get; set; }

    public int UserCreateId { get; set; }

    public int? UserProcessId { get; set; }

    public virtual Task Task { get; set; } = null!;

    public virtual User UserCreate { get; set; } = null!;

    public virtual User? UserProcess { get; set; }
}
