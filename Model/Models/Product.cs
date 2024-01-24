using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Product
{
    public int Id { get; set; }

    public string ProductCode { get; set; } = null!;

    public string ProductName { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public int? UserCreateId { get; set; }

    public bool IsLocked { get; set; }

    public int ProductType { get; set; }

    public int? TransformerInfoId { get; set; }

    public string? Note { get; set; }

    public int? YearOfManufacture { get; set; }

    public int? ProductTypeNewId { get; set; }

    public int? BainforId { get; set; }

    public int? VoltageTransformerInfoId { get; set; }

    public string? ProductRange { get; set; }

    public int? MofinforId { get; set; }

    public int? BiinforId { get; set; }

    public int? BctinforId { get; set; }

    public int? CvtinforId { get; set; }

    public virtual ICollection<ApprovalDocumentProduct> ApprovalDocumentProducts { get; set; } = new List<ApprovalDocumentProduct>();

    public virtual Bainfor? Bainfor { get; set; }

    public virtual Biinfor? Biinfor { get; set; }

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<LsxProduct> LsxProducts { get; set; } = new List<LsxProduct>();

    public virtual Mofinfor? Mofinfor { get; set; }

    public virtual ProductTypeNew? ProductTypeNew { get; set; }

    public virtual ICollection<PublishDocumentOfProduct> PublishDocumentOfProducts { get; set; } = new List<PublishDocumentOfProduct>();

    public virtual ICollection<PycProduct> PycProducts { get; set; } = new List<PycProduct>();

    public virtual TransformerInfo? TransformerInfo { get; set; }

    public virtual ICollection<TransformerManual> TransformerManuals { get; set; } = new List<TransformerManual>();

    public virtual User? UserCreate { get; set; }

    public virtual VoltageTransformerInfo? VoltageTransformerInfo { get; set; }
}
