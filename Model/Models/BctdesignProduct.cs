using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class BctdesignProduct
{
    public int Id { get; set; }

    public int BctdesignId { get; set; }

    public int ProductId { get; set; }

    public virtual Bctdesign Bctdesign { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
