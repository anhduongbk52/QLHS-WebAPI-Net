using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class FileOfBctDesign
{
    public int Id { get; set; }

    public int BctdesignId { get; set; }

    public int UserCreateId { get; set; }

    public bool IsDeleted { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public DateTime? CreateTime { get; set; }

    public string? Description { get; set; }

    public byte[]? DecryptKey { get; set; }

    public virtual Bctdesign Bctdesign { get; set; } = null!;

    public virtual User UserCreate { get; set; } = null!;
}
