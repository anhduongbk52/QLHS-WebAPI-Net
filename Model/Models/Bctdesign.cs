using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Bctdesign
{
    public int Id { get; set; }

    public string? DesignName { get; set; }

    public int VoltageLevel { get; set; }

    public decimal? RatedVoltage { get; set; }

    public int? Ipr1 { get; set; }

    public int? Ipr2 { get; set; }

    public int? Ipr3 { get; set; }

    public int? Ipr4 { get; set; }

    public int? Ipr5 { get; set; }

    public int? Ipr6 { get; set; }

    public int? Isc1 { get; set; }

    public int? Isc2 { get; set; }

    public int? Isc3 { get; set; }

    public int? Isc4 { get; set; }

    public decimal? Burden { get; set; }

    public string? PrecisionClasses { get; set; }

    public string? DesignCode { get; set; }

    public int? TotalTurn { get; set; }

    public string? CoreMaterial { get; set; }

    public decimal? InerCoreDiameter { get; set; }

    public decimal? OuterCoreDiameter { get; set; }

    public decimal? CoreWeight { get; set; }

    public decimal? CoreHeight { get; set; }

    public decimal? WireDiameter { get; set; }

    public int? NumberWireParalel { get; set; }

    public decimal? CopperWeight { get; set; }

    public decimal? OuterDiameter { get; set; }

    public decimal? InnerDiameter { get; set; }

    public decimal? Heigh { get; set; }

    public int? NumberOfLayer { get; set; }

    public int? UserCreateId { get; set; }

    public DateTime? DateCreate { get; set; }

    public bool? IsActive { get; set; }

    public string? Description { get; set; }
}
