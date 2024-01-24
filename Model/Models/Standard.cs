using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Standard
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? UserCreateId { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<TransformerInfo> TransformerInfos { get; set; } = new List<TransformerInfo>();

    public virtual User? UserCreate { get; set; }
}
