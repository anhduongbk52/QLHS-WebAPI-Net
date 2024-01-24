using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class DocTittle
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public int? ParentId { get; set; }

    public int? Order { get; set; }

    public virtual ICollection<TransformerManual> TransformerManuals { get; set; } = new List<TransformerManual>();
}
