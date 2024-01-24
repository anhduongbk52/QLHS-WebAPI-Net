using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class File
{
    public int Id { get; set; }

    public string FilePath { get; set; } = null!;

    public string? FileName { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? UserCreateId { get; set; }

    public DateTime? ModifiedTime { get; set; }

    public int? ModifiedByUserId { get; set; }

    public string? Description { get; set; }

    public byte[]? DecryptKey { get; set; }

    public virtual ICollection<TransformerManual> TransformerManuals { get; set; } = new List<TransformerManual>();

    public virtual User? UserCreate { get; set; }
}
