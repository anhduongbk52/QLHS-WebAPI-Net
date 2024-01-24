using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class ElectricalSteelLoss
{
    public int Id { get; set; }

    public int ElectricalSteelId { get; set; }

    public double FluxDensity { get; set; }

    public int Frequency { get; set; }

    public double Loss { get; set; }

    public virtual ElectricalSteel ElectricalSteel { get; set; } = null!;
}
