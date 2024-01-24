using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class PublicFile
{
    public int Id { get; set; }

    public string FilePath { get; set; } = null!;

    public string? FileExtension { get; set; }

    public DateTime? CreateTime { get; set; }

    public int? UserCreateId { get; set; }

    public string? Description { get; set; }

    public byte[]? DecryptKey { get; set; }

    public string? FileName { get; set; }

    public virtual ICollection<FileOfLsx> FileOfLsxes { get; set; } = new List<FileOfLsx>();
}
