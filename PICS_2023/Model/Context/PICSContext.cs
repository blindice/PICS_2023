using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PICS_2023.Model;

#nullable disable

namespace PICS_2023.Model.Context
{
    public partial class PICSContext : DbContext
    {
        public PICSContext()
        {
        }

        public PICSContext(DbContextOptions<PICSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TBL_M_USERMASTER> TBL_M_USERMASTERs { get; set; }
        public virtual DbSet<tbl_User> tbl_Users { get; set; }
        public virtual DbSet<tbl_m_DQCS_Admin> tbl_m_DQCS_Admins { get; set; }
        public virtual DbSet<tbl_m_DQCS_Model> tbl_m_DQCS_Models { get; set; }
        public virtual DbSet<tbl_m_DQCS_Notification> tbl_m_DQCS_Notifications { get; set; }
        public virtual DbSet<tbl_m_DQCS_PartNo> tbl_m_DQCS_PartNos { get; set; }
        public virtual DbSet<tbl_m_DQCS_Supplier> tbl_m_DQCS_Suppliers { get; set; }
        public virtual DbSet<tbl_m_DQCS_SupplierFTP> tbl_m_DQCS_SupplierFTPs { get; set; }
        public virtual DbSet<tbl_m_DQCS_TEN> tbl_m_DQCS_TENs { get; set; }
        public virtual DbSet<tbl_m_user> tbl_m_users { get; set; }
        public virtual DbSet<tbl_t_DQCS_ICT> tbl_t_DQCS_ICTs { get; set; }
        public virtual DbSet<tbl_t_DQCS_QPIT> tbl_t_DQCS_QPITs { get; set; }
        public virtual DbSet<tbl_t_DQCS_supplierUpload> tbl_t_DQCS_supplierUploads { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("name=DefaultConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TBL_M_USERMASTER>(entity =>
            {
                entity.Property(e => e.EmployeeNo).IsUnicode(false);

                entity.Property(e => e.EnableFlag).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<tbl_User>(entity =>
            {
                entity.Property(e => e.UserID).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentName).IsUnicode(false);

                entity.Property(e => e.DivisionName).IsUnicode(false);

                entity.Property(e => e.EmailAddress).IsUnicode(false);

                entity.Property(e => e.Fullname).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.SectionName).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_m_DQCS_Admin>(entity =>
            {
                entity.HasKey(e => e.username)
                    .HasName("PK__tbl_m_DQ__F3DBC57303317E3D");
            });

            modelBuilder.Entity<tbl_m_DQCS_Model>(entity =>
            {
                entity.HasKey(e => e.modelID)
                    .HasName("PK__tbl_m_DQ__0215CDB91FCDBCEB");

                entity.HasOne(d => d.assy)
                    .WithMany(p => p.tbl_m_DQCS_Models)
                    .HasForeignKey(d => d.assyID)
                    .HasConstraintName("FK__tbl_m_DQC__assyI__21B6055D");

                entity.HasOne(d => d.supplier)
                    .WithMany(p => p.tbl_m_DQCS_Models)
                    .HasForeignKey(d => d.supplierID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tbl_m_DQC__suppl__22AA2996");

                entity.HasOne(d => d.ten)
                    .WithMany(p => p.tbl_m_DQCS_Models)
                    .HasForeignKey(d => d.tenID)
                    .HasConstraintName("FK__tbl_m_DQC__tenID__239E4DCF");
            });

            modelBuilder.Entity<tbl_m_DQCS_Notification>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ModelCode })
                    .HasName("PK__tbl_m_DQ__529C1001E955D34A");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.ModelCode).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_m_DQCS_PartNo>(entity =>
            {
                entity.HasKey(e => e.assyID)
                    .HasName("PK__tbl_m_DQ__D043A4700AD2A005");

                entity.HasOne(d => d.ten)
                    .WithMany(p => p.tbl_m_DQCS_PartNos)
                    .HasForeignKey(d => d.tenID)
                    .HasConstraintName("FK__tbl_m_DQC__tenID__656C112C");
            });

            modelBuilder.Entity<tbl_m_DQCS_Supplier>(entity =>
            {
                entity.HasKey(e => e.SupplierID)
                    .HasName("PK__tbl_m_DQ__4BE666940EA330E9");

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.SupplierCode).IsUnicode(false);

                entity.Property(e => e.SupplierName).IsUnicode(false);

                entity.Property(e => e.UpdateReason).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_m_DQCS_SupplierFTP>(entity =>
            {
                entity.Property(e => e.ID).ValueGeneratedNever();

                entity.HasOne(d => d.IDNavigation)
                    .WithOne(p => p.tbl_m_DQCS_SupplierFTP)
                    .HasForeignKey<tbl_m_DQCS_SupplierFTP>(d => d.ID)
                    .HasConstraintName("FK__tbl_m_DQCS_S__ID__6383C8BA");
            });

            modelBuilder.Entity<tbl_m_DQCS_TEN>(entity =>
            {
                entity.HasKey(e => e.tenID)
                    .HasName("PK__tbl_m_DQ__FB74B1081273C1CD");
            });

            modelBuilder.Entity<tbl_m_user>(entity =>
            {
                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedBy).IsUnicode(false);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_t_DQCS_ICT>(entity =>
            {
                entity.Property(e => e.Delay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Device).IsUnicode(false);

                entity.Property(e => e.G1).HasDefaultValueSql("((0))");

                entity.Property(e => e.G2).HasDefaultValueSql("((0))");

                entity.Property(e => e.G3).HasDefaultValueSql("((0))");

                entity.Property(e => e.G4).HasDefaultValueSql("((0))");

                entity.Property(e => e.G5).HasDefaultValueSql("((0))");

                entity.Property(e => e.Loc).IsUnicode(false);

                entity.Property(e => e.Mode).IsUnicode(false);
            });

            modelBuilder.Entity<tbl_t_DQCS_QPIT>(entity =>
            {
                entity.Property(e => e.ControlNo).IsUnicode(false);

                entity.Property(e => e.DetailedSetting).IsUnicode(false);

                entity.Property(e => e.ErrorAddress).IsUnicode(false);

                entity.Property(e => e.ErrorClass).IsUnicode(false);

                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.ErrorDetails).IsUnicode(false);

                entity.Property(e => e.ErrorPinNo).IsUnicode(false);

                entity.Property(e => e.FunctionSum).IsUnicode(false);

                entity.Property(e => e.JigNo).IsUnicode(false);

                entity.Property(e => e.LineName).IsUnicode(false);

                entity.Property(e => e.OperatorName).IsUnicode(false);

                entity.Property(e => e.PcNo).IsUnicode(false);

                entity.Property(e => e.PowerBoxNo).IsUnicode(false);

                entity.Property(e => e.Process).IsUnicode(false);

                entity.Property(e => e.Result).IsUnicode(false);

                entity.Property(e => e.ShiftName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
