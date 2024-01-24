using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class PublishDocumentOfProduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int PublishDocumentId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsInvalid { get; set; }

    public DateTime? InvalidFrom { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual PublishDocument PublishDocument { get; set; } = null!;
}
