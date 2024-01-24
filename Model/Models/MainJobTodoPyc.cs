using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class MainJobTodoPyc
{
    public int Id { get; set; }

    public int? PycId { get; set; }

    public string? JobHeader { get; set; }

    public int UserCreateId { get; set; }

    public int ProcessUserId { get; set; }

    public string? JobName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public virtual User ProcessUser { get; set; } = null!;

    public virtual Pyc? Pyc { get; set; }
}
