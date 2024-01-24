using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class RequestSendDocument
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public int UserCreateId { get; set; }

    public int? WorkUserId { get; set; }

    public int? PiorityIndex { get; set; }

    public DateTime? DoneDate { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? IsDone { get; set; }

    public bool IsExperied { get; set; }

    public int PublishDocumentId { get; set; }

    public int? ConfidentialLevel { get; set; }

    public int DepartmentOwnerId { get; set; }

    public bool Revoked { get; set; }

    public int? TaskId { get; set; }

    public bool? RequireStamp { get; set; }

    public int RequireRevokeStatus { get; set; }

    public string? ReasonRevoke { get; set; }

    public virtual Department DepartmentOwner { get; set; } = null!;

    public virtual PublishDocument PublishDocument { get; set; } = null!;

    public virtual ICollection<RequestSendDocumentToDepartment> RequestSendDocumentToDepartments { get; set; } = new List<RequestSendDocumentToDepartment>();

    public virtual User UserCreate { get; set; } = null!;

    public virtual User? WorkUser { get; set; }
}
