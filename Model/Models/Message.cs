using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Message
{
    public int Id { get; set; }

    public int FromUserId { get; set; }

    public int ToUserId { get; set; }

    public DateTime Sent { get; set; }

    public int Status { get; set; }

    public byte[] Data { get; set; } = null!;

    public virtual User FromUser { get; set; } = null!;

    public virtual User ToUser { get; set; } = null!;
}
