using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Contract
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int UserUploadId { get; set; }

    public string? ContractName { get; set; }

    public string? FilePath { get; set; }

    public string? ContractDescription { get; set; }

    public DateTime? Date { get; set; }

    public bool Deleted { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual User UserUpload { get; set; } = null!;
}
