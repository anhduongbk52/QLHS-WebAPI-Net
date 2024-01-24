using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Biinfor
{
    public int Id { get; set; }

    public int? NumberOfPhases { get; set; }

    public int? RatedFrequency { get; set; }

    public double? SystemVoltage { get; set; }

    public double? HeighestVoltage { get; set; }

    public double? Li { get; set; }

    public double? Ac { get; set; }

    public int? Ip1 { get; set; }

    public int? Ip2 { get; set; }

    public int? Ip3 { get; set; }

    public int? Ip4 { get; set; }

    public int? Ip5 { get; set; }

    public int? NumberOfCore { get; set; }

    public int? SecondaryRatedCurrent { get; set; }

    public double? Burrden1 { get; set; }

    public double? Burrden2 { get; set; }

    public double? Burrden3 { get; set; }

    public double? Burrden4 { get; set; }

    public double? Burrden5 { get; set; }

    public string? Acuracy1 { get; set; }

    public string? Acuracy2 { get; set; }

    public string? Acuracy3 { get; set; }

    public string? Acuracy4 { get; set; }

    public string? Acuracy5 { get; set; }

    public string? Pdm { get; set; }

    public string? KiHieu { get; set; }

    public string? Station { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
