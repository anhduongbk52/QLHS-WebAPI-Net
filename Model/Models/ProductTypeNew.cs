using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class ProductTypeNew
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public string TypeCode { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
