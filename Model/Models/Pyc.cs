using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Pyc
{
    public int Id { get; set; }

    public string? DofficeNumber { get; set; }

    public string? Kdnumber { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? FromDepartmentId { get; set; }

    public int? ReceiveDepartmentId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateIssued { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? UserCreateId { get; set; }

    public int UserUploadId { get; set; }

    public bool? IsFinish { get; set; }

    public string? AllContent { get; set; }

    public string? OriginFilePath { get; set; }

    public string? AssignedFilePath { get; set; }

    public string? FileName { get; set; }

    public string? FileExtension { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual ICollection<FileOfPyc> FileOfPycs { get; set; } = new List<FileOfPyc>();

    public virtual Department? FromDepartment { get; set; }

    public virtual ICollection<MainJobTodoPyc> MainJobTodoPycs { get; set; } = new List<MainJobTodoPyc>();

    public virtual ICollection<PycProduct> PycProducts { get; set; } = new List<PycProduct>();

    public virtual Department? ReceiveDepartment { get; set; }

    public virtual User? UserCreate { get; set; }

    public virtual User UserUpload { get; set; } = null!;
}
