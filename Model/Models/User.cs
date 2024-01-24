using System;
using System.Collections.Generic;

namespace Model.Models;

public partial class User
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public byte[] Password { get; set; } = null!;

    public string? FullName { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? HomeTown { get; set; }

    public string? CitizenIdentification { get; set; }

    public string? MobiphoneNumber { get; set; }

    public string? Email { get; set; }

    public byte[]? Avatar { get; set; }

    public string? Title { get; set; }

    public string? Department { get; set; }

    public DateOnly? HireDate { get; set; }

    public DateTime? LastLogin { get; set; }

    public byte[]? Certificate { get; set; }

    public int? AttemptCount { get; set; }

    public int? StateId { get; set; }

    public int Status { get; set; }

    public byte[]? EcprKeyForMsg { get; set; }

    public byte[]? OldEcprKeyForMsg { get; set; }

    public byte[]? OldEcpuKeyForMsg { get; set; }

    public byte[]? EcpuKeyForMsg { get; set; }

    public byte[]? EcprKeyForFile { get; set; }

    public byte[]? OldEcprKeyForFile { get; set; }

    public byte[]? OldEcpuKeyForFile { get; set; }

    public byte[]? EcpuKeyForFile { get; set; }

    public byte[]? MasterKey { get; set; }

    public bool? IsLocked { get; set; }

    public virtual ICollection<ApprovalDocumentProduct> ApprovalDocumentProducts { get; set; } = new List<ApprovalDocumentProduct>();

    public virtual ICollection<Configuration> Configurations { get; set; } = new List<Configuration>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<DepartmentTask> DepartmentTasks { get; set; } = new List<DepartmentTask>();

    public virtual ICollection<File> Files { get; set; } = new List<File>();

    public virtual ICollection<LoginManager> LoginManagers { get; set; } = new List<LoginManager>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<Lsx> Lsxes { get; set; } = new List<Lsx>();

    public virtual ICollection<MainJobTodoPyc> MainJobTodoPycs { get; set; } = new List<MainJobTodoPyc>();

    public virtual ICollection<MainJobTodo> MainJobTodos { get; set; } = new List<MainJobTodo>();

    public virtual ICollection<Message> MessageFromUsers { get; set; } = new List<Message>();

    public virtual ICollection<Message> MessageToUsers { get; set; } = new List<Message>();

    public virtual ICollection<Nortification> Nortifications { get; set; } = new List<Nortification>();

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public virtual ICollection<PublishDocument> PublishDocumentCheckers { get; set; } = new List<PublishDocument>();

    public virtual ICollection<PublishDocument> PublishDocumentDesigners { get; set; } = new List<PublishDocument>();

    public virtual ICollection<PublishDocument> PublishDocumentManagers { get; set; } = new List<PublishDocument>();

    public virtual ICollection<PublishDocument> PublishDocumentUserCreates { get; set; } = new List<PublishDocument>();

    public virtual ICollection<PycProduct> PycProducts { get; set; } = new List<PycProduct>();

    public virtual ICollection<Pyc> PycUserCreates { get; set; } = new List<Pyc>();

    public virtual ICollection<Pyc> PycUserUploads { get; set; } = new List<Pyc>();

    public virtual ICollection<RequestPermissionDocument> RequestPermissionDocumentUserCreates { get; set; } = new List<RequestPermissionDocument>();

    public virtual ICollection<RequestPermissionDocument> RequestPermissionDocumentUserProcesses { get; set; } = new List<RequestPermissionDocument>();

    public virtual ICollection<RequestSendDocument> RequestSendDocumentUserCreates { get; set; } = new List<RequestSendDocument>();

    public virtual ICollection<RequestSendDocument> RequestSendDocumentWorkUsers { get; set; } = new List<RequestSendDocument>();

    public virtual ICollection<RolePermissionD> RolePermissionDs { get; set; } = new List<RolePermissionD>();

    public virtual ICollection<SignatureDocument> SignatureDocuments { get; set; } = new List<SignatureDocument>();

    public virtual ICollection<Singnature> SingnatureUserCreates { get; set; } = new List<Singnature>();

    public virtual ICollection<Singnature> SingnatureUsers { get; set; } = new List<Singnature>();

    public virtual ICollection<Standard> Standards { get; set; } = new List<Standard>();

    public virtual ICollection<Task> TaskAssignedUsers { get; set; } = new List<Task>();

    public virtual ICollection<TaskAttachedFile> TaskAttachedFiles { get; set; } = new List<TaskAttachedFile>();

    public virtual ICollection<Task> TaskOwnerUsers { get; set; } = new List<Task>();

    public virtual ICollection<UserDepartment> UserDepartments { get; set; } = new List<UserDepartment>();

    public virtual ICollection<UserPermission> UserPermissions { get; set; } = new List<UserPermission>();

    public virtual ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    public virtual ICollection<UserSignatureDocument> UserSignatureDocumentAssignedByUsers { get; set; } = new List<UserSignatureDocument>();

    public virtual ICollection<UserSignatureDocument> UserSignatureDocumentUsers { get; set; } = new List<UserSignatureDocument>();

    public virtual ICollection<UserTask> UserTaskAssignedByNavigations { get; set; } = new List<UserTask>();

    public virtual ICollection<UserTask> UserTaskUsers { get; set; } = new List<UserTask>();
}
