using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Mofinfor
{
    public int Id { get; set; }

    public int? NumberOfPhases { get; set; }

    public int? RatedFrequency { get; set; }

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

    public double? Buburrden1 { get; set; }

    public double? Buburrden2 { get; set; }

    public double? Buburrden3 { get; set; }

    public double? Buburrden4 { get; set; }

    public string? Buacuracy1 { get; set; }

    public string? Buacuracy2 { get; set; }

    public string? Buacuracy3 { get; set; }

    public string? Buacuracy4 { get; set; }

    public string? Pdm { get; set; }

    public int? PrimaryCurrent1 { get; set; }

    public int? PrimaryCurrent2 { get; set; }

    public int? PrimaryCurrent3 { get; set; }

    public int? PrimaryCurrent4 { get; set; }

    public int? SercondaryCurrent1 { get; set; }

    public int? SercondaryCurrent2 { get; set; }

    public int? SercondaryCurrent3 { get; set; }

    public int? SercondaryCurrent4 { get; set; }

    public string? Biacuracy1 { get; set; }

    public string? Biacuracy2 { get; set; }

    public string? Biacuracy3 { get; set; }

    public string? Biacuracy4 { get; set; }

    public double? Biburrden1 { get; set; }

    public double? Biburrden2 { get; set; }

    public double? Biburrden3 { get; set; }

    public double? Biburrden4 { get; set; }

    public string? KiHieu { get; set; }

    public string? Station { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
