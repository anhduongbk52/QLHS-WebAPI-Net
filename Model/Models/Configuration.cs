using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Configuration
{
    public int Id { get; set; }

    public int ConfigKey { get; set; }

    public byte[]? ConfigValue { get; set; }

    public int? ConfigBy { get; set; }

    public DateTime? ModifiedDateTime { get; set; }

    public virtual User? ConfigByNavigation { get; set; }
}
