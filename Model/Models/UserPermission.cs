using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class UserPermission
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public int PermissionType { get; set; }

    public virtual User User { get; set; } = null!;
}
