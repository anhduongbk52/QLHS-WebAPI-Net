using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class GroupDepartment
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();
}
