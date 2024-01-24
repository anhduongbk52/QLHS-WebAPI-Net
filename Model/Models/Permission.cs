using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Permission
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int ModulId { get; set; }

    public virtual Modul Modul { get; set; } = null!;

    public virtual ICollection<RolePermissionD> RolePermissionDs { get; set; } = new List<RolePermissionD>();
}
