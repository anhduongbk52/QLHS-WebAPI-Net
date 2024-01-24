using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class SignatureDocument
{
    public int Id { get; set; }

    public string? OriginFilePath { get; set; }

    public string? SignedFilePath { get; set; }

    public int UserCreateId { get; set; }

    public DateTime? DateCreate { get; set; }

    public string FileName { get; set; } = null!;

    public string DocumentName { get; set; } = null!;

    public string? Description { get; set; }

    public int? SignatureDocumentStatus { get; set; }

    public int? ProcessorId { get; set; }

    public virtual User? Processor { get; set; }

    public virtual ICollection<UserSignatureDocument> UserSignatureDocuments { get; set; } = new List<UserSignatureDocument>();
}
