using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Singnature
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string? Path { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? UserCreateId { get; set; }

    public int SignatureImageType { get; set; }

    public virtual User User { get; set; } = null!;

    public virtual User? UserCreate { get; set; }
}
