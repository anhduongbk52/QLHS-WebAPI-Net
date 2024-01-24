using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class UserSignatureDocument
{
    public int Id { get; set; }

    public int SignatureDocumentId { get; set; }

    public int UserId { get; set; }

    public bool Signed { get; set; }

    public bool IsDeny { get; set; }

    public string? DenyReason { get; set; }

    public int? SignatureType { get; set; }

    public int AssignedByUserId { get; set; }

    public string? SignComment { get; set; }

    public int SignatureIndex { get; set; }

    public virtual User AssignedByUser { get; set; } = null!;

    public virtual SignatureDocument SignatureDocument { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
