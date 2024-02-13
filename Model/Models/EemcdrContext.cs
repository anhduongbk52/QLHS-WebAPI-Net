using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Model.Models;

public partial class EemcdrContext : DbContext
{
    public EemcdrContext()
    {
    }

    public EemcdrContext(DbContextOptions<EemcdrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApprovalDocumentProduct> ApprovalDocumentProducts { get; set; }

    public virtual DbSet<Bainfor> Bainfors { get; set; }

    public virtual DbSet<Bctdesign> Bctdesigns { get; set; }

    public virtual DbSet<BctdesignProduct> BctdesignProducts { get; set; }

    public virtual DbSet<Biinfor> Biinfors { get; set; }

    public virtual DbSet<Configuration> Configurations { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentTask> DepartmentTasks { get; set; }

    public virtual DbSet<DocTittle> DocTittles { get; set; }

    public virtual DbSet<ElectricalSteel> ElectricalSteels { get; set; }

    public virtual DbSet<ElectricalSteelLoss> ElectricalSteelLosses { get; set; }

    public virtual DbSet<File> Files { get; set; }

    public virtual DbSet<FileOfBctDesign> FileOfBctDesigns { get; set; }

    public virtual DbSet<FileOfLsx> FileOfLsxes { get; set; }

    public virtual DbSet<FileOfPyc> FileOfPycs { get; set; }

    public virtual DbSet<GroupDepartment> GroupDepartments { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<LoginManager> LoginManagers { get; set; }

    public virtual DbSet<Lsx> Lsxes { get; set; }

    public virtual DbSet<LsxProduct> LsxProducts { get; set; }

    public virtual DbSet<MainJobTodo> MainJobTodos { get; set; }

    public virtual DbSet<MainJobTodoPyc> MainJobTodoPycs { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Modul> Moduls { get; set; }

    public virtual DbSet<Mofinfor> Mofinfors { get; set; }

    public virtual DbSet<Nortification> Nortifications { get; set; }

    public virtual DbSet<Permission> Permissions { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductTypeNew> ProductTypeNews { get; set; }

    public virtual DbSet<PublicFile> PublicFiles { get; set; }

    public virtual DbSet<PublishDocument> PublishDocuments { get; set; }

    public virtual DbSet<PublishDocumentOfProduct> PublishDocumentOfProducts { get; set; }

    public virtual DbSet<Pyc> Pycs { get; set; }

    public virtual DbSet<PycProduct> PycProducts { get; set; }

    public virtual DbSet<RequestPermissionDocument> RequestPermissionDocuments { get; set; }

    public virtual DbSet<RequestSendDocument> RequestSendDocuments { get; set; }

    public virtual DbSet<RequestSendDocumentToDepartment> RequestSendDocumentToDepartments { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolePermission> RolePermissions { get; set; }

    public virtual DbSet<RolePermissionD> RolePermissionDs { get; set; }

    public virtual DbSet<SignatureDocument> SignatureDocuments { get; set; }

    public virtual DbSet<Singnature> Singnatures { get; set; }

    public virtual DbSet<Standard> Standards { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TaskAttachedFile> TaskAttachedFiles { get; set; }

    public virtual DbSet<TransformerInfo> TransformerInfos { get; set; }

    public virtual DbSet<TransformerManual> TransformerManuals { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserDepartment> UserDepartments { get; set; }

    public virtual DbSet<UserPermission> UserPermissions { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    public virtual DbSet<UserSignatureDocument> UserSignatureDocuments { get; set; }

    public virtual DbSet<UserTask> UserTasks { get; set; }

    public virtual DbSet<UserTaskPrintManager> UserTaskPrintManagers { get; set; }

    public virtual DbSet<VoltageTransformerInfo> VoltageTransformerInfos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApprovalDocumentProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_AprovalProduct");

            entity.ToTable("ApprovalDocumentProduct");

            entity.Property(e => e.ApprovalNumber).HasComment("Phe duyet lan thu ?");
            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DateExpired).HasColumnType("smalldatetime");
            entity.Property(e => e.DecryptKey).HasMaxLength(64);
            entity.Property(e => e.DocumentName).HasComment("Ten cua tai lieu");
            entity.Property(e => e.FileExtension).HasMaxLength(10);
            entity.Property(e => e.FileName).HasComment("Ten file bao gom ca extension");

            entity.HasOne(d => d.Product).WithMany(p => p.ApprovalDocumentProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDocumentProduct_Product");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.ApprovalDocumentProducts)
                .HasForeignKey(d => d.UserCreateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ApprovalDocumentProduct_User");
        });

        modelBuilder.Entity<Bainfor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BAInfo");

            entity.ToTable("BAInfor");

            entity.Property(e => e.ConnectionSymbol).HasMaxLength(50);
            entity.Property(e => e.CoolingMethod).HasMaxLength(50);
            entity.Property(e => e.RatedFrequency).HasMaxLength(50);
            entity.Property(e => e.RatedPower).HasMaxLength(50);
            entity.Property(e => e.RatedVoltage).HasMaxLength(150);
            entity.Property(e => e.Station).HasMaxLength(150);
            entity.Property(e => e.VoltageRatio).HasMaxLength(200);
        });

        modelBuilder.Entity<Bctdesign>(entity =>
        {
            entity.ToTable("BCTDesign");

            entity.Property(e => e.Burden).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CopperWeight).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CoreHeight).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.CoreMaterial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CoreWeight).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DesignCode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DesignName).HasMaxLength(100);
            entity.Property(e => e.Heigh).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.InerCoreDiameter).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.InnerDiameter).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.OuterCoreDiameter).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.OuterDiameter).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.PrecisionClasses)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.RatedVoltage).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.WireDiameter).HasColumnType("numeric(10, 2)");
        });

        modelBuilder.Entity<BctdesignProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCTDesignProduct");

            entity.Property(e => e.BctdesignId).HasColumnName("BCTDesignId");

            entity.HasOne(d => d.Bctdesign).WithMany()
                .HasForeignKey(d => d.BctdesignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BCTDesignProduct_BCTDesign");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BCTDesignProduct_Product");
        });

        modelBuilder.Entity<Biinfor>(entity =>
        {
            entity.ToTable("BIInfor");

            entity.Property(e => e.Ac).HasColumnName("AC");
            entity.Property(e => e.Acuracy1).HasMaxLength(50);
            entity.Property(e => e.Acuracy2).HasMaxLength(50);
            entity.Property(e => e.Acuracy3).HasMaxLength(50);
            entity.Property(e => e.Acuracy4).HasMaxLength(50);
            entity.Property(e => e.Acuracy5).HasMaxLength(50);
            entity.Property(e => e.KiHieu).HasMaxLength(50);
            entity.Property(e => e.Li).HasColumnName("LI");
            entity.Property(e => e.Pdm)
                .HasMaxLength(50)
                .HasColumnName("PDM");
            entity.Property(e => e.Station).HasMaxLength(50);
        });

        modelBuilder.Entity<Configuration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Configuration");

            entity.ToTable("Configuration");

            entity.HasIndex(e => e.ConfigBy, "IX_ConfigBy");

            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.ConfigByNavigation).WithMany(p => p.Configurations)
                .HasForeignKey(d => d.ConfigBy)
                .HasConstraintName("FK_dbo.Configuration_dbo.User_ConfigBy");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Constract_id");

            entity.ToTable("Contract");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContractDescription).HasMaxLength(500);
            entity.Property(e => e.ContractName).HasMaxLength(500);
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.FilePath).HasMaxLength(500);

            entity.HasOne(d => d.Product).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_Product");

            entity.HasOne(d => d.UserUpload).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.UserUploadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contract_User");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);

            entity.HasOne(d => d.GroupDepartment).WithMany(p => p.Departments)
                .HasForeignKey(d => d.GroupDepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Department_GroupDepartment");

            entity.HasOne(d => d.ManagerPositionId1Navigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerPositionId1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Department_Position");
        });

        modelBuilder.Entity<DepartmentTask>(entity =>
        {
            entity.ToTable("DepartmentTask");

            entity.HasOne(d => d.AssignedByUser).WithMany(p => p.DepartmentTasks)
                .HasForeignKey(d => d.AssignedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentTask_User");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentTasks)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentTask_Department");

            entity.HasOne(d => d.Task).WithMany(p => p.DepartmentTasks)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentTask_Task");
        });

        modelBuilder.Entity<DocTittle>(entity =>
        {
            entity.ToTable("DocTittle");
        });

        modelBuilder.Entity<ElectricalSteel>(entity =>
        {
            entity.ToTable("ElectricalSteel");

            entity.Property(e => e.CountryOfOrigin).HasMaxLength(50);
            entity.Property(e => e.Manufacturer).HasMaxLength(100);
            entity.Property(e => e.MaterialCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ElectricalSteelLoss>(entity =>
        {
            entity.ToTable("ElectricalSteelLoss");

            entity.HasOne(d => d.ElectricalSteel).WithMany(p => p.ElectricalSteelLosses)
                .HasForeignKey(d => d.ElectricalSteelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ElectricalSteelLoss_ElectricalSteel");
        });

        modelBuilder.Entity<File>(entity =>
        {
            entity.ToTable("File");

            entity.Property(e => e.CreateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.DecryptKey).HasMaxLength(64);
            entity.Property(e => e.ModifiedTime).HasColumnType("smalldatetime");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.Files)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_File_User");
        });

        modelBuilder.Entity<FileOfBctDesign>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileOfBctDesign");

            entity.Property(e => e.BctdesignId).HasColumnName("BCTDesignId");
            entity.Property(e => e.CreateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.DecryptKey).HasMaxLength(64);
            entity.Property(e => e.FileExtension).HasMaxLength(10);

            entity.HasOne(d => d.Bctdesign).WithMany()
                .HasForeignKey(d => d.BctdesignId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileOfBctDesign_BCTDesign");

            entity.HasOne(d => d.UserCreate).WithMany()
                .HasForeignKey(d => d.UserCreateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileOfBctDesign_User");
        });

        modelBuilder.Entity<FileOfLsx>(entity =>
        {
            entity.ToTable("FileOfLsx");

            entity.HasOne(d => d.Lsx).WithMany(p => p.FileOfLsxes)
                .HasForeignKey(d => d.LsxId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileOfLsx_Lsx");

            entity.HasOne(d => d.PublicFile).WithMany(p => p.FileOfLsxes)
                .HasForeignKey(d => d.PublicFileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileOfLsx_PublicFile");
        });

        modelBuilder.Entity<FileOfPyc>(entity =>
        {
            entity.ToTable("FileOfPyc");

            entity.Property(e => e.CreateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.DecryptKey).HasMaxLength(64);
            entity.Property(e => e.FileExtension).HasMaxLength(10);

            entity.HasOne(d => d.Pyc).WithMany(p => p.FileOfPycs)
                .HasForeignKey(d => d.PycId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FileOfPyc_PYC");
        });

        modelBuilder.Entity<GroupDepartment>(entity =>
        {
            entity.ToTable("GroupDepartment");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Log");

            entity.ToTable("Log");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(45)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("IPAddress");

            entity.HasOne(d => d.User).WithMany(p => p.Logs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Log_dbo.User_UserId");
        });

        modelBuilder.Entity<LoginManager>(entity =>
        {
            entity.ToTable("LoginManager");

            entity.Property(e => e.ApplicationName)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.ApplicationVersion)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.ComputerName).HasMaxLength(50);
            entity.Property(e => e.LoginIp).HasMaxLength(50);
            entity.Property(e => e.LoginTime).HasColumnType("smalldatetime");

            entity.HasOne(d => d.LoginUser).WithMany(p => p.LoginManagers)
                .HasForeignKey(d => d.LoginUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoginManager_User");
        });

        modelBuilder.Entity<Lsx>(entity =>
        {
            entity.ToTable("Lsx");

            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DateIssued).HasColumnType("smalldatetime");
            entity.Property(e => e.DateStart).HasColumnType("smalldatetime");
            entity.Property(e => e.DofficeNumber)
                .HasMaxLength(50)
                .HasColumnName("DOfficeNumber");
            entity.Property(e => e.Khnumber)
                .HasMaxLength(50)
                .HasColumnName("KHNumber");

            entity.HasOne(d => d.FromDepartment).WithMany(p => p.Lsxes)
                .HasForeignKey(d => d.FromDepartmentId)
                .HasConstraintName("FK_Lsx_Department");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.Lsxes)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_Lsx_User");
        });

        modelBuilder.Entity<LsxProduct>(entity =>
        {
            entity.ToTable("LSX_Product");

            entity.Property(e => e.Lsxid).HasColumnName("LSXId");

            entity.HasOne(d => d.Lsx).WithMany(p => p.LsxProducts)
                .HasForeignKey(d => d.Lsxid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LSX_Product_Lsx");

            entity.HasOne(d => d.Product).WithMany(p => p.LsxProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LSX_Product_Product");
        });

        modelBuilder.Entity<MainJobTodo>(entity =>
        {
            entity.ToTable("MainJobTodo");

            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Lsx).WithMany(p => p.MainJobTodos)
                .HasForeignKey(d => d.LsxId)
                .HasConstraintName("FK_MainJobTodo_Lsx");

            entity.HasOne(d => d.ProcessUser).WithMany(p => p.MainJobTodos)
                .HasForeignKey(d => d.ProcessUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MainJobTodo_User");
        });

        modelBuilder.Entity<MainJobTodoPyc>(entity =>
        {
            entity.ToTable("MainJobTodoPYC");

            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.ProcessUser).WithMany(p => p.MainJobTodoPycs)
                .HasForeignKey(d => d.ProcessUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MainJobTodoPYC_User");

            entity.HasOne(d => d.Pyc).WithMany(p => p.MainJobTodoPycs)
                .HasForeignKey(d => d.PycId)
                .HasConstraintName("FK_MainJobTodoPYC_PYC");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Message");

            entity.ToTable("Message");

            entity.HasIndex(e => e.FromUserId, "IX_FromUserId");

            entity.HasIndex(e => e.ToUserId, "IX_ToUserId");

            entity.Property(e => e.Sent).HasColumnType("datetime");

            entity.HasOne(d => d.FromUser).WithMany(p => p.MessageFromUsers)
                .HasForeignKey(d => d.FromUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Message_dbo.User_FromUserId");

            entity.HasOne(d => d.ToUser).WithMany(p => p.MessageToUsers)
                .HasForeignKey(d => d.ToUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.Message_dbo.User_ToUserId");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Modul>(entity =>
        {
            entity.ToTable("Modul");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);
        });

        modelBuilder.Entity<Mofinfor>(entity =>
        {
            entity.ToTable("MOFInfor");

            entity.Property(e => e.Biacuracy1)
                .HasMaxLength(50)
                .HasColumnName("BIAcuracy1");
            entity.Property(e => e.Biacuracy2)
                .HasMaxLength(50)
                .HasColumnName("BIAcuracy2");
            entity.Property(e => e.Biacuracy3)
                .HasMaxLength(50)
                .HasColumnName("BIAcuracy3");
            entity.Property(e => e.Biacuracy4)
                .HasMaxLength(50)
                .HasColumnName("BIAcuracy4");
            entity.Property(e => e.Biburrden1).HasColumnName("BIBurrden1");
            entity.Property(e => e.Biburrden2).HasColumnName("BIBurrden2");
            entity.Property(e => e.Biburrden3).HasColumnName("BIBurrden3");
            entity.Property(e => e.Biburrden4).HasColumnName("BIBurrden4");
            entity.Property(e => e.Buacuracy1)
                .HasMaxLength(50)
                .HasColumnName("BUAcuracy1");
            entity.Property(e => e.Buacuracy2)
                .HasMaxLength(50)
                .HasColumnName("BUAcuracy2");
            entity.Property(e => e.Buacuracy3)
                .HasMaxLength(50)
                .HasColumnName("BUAcuracy3");
            entity.Property(e => e.Buacuracy4)
                .HasMaxLength(50)
                .HasColumnName("BUAcuracy4");
            entity.Property(e => e.Buburrden1).HasColumnName("BUBurrden1");
            entity.Property(e => e.Buburrden2).HasColumnName("BUBurrden2");
            entity.Property(e => e.Buburrden3).HasColumnName("BUBurrden3");
            entity.Property(e => e.Buburrden4).HasColumnName("BUBurrden4");
            entity.Property(e => e.KiHieu).HasMaxLength(50);
            entity.Property(e => e.Pdm)
                .HasMaxLength(50)
                .HasColumnName("PDM");
            entity.Property(e => e.PrimaryVoltage1).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage2).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage3).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage4).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage1).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage2).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage3).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage4).HasMaxLength(50);
            entity.Property(e => e.Station).HasMaxLength(50);
        });

        modelBuilder.Entity<Nortification>(entity =>
        {
            entity.ToTable("Nortification");

            entity.Property(e => e.TimeCreate).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.Nortifications)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Nortification_User");
        });

        modelBuilder.Entity<Permission>(entity =>
        {
            entity.ToTable("Permission");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(250);

            entity.HasOne(d => d.Modul).WithMany(p => p.Permissions)
                .HasForeignKey(d => d.ModulId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Permission_Modul");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.BainforId).HasColumnName("BAInforId");
            entity.Property(e => e.BctinforId).HasColumnName("BCTInforId");
            entity.Property(e => e.BiinforId).HasColumnName("BIInforId");
            entity.Property(e => e.CvtinforId).HasColumnName("CVTInforId");
            entity.Property(e => e.DateCreated).HasColumnType("smalldatetime");
            entity.Property(e => e.MofinforId).HasColumnName("MOFInforId");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProductRange).HasMaxLength(150);

            entity.HasOne(d => d.Bainfor).WithMany(p => p.Products)
                .HasForeignKey(d => d.BainforId)
                .HasConstraintName("FK_Product_BAInfor");

            entity.HasOne(d => d.Biinfor).WithMany(p => p.Products)
                .HasForeignKey(d => d.BiinforId)
                .HasConstraintName("FK_Product_BIInfor");

            entity.HasOne(d => d.Mofinfor).WithMany(p => p.Products)
                .HasForeignKey(d => d.MofinforId)
                .HasConstraintName("FK_Product_MOFInfor");

            entity.HasOne(d => d.ProductTypeNew).WithMany(p => p.Products)
                .HasForeignKey(d => d.ProductTypeNewId)
                .HasConstraintName("FK_Product_ProductTypeNew");

            entity.HasOne(d => d.TransformerInfo).WithMany(p => p.Products)
                .HasForeignKey(d => d.TransformerInfoId)
                .HasConstraintName("FK_Product_TransformerInfo");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.Products)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_Product_User");

            entity.HasOne(d => d.VoltageTransformerInfo).WithMany(p => p.Products)
                .HasForeignKey(d => d.VoltageTransformerInfoId)
                .HasConstraintName("FK_Product_VoltageTransformerInfo");
        });

        modelBuilder.Entity<ProductTypeNew>(entity =>
        {
            entity.ToTable("ProductTypeNew");

            entity.Property(e => e.TypeCode).HasMaxLength(150);
        });

        modelBuilder.Entity<PublicFile>(entity =>
        {
            entity.ToTable("PublicFile");

            entity.Property(e => e.CreateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.DecryptKey).HasMaxLength(64);
            entity.Property(e => e.FileExtension).HasMaxLength(10);
        });

        modelBuilder.Entity<PublishDocument>(entity =>
        {
            entity.ToTable("PublishDocument");

            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DateUpload).HasColumnType("smalldatetime");
            entity.Property(e => e.DateValid).HasColumnType("smalldatetime");
            entity.Property(e => e.DocumentName).HasMaxLength(500);
            entity.Property(e => e.FileNameWithEx).HasMaxLength(500);
            entity.Property(e => e.FtpPath).HasMaxLength(1000);
            entity.Property(e => e.Hash).HasMaxLength(150);
            entity.Property(e => e.LastModify).HasColumnType("smalldatetime");
            entity.Property(e => e.Note).HasMaxLength(500);

            entity.HasOne(d => d.Checker).WithMany(p => p.PublishDocumentCheckers)
                .HasForeignKey(d => d.CheckerId)
                .HasConstraintName("FK_PublishDocument_User1");

            entity.HasOne(d => d.Designer).WithMany(p => p.PublishDocumentDesigners)
                .HasForeignKey(d => d.DesignerId)
                .HasConstraintName("FK_PublishDocument_User");

            entity.HasOne(d => d.Manager).WithMany(p => p.PublishDocumentManagers)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_PublishDocument_User2");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.PublishDocumentUserCreates)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_PublishDocument_User3");
        });

        modelBuilder.Entity<PublishDocumentOfProduct>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PublishDocumentOfDistributionTransformer");

            entity.ToTable("PublishDocumentOfProduct");

            entity.Property(e => e.InvalidFrom).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Product).WithMany(p => p.PublishDocumentOfProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublishDocumentOfProduct_Product");

            entity.HasOne(d => d.PublishDocument).WithMany(p => p.PublishDocumentOfProducts)
                .HasForeignKey(d => d.PublishDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublishDocumentOfProduct_PublishDocument");
        });

        modelBuilder.Entity<Pyc>(entity =>
        {
            entity.ToTable("PYC");

            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DateIssued).HasColumnType("smalldatetime");
            entity.Property(e => e.DateStart).HasColumnType("smalldatetime");
            entity.Property(e => e.DofficeNumber)
                .HasMaxLength(50)
                .HasColumnName("DOfficeNumber");
            entity.Property(e => e.Kdnumber)
                .HasMaxLength(50)
                .HasColumnName("KDNumber");

            entity.HasOne(d => d.FromDepartment).WithMany(p => p.PycFromDepartments)
                .HasForeignKey(d => d.FromDepartmentId)
                .HasConstraintName("FK_PYC_Department");

            entity.HasOne(d => d.ReceiveDepartment).WithMany(p => p.PycReceiveDepartments)
                .HasForeignKey(d => d.ReceiveDepartmentId)
                .HasConstraintName("FK_PYC_Department1");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.PycUserCreates)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_PYC_User");

            entity.HasOne(d => d.UserUpload).WithMany(p => p.PycUserUploads)
                .HasForeignKey(d => d.UserUploadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PYC_User1");
        });

        modelBuilder.Entity<PycProduct>(entity =>
        {
            entity.ToTable("PYC_Product");

            entity.HasOne(d => d.Product).WithMany(p => p.PycProducts)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PYC_Product_Product");

            entity.HasOne(d => d.Pyc).WithMany(p => p.PycProducts)
                .HasForeignKey(d => d.PycId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PYC_Product_PYC");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.PycProducts)
                .HasForeignKey(d => d.UserCreateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PYC_Product_User");
        });

        modelBuilder.Entity<RequestPermissionDocument>(entity =>
        {
            entity.ToTable("RequestPermissionDocument");

            entity.Property(e => e.TimeCreate).HasColumnType("datetime");
            entity.Property(e => e.TimeFinnish).HasColumnType("datetime");

            entity.HasOne(d => d.Task).WithMany(p => p.RequestPermissionDocuments)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestPermissionDocument_Task");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.RequestPermissionDocumentUserCreates)
                .HasForeignKey(d => d.UserCreateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestPermissionDocument_UserCreate");

            entity.HasOne(d => d.UserProcess).WithMany(p => p.RequestPermissionDocumentUserProcesses)
                .HasForeignKey(d => d.UserProcessId)
                .HasConstraintName("FK_RequestPermissionDocument_UserProcess");
        });

        modelBuilder.Entity<RequestSendDocument>(entity =>
        {
            entity.ToTable("RequestSendDocument");

            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocumentName).HasMaxLength(500);
            entity.Property(e => e.DoneDate).HasColumnType("smalldatetime");
            entity.Property(e => e.EndDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ProductCode).HasMaxLength(200);

            entity.HasOne(d => d.DepartmentOwner).WithMany(p => p.RequestSendDocuments)
                .HasForeignKey(d => d.DepartmentOwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestSendDocument_Department");

            entity.HasOne(d => d.PublishDocument).WithMany(p => p.RequestSendDocuments)
                .HasForeignKey(d => d.PublishDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestSendDocument_PublishDocument");

            entity.HasOne(d => d.UserCreate).WithMany(p => p.RequestSendDocumentUserCreates)
                .HasForeignKey(d => d.UserCreateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestSendDocument_User");

            entity.HasOne(d => d.WorkUser).WithMany(p => p.RequestSendDocumentWorkUsers)
                .HasForeignKey(d => d.WorkUserId)
                .HasConstraintName("FK_RequestSendDocument_User1");
        });

        modelBuilder.Entity<RequestSendDocumentToDepartment>(entity =>
        {
            entity.ToTable("RequestSendDocumentToDepartment");

            entity.HasOne(d => d.Department).WithMany(p => p.RequestSendDocumentToDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestSendDocumentToDepartment_Department");

            entity.HasOne(d => d.RequestSendDocument).WithMany(p => p.RequestSendDocumentToDepartments)
                .HasForeignKey(d => d.RequestSendDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RequestSendDocumentToDepartment_RequestSendDocument");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Role");

            entity.ToTable("Role");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Modified).HasColumnType("datetime");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<RolePermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RolePermission");

            entity.ToTable("RolePermission");

            entity.HasIndex(e => e.RoleId, "IX_RoleId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissions)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.RolePermission_dbo.Role_RoleId");
        });

        modelBuilder.Entity<RolePermissionD>(entity =>
        {
            entity.ToTable("RolePermissionD");

            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.CreateByUser).WithMany(p => p.RolePermissionDs)
                .HasForeignKey(d => d.CreateByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissionD_User");

            entity.HasOne(d => d.Permission).WithMany(p => p.RolePermissionDs)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissionD_Permission");

            entity.HasOne(d => d.Role).WithMany(p => p.RolePermissionDs)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RolePermissionD_Role");
        });

        modelBuilder.Entity<SignatureDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RequestSign");

            entity.ToTable("SignatureDocument");

            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocumentName).HasMaxLength(250);
            entity.Property(e => e.FileName).HasMaxLength(200);
            entity.Property(e => e.OriginFilePath).HasMaxLength(250);
            entity.Property(e => e.ProcessorId).HasColumnName("ProcessorID");
            entity.Property(e => e.SignedFilePath).HasMaxLength(250);

            entity.HasOne(d => d.Processor).WithMany(p => p.SignatureDocuments)
                .HasForeignKey(d => d.ProcessorId)
                .HasConstraintName("FK_SignatureDocument_User");
        });

        modelBuilder.Entity<Singnature>(entity =>
        {
            entity.ToTable("Singnature");

            entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Path).HasMaxLength(200);

            entity.HasOne(d => d.UserCreate).WithMany(p => p.SingnatureUserCreates)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_Singnature_User1");

            entity.HasOne(d => d.User).WithMany(p => p.SingnatureUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Singnature_User");
        });

        modelBuilder.Entity<Standard>(entity =>
        {
            entity.ToTable("Standard");

            entity.Property(e => e.CreateBy).HasMaxLength(500);
            entity.Property(e => e.DateCreate).HasColumnType("smalldatetime");
            entity.Property(e => e.Name).HasMaxLength(500);

            entity.HasOne(d => d.UserCreate).WithMany(p => p.Standards)
                .HasForeignKey(d => d.UserCreateId)
                .HasConstraintName("FK_Standard_User");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Task");

            entity.ToTable("Task");

            entity.HasIndex(e => e.AssignedUserId, "IX_AssignedUserId");

            entity.HasIndex(e => e.OwnerUserId, "IX_OwnerUserId");

            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.ReminderDateTime).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Subject).HasMaxLength(300);

            entity.HasOne(d => d.AssignedUser).WithMany(p => p.TaskAssignedUsers)
                .HasForeignKey(d => d.AssignedUserId)
                .HasConstraintName("FK_dbo.Task_dbo.User_AssignedUserId");

            entity.HasOne(d => d.OwnerUser).WithMany(p => p.TaskOwnerUsers)
                .HasForeignKey(d => d.OwnerUserId)
                .HasConstraintName("FK_dbo.Task_dbo.User_OwnerUserId");
        });

        modelBuilder.Entity<TaskAttachedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TaskAttachedFile");

            entity.ToTable("TaskAttachedFile");

            entity.HasIndex(e => e.ModifiedBy, "IX_ModifiedBy");

            entity.HasIndex(e => e.TaskId, "IX_TaskId");

            entity.Property(e => e.KeyFile)
                .HasMaxLength(32)
                .IsFixedLength();
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.ModifiedByNavigation).WithMany(p => p.TaskAttachedFiles)
                .HasForeignKey(d => d.ModifiedBy)
                .HasConstraintName("FK_dbo.TaskAttachedFile_dbo.User_ModifiedBy");

            entity.HasOne(d => d.Task).WithMany(p => p.TaskAttachedFiles)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.TaskAttachedFile_dbo.Task_TaskId");
        });

        modelBuilder.Entity<TransformerInfo>(entity =>
        {
            entity.ToTable("TransformerInfo");

            entity.Property(e => e.ConnectionSymbol).HasMaxLength(50);
            entity.Property(e => e.CoolingMethod).HasMaxLength(50);
            entity.Property(e => e.PowerTransport).HasMaxLength(50);
            entity.Property(e => e.RatedFrequency).HasMaxLength(50);
            entity.Property(e => e.RatedPower).HasMaxLength(50);
            entity.Property(e => e.RatedVoltage).HasMaxLength(150);
            entity.Property(e => e.Station).HasMaxLength(150);
            entity.Property(e => e.UnitPower).HasMaxLength(50);
            entity.Property(e => e.VoltageRatio).HasMaxLength(200);

            entity.HasOne(d => d.Standard).WithMany(p => p.TransformerInfos)
                .HasForeignKey(d => d.StandardId)
                .HasConstraintName("FK_TransformerInfo_Standard");
        });

        modelBuilder.Entity<TransformerManual>(entity =>
        {
            entity.ToTable("TransformerManual");

            entity.HasOne(d => d.DocTitle).WithMany(p => p.TransformerManuals)
                .HasForeignKey(d => d.DocTitleId)
                .HasConstraintName("FK_TransformerManual_DocTittle");

            entity.HasOne(d => d.File).WithMany(p => p.TransformerManuals)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransformerManual_File");

            entity.HasOne(d => d.Product).WithMany(p => p.TransformerManuals)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TransformerManual_Product");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.User");

            entity.ToTable("User");

            entity.Property(e => e.CitizenIdentification).HasMaxLength(12);
            entity.Property(e => e.Department).HasMaxLength(200);
            entity.Property(e => e.EcprKeyForFile)
                .HasMaxLength(1000)
                .HasColumnName("ECPrKeyForFile");
            entity.Property(e => e.EcprKeyForMsg)
                .HasMaxLength(1000)
                .HasColumnName("ECPrKeyForMsg");
            entity.Property(e => e.EcpuKeyForFile)
                .HasMaxLength(200)
                .HasColumnName("ECPuKeyForFile");
            entity.Property(e => e.EcpuKeyForMsg)
                .HasMaxLength(200)
                .HasColumnName("ECPuKeyForMsg");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.HomeTown).HasMaxLength(1000);
            entity.Property(e => e.LastLogin).HasColumnType("datetime");
            entity.Property(e => e.MasterKey).HasMaxLength(1000);
            entity.Property(e => e.MobiphoneNumber)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.OldEcprKeyForFile)
                .HasMaxLength(1000)
                .HasColumnName("OldECPrKeyForFile");
            entity.Property(e => e.OldEcprKeyForMsg)
                .HasMaxLength(1000)
                .HasColumnName("OldECPrKeyForMsg");
            entity.Property(e => e.OldEcpuKeyForFile)
                .HasMaxLength(200)
                .HasColumnName("OldECPuKeyForFile");
            entity.Property(e => e.OldEcpuKeyForMsg)
                .HasMaxLength(200)
                .HasColumnName("OldECPuKeyForMsg");
            entity.Property(e => e.Password).HasMaxLength(96);
            entity.Property(e => e.Title).HasMaxLength(100);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserDepartment>(entity =>
        {
            entity.ToTable("UserDepartment");

            entity.HasOne(d => d.Department).WithMany(p => p.UserDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDepartment_Department");

            entity.HasOne(d => d.Position).WithMany(p => p.UserDepartments)
                .HasForeignKey(d => d.PositionId)
                .HasConstraintName("FK_UserDepartment_Position");

            entity.HasOne(d => d.User).WithMany(p => p.UserDepartments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserDepartment_User");
        });

        modelBuilder.Entity<UserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UserPermission");

            entity.ToTable("UserPermission");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ModifiedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.User).WithMany(p => p.UserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserPermission_dbo.User_UserId");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UserRole");

            entity.ToTable("UserRole");

            entity.HasIndex(e => e.RoleId, "IX_RoleId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.Created).HasColumnType("datetime");
            entity.Property(e => e.Modified).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserRole_dbo.Role_RoleId");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserRole_dbo.User_UserId");
        });

        modelBuilder.Entity<UserSignatureDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserSignDocument");

            entity.ToTable("UserSignatureDocument");

            entity.HasOne(d => d.AssignedByUser).WithMany(p => p.UserSignatureDocumentAssignedByUsers)
                .HasForeignKey(d => d.AssignedByUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSignatureDocument_User1");

            entity.HasOne(d => d.SignatureDocument).WithMany(p => p.UserSignatureDocuments)
                .HasForeignKey(d => d.SignatureDocumentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSignatureDocument_SignatureDocument");

            entity.HasOne(d => d.User).WithMany(p => p.UserSignatureDocumentUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserSignatureDocument_User");
        });

        modelBuilder.Entity<UserTask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.UserTask");

            entity.ToTable("UserTask");

            entity.HasIndex(e => e.AssignedBy, "IX_AssignedBy");

            entity.HasIndex(e => e.TaskId, "IX_TaskId");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.TaskKey).HasMaxLength(64);
            entity.Property(e => e.TimeCreate).HasColumnType("smalldatetime");

            entity.HasOne(d => d.AssignedByNavigation).WithMany(p => p.UserTaskAssignedByNavigations)
                .HasForeignKey(d => d.AssignedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserTask_dbo.User_AssignedBy");

            entity.HasOne(d => d.Task).WithMany(p => p.UserTasks)
                .HasForeignKey(d => d.TaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserTask_dbo.Task_TaskId");

            entity.HasOne(d => d.User).WithMany(p => p.UserTaskUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_dbo.UserTask_dbo.User_UserId");
        });

        modelBuilder.Entity<UserTaskPrintManager>(entity =>
        {
            entity.ToTable("UserTaskPrintManager");

            entity.Property(e => e.PrinterName).HasMaxLength(200);
            entity.Property(e => e.TimeDisposed).HasColumnType("smalldatetime");
            entity.Property(e => e.TimePrint).HasColumnType("smalldatetime");

            entity.HasOne(d => d.UserTask).WithMany(p => p.UserTaskPrintManagers)
                .HasForeignKey(d => d.UserTaskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UserTaskPrintManager_UserTask");
        });

        modelBuilder.Entity<VoltageTransformerInfo>(entity =>
        {
            entity.ToTable("VoltageTransformerInfo");

            entity.Property(e => e.Acuracy1).HasMaxLength(50);
            entity.Property(e => e.Acuracy2).HasMaxLength(50);
            entity.Property(e => e.Acuracy3).HasMaxLength(50);
            entity.Property(e => e.Acuracy4).HasMaxLength(50);
            entity.Property(e => e.KiHieu).HasMaxLength(50);
            entity.Property(e => e.Pdm)
                .HasMaxLength(50)
                .HasColumnName("PDM");
            entity.Property(e => e.PrimaryVoltage1).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage2).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage3).HasMaxLength(50);
            entity.Property(e => e.PrimaryVoltage4).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage1).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage2).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage3).HasMaxLength(50);
            entity.Property(e => e.SercondaryVoltage4).HasMaxLength(50);
            entity.Property(e => e.Station).HasMaxLength(50);
        });
        modelBuilder.Entity<User>().Property(e => e.Status).HasConversion(v=>(int)v,v=>(UserStatus)v);
        modelBuilder.Entity<Log>().Property(e => e.LogType).HasConversion(v => (int)v, v => (LogType)v);

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
