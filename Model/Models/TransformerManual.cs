using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class TransformerManual
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int FileId { get; set; }

    public int? Version { get; set; }

    public int? DocTitleId { get; set; }

    public bool IsDeleted { get; set; }

    public string? DocumentName { get; set; }

    public string? GroupName { get; set; }

    public virtual DocTittle? DocTitle { get; set; }

    public virtual File File { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
