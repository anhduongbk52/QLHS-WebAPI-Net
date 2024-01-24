using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class UserTask
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int TaskId { get; set; }

    public int AssignedBy { get; set; }

    public byte[] TaskKey { get; set; } = null!;

    public int PermissionType { get; set; }

    public bool IsProcessing { get; set; }

    public bool Seen { get; set; }

    public bool HasPrinted { get; set; }

    public bool? IsFinish { get; set; }

    public bool? CanSave { get; set; }

    public bool? CanViewAttachedFile { get; set; }

    public DateTime? TimeCreate { get; set; }

    public string? JobContent { get; set; }

    public string? DoneContent { get; set; }

    public virtual User AssignedByNavigation { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    public virtual ICollection<UserTaskPrintManager> UserTaskPrintManagers { get; set; } = new List<UserTaskPrintManager>();
}
