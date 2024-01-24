using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class FileOfPyc
{
    public int Id { get; set; }

    public int PycId { get; set; }

    public int UserCreateId { get; set; }

    public bool IsDeleted { get; set; }

    public string FilePath { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string FileExtension { get; set; } = null!;

    public DateTime? CreateTime { get; set; }

    public string? Description { get; set; }

    public byte[]? DecryptKey { get; set; }

    public virtual Pyc Pyc { get; set; } = null!;
}
