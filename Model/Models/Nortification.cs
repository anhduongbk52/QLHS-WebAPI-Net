using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Nortification
{
    public int Id { get; set; }

    public int Type { get; set; }

    public int UserId { get; set; }

    public string Message { get; set; } = null!;

    public DateTime TimeCreate { get; set; }

    public int Status { get; set; }

    public int Priority { get; set; }

    public virtual User User { get; set; } = null!;
}
