using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class FileOfLsx
{
    public int Id { get; set; }

    public int PublicFileId { get; set; }

    public int LsxId { get; set; }

    public virtual Lsx Lsx { get; set; } = null!;

    public virtual PublicFile PublicFile { get; set; } = null!;
}
