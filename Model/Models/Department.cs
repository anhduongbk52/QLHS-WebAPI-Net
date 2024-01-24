using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Department
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int GroupDepartmentId { get; set; }

    public int ManagerPositionId1 { get; set; }

    public int? ManagerPositionId2 { get; set; }

    public bool Locked { get; set; }

    public virtual ICollection<DepartmentTask> DepartmentTasks { get; set; } = new List<DepartmentTask>();

    public virtual GroupDepartment GroupDepartment { get; set; } = null!;

    public virtual ICollection<Lsx> Lsxes { get; set; } = new List<Lsx>();

    public virtual Position ManagerPositionId1Navigation { get; set; } = null!;

    public virtual ICollection<Pyc> PycFromDepartments { get; set; } = new List<Pyc>();

    public virtual ICollection<Pyc> PycReceiveDepartments { get; set; } = new List<Pyc>();

    public virtual ICollection<RequestSendDocumentToDepartment> RequestSendDocumentToDepartments { get; set; } = new List<RequestSendDocumentToDepartment>();

    public virtual ICollection<RequestSendDocument> RequestSendDocuments { get; set; } = new List<RequestSendDocument>();

    public virtual ICollection<UserDepartment> UserDepartments { get; set; } = new List<UserDepartment>();
}
