using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class PycProduct
{
    public int Id { get; set; }

    public int PycId { get; set; }

    public int ProductId { get; set; }

    public int UserCreateId { get; set; }

    public virtual Product Product { get; set; } = null!;

    public virtual Pyc Pyc { get; set; } = null!;

    public virtual User UserCreate { get; set; } = null!;
}
