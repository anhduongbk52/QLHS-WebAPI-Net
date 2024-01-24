using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class RolePermissionD
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public int PermissionId { get; set; }

    public DateTime DateCreate { get; set; }

    public int CreateByUserId { get; set; }

    public virtual User CreateByUser { get; set; } = null!;

    public virtual Permission Permission { get; set; } = null!;

    public virtual Role Role { get; set; } = null!;
}
