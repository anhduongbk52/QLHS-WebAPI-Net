using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class LsxProduct
{
    public int Id { get; set; }

    public int Lsxid { get; set; }

    public int ProductId { get; set; }

    public int UserCreateId { get; set; }

    public virtual Lsx Lsx { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
