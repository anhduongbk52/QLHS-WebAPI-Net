using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Bainfor
{
    public int Id { get; set; }

    public string? RatedPower { get; set; }

    public string? RatedVoltage { get; set; }

    public string? RatedFrequency { get; set; }

    public int? NumberOfPhase { get; set; }

    public string? VoltageRatio { get; set; }

    public string? Station { get; set; }

    public string? Note { get; set; }

    public int? NumberOfWinding { get; set; }

    public string? ConnectionSymbol { get; set; }

    public string? CoolingMethod { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
