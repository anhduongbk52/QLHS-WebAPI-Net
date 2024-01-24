using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class VoltageTransformerInfo
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public double? SystemVoltage { get; set; }

    public double? HeighestVoltage { get; set; }

    public string? PrimaryVoltage1 { get; set; }

    public string? PrimaryVoltage2 { get; set; }

    public string? PrimaryVoltage3 { get; set; }

    public string? PrimaryVoltage4 { get; set; }

    public string? SercondaryVoltage1 { get; set; }

    public string? SercondaryVoltage2 { get; set; }

    public string? SercondaryVoltage3 { get; set; }

    public string? SercondaryVoltage4 { get; set; }

    public int NumberOfPhases { get; set; }

    public int RatedFrequency { get; set; }

    public double? Burrden1 { get; set; }

    public double? Burrden2 { get; set; }

    public double? Burrden3 { get; set; }

    public double? Burrden4 { get; set; }

    public string? Acuracy1 { get; set; }

    public string? Acuracy2 { get; set; }

    public string? Acuracy3 { get; set; }

    public string? Acuracy4 { get; set; }

    public string? Pdm { get; set; }

    public string? KiHieu { get; set; }

    public string? Station { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
