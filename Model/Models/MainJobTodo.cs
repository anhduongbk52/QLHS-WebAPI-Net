using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class MainJobTodo
{
    public int Id { get; set; }

    public int? LsxId { get; set; }

    public string? JobHeader { get; set; }

    public int UserCreateId { get; set; }

    public int ProcessUserId { get; set; }

    public string? JobName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual Lsx? Lsx { get; set; }

    public virtual User ProcessUser { get; set; } = null!;
}
