using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class RequestSendDocumentToDepartment
{
    public int Id { get; set; }

    public int RequestSendDocumentId { get; set; }

    public int DepartmentId { get; set; }

    public bool CanRead { get; set; }

    public bool CanSave { get; set; }

    public bool CanPrint { get; set; }

    public bool CanForward { get; set; }

    public bool IsDone { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual RequestSendDocument RequestSendDocument { get; set; } = null!;
}
