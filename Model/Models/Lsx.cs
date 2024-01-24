using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Lsx
{
    public int Id { get; set; }

    public string? DofficeNumber { get; set; }

    public string? Khnumber { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? FromDepartmentId { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateIssued { get; set; }

    public DateTime? DateCreate { get; set; }

    public int? UserCreateId { get; set; }

    public string? Reference { get; set; }

    public string? ContentRequest { get; set; }

    public string? TimeRequest { get; set; }

    public int? ReceiveDepartmentId { get; set; }

    public int? FilePdfId { get; set; }

    public bool? IsFinish { get; set; }

    public string? Content { get; set; }

    public virtual ICollection<FileOfLsx> FileOfLsxes { get; set; } = new List<FileOfLsx>();

    public virtual Department? FromDepartment { get; set; }

    public virtual ICollection<LsxProduct> LsxProducts { get; set; } = new List<LsxProduct>();

    public virtual ICollection<MainJobTodo> MainJobTodos { get; set; } = new List<MainJobTodo>();

    public virtual User? UserCreate { get; set; }
}
