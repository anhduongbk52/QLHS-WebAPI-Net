using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class ApprovalDocumentProduct
{
    public int Id { get; set; }

    /// <summary>
    /// Ten cua tai lieu
    /// </summary>
    public string DocumentName { get; set; } = null!;

    public int ProductId { get; set; }

    public int Version { get; set; }

    public DateTime DateCreate { get; set; }

    public DateTime? DateExpired { get; set; }

    public bool IsExpired { get; set; }

    public string? Description { get; set; }

    public int UserCreateId { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    /// <summary>
    /// Ten file bao gom ca extension
    /// </summary>
    public string FileName { get; set; } = null!;

    public byte[]? DecryptKey { get; set; }

    public int? ExpiredByUserId { get; set; }

    /// <summary>
    /// Phe duyet lan thu ?
    /// </summary>
    public int ApprovalNumber { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User UserCreate { get; set; } = null!;
}
