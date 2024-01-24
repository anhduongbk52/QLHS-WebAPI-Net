using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class UserDepartment
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int DepartmentId { get; set; }

    public int? PositionId { get; set; }

    public int? PriorityProcessing { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Position? Position { get; set; }

    public virtual User User { get; set; } = null!;
}
