using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class RolePermission
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public DateTime? Created { get; set; }

    public DateTime? Modified { get; set; }

    public int PermissionType { get; set; }

    public virtual Role Role { get; set; } = null!;
}
