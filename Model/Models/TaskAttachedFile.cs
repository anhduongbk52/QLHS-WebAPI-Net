using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TaskAttachedFile
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public DateTime? Modified { get; set; }

    public int? ModifiedBy { get; set; }

    public int? CanSave { get; set; }

    public int? CanPrint { get; set; }

    public int? TotalPage { get; set; }

    public int? ConfidentialLevel { get; set; }

    public bool? IsEncrypted { get; set; }

    public byte[]? KeyFile { get; set; }

    public virtual User? ModifiedByNavigation { get; set; }

    public virtual Task Task { get; set; } = null!;
}
