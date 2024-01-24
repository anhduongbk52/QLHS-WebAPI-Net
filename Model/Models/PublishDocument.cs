using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class PublishDocument
{
    public int Id { get; set; }

    public string? DocumentName { get; set; }

    public string? FileNameWithEx { get; set; }

    public DateTime? DateCreate { get; set; }

    public DateTime? DateUpload { get; set; }

    public DateTime? DateValid { get; set; }

    public DateTime? LastModify { get; set; }

    public int? DesignerId { get; set; }

    public int? CheckerId { get; set; }

    public int? ManagerId { get; set; }

    public string? Note { get; set; }

    public int? UserCreateId { get; set; }

    public string FtpPath { get; set; } = null!;

    public int Version { get; set; }

    public int? Type { get; set; }

    public int Deleted { get; set; }

    public string? Hash { get; set; }

    public virtual User? Checker { get; set; }

    public virtual User? Designer { get; set; }

    public virtual User? Manager { get; set; }

    public virtual ICollection<PublishDocumentOfProduct> PublishDocumentOfProducts { get; set; } = new List<PublishDocumentOfProduct>();

    public virtual ICollection<RequestSendDocument> RequestSendDocuments { get; set; } = new List<RequestSendDocument>();

    public virtual User? UserCreate { get; set; }
}
