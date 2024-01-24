using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class ElectricalSteel
{
    public int Id { get; set; }

    public int Type { get; set; }

    public string MaterialCode { get; set; } = null!;

    public double Thickness { get; set; }

    public double Density { get; set; }

    public double CoreLossNominal1750 { get; set; }

    public double? CoreLossNominal1760 { get; set; }

    public double? CoreLossMax1750 { get; set; }

    public double? CoreLossMax1760 { get; set; }

    public double? CoreLossNominal1550 { get; set; }

    public double? CoreLossNominal1560 { get; set; }

    public double? CoreLossMax1550 { get; set; }

    public double? CoreLossMax1560 { get; set; }

    public double? InductionMin { get; set; }

    public string? Manufacturer { get; set; }

    public string? CountryOfOrigin { get; set; }

    public virtual ICollection<ElectricalSteelLoss> ElectricalSteelLosses { get; set; } = new List<ElectricalSteelLoss>();
}
