using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class DepartmentTask
{
    public int Id { get; set; }

    public int DepartmentId { get; set; }

    public int TaskId { get; set; }

    public int AssignedByUserId { get; set; }

    public int ProcessedByUserId { get; set; }

    public bool CanPrint { get; set; }

    public bool CanSave { get; set; }

    public bool CanViewFileAttachment { get; set; }

    public bool IsProcess { get; set; }

    public int IndexInTree { get; set; }

    public virtual User AssignedByUser { get; set; } = null!;

    public virtual Department Department { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
