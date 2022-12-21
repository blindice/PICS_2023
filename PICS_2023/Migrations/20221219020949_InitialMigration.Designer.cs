﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PICS_2023.Model.Context;

namespace PICS_2023.Migrations
{
    [DbContext(typeof(PICSContext))]
    [Migration("20221219020949_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PICS_2023.Model.TBL_M_USERMASTER", b =>
                {
                    b.Property<string>("APOAccount")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BirthDate")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CostCenterCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateHired")
                        .HasColumnType("datetime");

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DivisionName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmailAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmployeeNo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmploymentStatus")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<short>("EnableFlag")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("((1))");

                    b.Property<short>("FailCount")
                        .HasColumnType("smallint");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Grade")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("JPFlag")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NickName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Position")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SupplierCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.ToTable("TBL_M_USERMASTER");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_User", b =>
                {
                    b.Property<string>("UserID")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("AMGMGFlag")
                        .HasColumnType("bit");

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<bool?>("DMGFlag")
                        .HasColumnType("bit");

                    b.Property<string>("DepartmentName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DivisionName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Fullname")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool?>("SVFlag")
                        .HasColumnType("bit");

                    b.Property<string>("SectionName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<bool?>("StaffFlag")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("UserID");

                    b.ToTable("tbl_Users");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Admin", b =>
                {
                    b.Property<string>("username")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("createBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("username")
                        .HasName("PK__tbl_m_DQ__F3DBC57303317E3D");

                    b.ToTable("tbl_m_DQCS_Admin");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Model", b =>
                {
                    b.Property<int>("modelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UpdateReason")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("assyID")
                        .HasColumnType("int");

                    b.Property<string>("createdBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("createdDate")
                        .HasColumnType("datetime");

                    b.Property<string>("modelcode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("supplierID")
                        .HasColumnType("int");

                    b.Property<int?>("tenID")
                        .HasColumnType("int");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("modelID")
                        .HasName("PK__tbl_m_DQ__0215CDB91FCDBCEB");

                    b.HasIndex("assyID");

                    b.HasIndex("supplierID");

                    b.HasIndex("tenID");

                    b.ToTable("tbl_m_DQCS_Models");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Notification", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("ModelCode")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserId", "ModelCode")
                        .HasName("PK__tbl_m_DQ__529C1001E955D34A");

                    b.ToTable("tbl_m_DQCS_Notification");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_PartNo", b =>
                {
                    b.Property<int>("assyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("assycode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("tenID")
                        .HasColumnType("int");

                    b.Property<string>("updateReason")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("assyID")
                        .HasName("PK__tbl_m_DQ__D043A4700AD2A005");

                    b.HasIndex("tenID");

                    b.ToTable("tbl_m_DQCS_PartNo");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("SupplierCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UpdateReason")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("SupplierID")
                        .HasName("PK__tbl_m_DQ__4BE666940EA330E9");

                    b.ToTable("tbl_m_DQCS_Suppliers");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_SupplierFTP", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime");

                    b.Property<string>("ftpDownload")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ftpPassword")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("ftpPort")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ftpServer")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ftpUpload")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ftpUser")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("ID");

                    b.ToTable("tbl_m_DQCS_SupplierFTP");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_TEN", b =>
                {
                    b.Property<int>("tenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("createdBy")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime");

                    b.Property<string>("old_ten")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("tencode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("updateReason")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("updatedDate")
                        .HasColumnType("datetime");

                    b.HasKey("tenID")
                        .HasName("PK__tbl_m_DQ__FB74B1081273C1CD");

                    b.ToTable("tbl_m_DQCS_TEN");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_t_DQCS_ICT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Actual")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Bias")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("Delay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<string>("Device")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int?>("G1")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("G2")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("G3")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("G4")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int?>("G5")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((0))");

                    b.Property<int>("HPin")
                        .HasColumnType("int");

                    b.Property<int>("LPin")
                        .HasColumnType("int");

                    b.Property<string>("Loc")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("MaxLimit")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("MaxLimitValue")
                        .HasColumnType("int");

                    b.Property<string>("Measure")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("MinLimit")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("MinLimitValue")
                        .HasColumnType("int");

                    b.Property<string>("Mode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("No")
                        .HasColumnType("int");

                    b.Property<string>("Offset")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Refer")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("tbl_t_DQCS_ICT");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_t_DQCS_QPIT", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ControlNo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DetailedSetting")
                        .IsRequired()
                        .HasMaxLength(40)
                        .IsUnicode(false)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("ErrorAddress")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ErrorClass")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ErrorCode")
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ErrorDetails")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("ErrorPinNo")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("FunctionSum")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("JigNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LineName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("OperatorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<decimal>("PasswordVer")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("PcNo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PowerBoxNo")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Process")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<decimal>("ProgVer")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ShiftName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("SystemProgVer")
                        .HasColumnType("int");

                    b.Property<decimal>("TargetProgramVer")
                        .HasColumnType("decimal(6,2)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.ToTable("tbl_t_DQCS_QPIT");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_t_DQCS_supplierUpload", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("action_ipd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("action_repair")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("aoi_hw_bottom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("aoi_hw_bottom_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("aoi_hw_date_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("aoi_hw_date_top")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("aoi_hw_time_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("aoi_hw_time_top")
                        .HasColumnType("datetime2");

                    b.Property<string>("aoi_hw_top")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("aoi_hw_top_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("assy_code")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("be_line")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("cause_ipd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("defect")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("eppi_judge")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("eppi_remarks")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("fvi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("fvi_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("fvi_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("fvi_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("hold_date")
                        .HasColumnType("datetime");

                    b.Property<string>("hold_judge")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ict")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ict_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ict_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("ict_time")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("judge_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("judgement")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("lot_no_serial_on_board")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("no")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("oba")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("oba_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("oqc_date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("oqc_time")
                        .HasColumnType("datetime2");

                    b.Property<string>("part_name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("qpit")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("qpit_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("qpit_reprocess")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("qpit_time")
                        .HasColumnType("datetime2");

                    b.Property<int?>("qty")
                        .HasColumnType("int");

                    b.Property<string>("remarks")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("shipment_lot_no_15_char")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("smt_aoi_bottom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("smt_aoi_date_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_aoi_date_top")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_aoi_time_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_aoi_time_top")
                        .HasColumnType("datetime2");

                    b.Property<string>("smt_aoi_top")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("smt_line_bottom_b_side")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("smt_line_top_a_side")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("smt_vi_bottom")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("smt_vi_date_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_vi_date_top")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_vi_time_bottom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("smt_vi_time_top")
                        .HasColumnType("datetime2");

                    b.Property<string>("smt_vi_top")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("supplier")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("system_judge")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ten_no")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("upload_date")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex(new[] { "supplier", "part_name", "upload_date" }, "NIX_SupplierPartNameUploadDate_incEPPIJudge");

                    b.HasIndex(new[] { "upload_date" }, "NIX_uploadDate");

                    b.ToTable("tbl_t_DQCS_supplierUpload");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Model", b =>
                {
                    b.HasOne("PICS_2023.Model.tbl_m_DQCS_PartNo", "assy")
                        .WithMany("tbl_m_DQCS_Models")
                        .HasForeignKey("assyID")
                        .HasConstraintName("FK__tbl_m_DQC__assyI__21B6055D");

                    b.HasOne("PICS_2023.Model.tbl_m_DQCS_Supplier", "supplier")
                        .WithMany("tbl_m_DQCS_Models")
                        .HasForeignKey("supplierID")
                        .HasConstraintName("FK__tbl_m_DQC__suppl__22AA2996")
                        .IsRequired();

                    b.HasOne("PICS_2023.Model.tbl_m_DQCS_TEN", "ten")
                        .WithMany("tbl_m_DQCS_Models")
                        .HasForeignKey("tenID")
                        .HasConstraintName("FK__tbl_m_DQC__tenID__239E4DCF");

                    b.Navigation("assy");

                    b.Navigation("supplier");

                    b.Navigation("ten");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_PartNo", b =>
                {
                    b.HasOne("PICS_2023.Model.tbl_m_DQCS_TEN", "ten")
                        .WithMany("tbl_m_DQCS_PartNos")
                        .HasForeignKey("tenID")
                        .HasConstraintName("FK__tbl_m_DQC__tenID__656C112C");

                    b.Navigation("ten");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_SupplierFTP", b =>
                {
                    b.HasOne("PICS_2023.Model.tbl_m_DQCS_Supplier", "IDNavigation")
                        .WithOne("tbl_m_DQCS_SupplierFTP")
                        .HasForeignKey("PICS_2023.Model.tbl_m_DQCS_SupplierFTP", "ID")
                        .HasConstraintName("FK__tbl_m_DQCS_S__ID__6383C8BA")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IDNavigation");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_PartNo", b =>
                {
                    b.Navigation("tbl_m_DQCS_Models");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_Supplier", b =>
                {
                    b.Navigation("tbl_m_DQCS_Models");

                    b.Navigation("tbl_m_DQCS_SupplierFTP");
                });

            modelBuilder.Entity("PICS_2023.Model.tbl_m_DQCS_TEN", b =>
                {
                    b.Navigation("tbl_m_DQCS_Models");

                    b.Navigation("tbl_m_DQCS_PartNos");
                });
#pragma warning restore 612, 618
        }
    }
}
