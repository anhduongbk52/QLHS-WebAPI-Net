using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class Task
{
    public int Id { get; set; }

    public string Subject { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int Status { get; set; }

    public int Priority { get; set; }

    public int? AssignedUserId { get; set; }

    public int? OwnerUserId { get; set; }

    public bool? Reminder { get; set; }

    public DateTime? ReminderDateTime { get; set; }

    public bool? CanSaveFile { get; set; }

    public virtual User? AssignedUser { get; set; }

    public virtual ICollection<DepartmentTask> DepartmentTasks { get; set; } = new List<DepartmentTask>();

    public virtual User? OwnerUser { get; set; }

    public virtual ICollection<RequestPermissionDocument> RequestPermissionDocuments { get; set; } = new List<RequestPermissionDocument>();

    public virtual ICollection<TaskAttachedFile> TaskAttachedFiles { get; set; } = new List<TaskAttachedFile>();

    public virtual ICollection<UserTask> UserTasks { get; set; } = new List<UserTask>();
}
