using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PICS_2023.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_Admin",
                columns: table => new
                {
                    username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__F3DBC57303317E3D", x => x.username);
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_Notification",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    ModelCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__529C1001E955D34A", x => new { x.UserId, x.ModelCode });
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_Suppliers",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierCode = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    SupplierName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateReason = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__4BE666940EA330E9", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_TEN",
                columns: table => new
                {
                    tenID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tencode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    old_ten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    updateReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__FB74B1081273C1CD", x => x.tenID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_M_USERMASTER",
                columns: table => new
                {
                    EmployeeNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    APOAccount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SectionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DepartmentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DivisionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CostCenterCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmploymentStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateHired = table.Column<DateTime>(type: "datetime", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: true),
                    JPFlag = table.Column<int>(type: "int", nullable: true),
                    SupplierCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    FailCount = table.Column<short>(type: "smallint", nullable: false),
                    EnableFlag = table.Column<short>(type: "smallint", nullable: false, defaultValueSql: "((1))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tbl_t_DQCS_ICT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    No = table.Column<int>(type: "int", nullable: false),
                    Mode = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Device = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Actual = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Refer = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Measure = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MinLimit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MinLimitValue = table.Column<int>(type: "int", nullable: true),
                    MaxLimit = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    MaxLimitValue = table.Column<int>(type: "int", nullable: true),
                    Offset = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Delay = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Bias = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    HPin = table.Column<int>(type: "int", nullable: false),
                    LPin = table.Column<int>(type: "int", nullable: false),
                    G1 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    G2 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    G3 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    G4 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    G5 = table.Column<int>(type: "int", nullable: true, defaultValueSql: "((0))"),
                    Loc = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_t_DQCS_ICT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_t_DQCS_QPIT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    Process = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ControlNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Result = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    ErrorCode = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ErrorClass = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ErrorDetails = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ErrorAddress = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ErrorPinNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    LineName = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    ShiftName = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    PcNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    JigNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PowerBoxNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    SystemProgVer = table.Column<int>(type: "int", nullable: false),
                    TargetProgramVer = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    ProgVer = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DetailedSetting = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    FunctionSum = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    OperatorName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PasswordVer = table.Column<decimal>(type: "decimal(6,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_t_DQCS_QPIT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_t_DQCS_supplierUpload",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    no = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    supplier = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ten_no = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    part_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    assy_code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    shipment_lot_no_15_char = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lot_no_serial_on_board = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    qty = table.Column<int>(type: "int", nullable: true),
                    smt_line_bottom_b_side = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    smt_line_top_a_side = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    be_line = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    smt_aoi_date_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_vi_date_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_aoi_date_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_vi_date_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_aoi_time_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_vi_time_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_aoi_time_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_vi_time_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    smt_aoi_bottom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    smt_vi_bottom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    smt_aoi_top = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    smt_vi_top = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ict_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    qpit_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    aoi_hw_date_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    aoi_hw_date_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fvi_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    oqc_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ict_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    qpit_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    aoi_hw_time_top = table.Column<DateTime>(type: "datetime2", nullable: true),
                    aoi_hw_time_bottom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    fvi_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    oqc_time = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ict = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    qpit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    aoi_hw_bottom = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    aoi_hw_top = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fvi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    oba = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    judgement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    judge_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    system_judge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    eppi_judge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    cause_ipd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    action_ipd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    defect = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    location = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    action_repair = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ict_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    qpit_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    aoi_hw_top_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    aoi_hw_bottom_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    fvi_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    oba_reprocess = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    upload_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    eppi_remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    hold_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    hold_judge = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_t_DQCS_supplierUpload", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tbl_Users",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Fullname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SectionName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DepartmentName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DivisionName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    StaffFlag = table.Column<bool>(type: "bit", nullable: true),
                    SVFlag = table.Column<bool>(type: "bit", nullable: true),
                    AMGMGFlag = table.Column<bool>(type: "bit", nullable: true),
                    DMGFlag = table.Column<bool>(type: "bit", nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    CreatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UpdatedBy = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_SupplierFTP",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    ftpServer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ftpPort = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ftpUser = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ftpPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ftpUpload = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ftpDownload = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_m_DQCS_SupplierFTP", x => x.ID);
                    table.ForeignKey(
                        name: "FK__tbl_m_DQCS_S__ID__6383C8BA",
                        column: x => x.ID,
                        principalTable: "tbl_m_DQCS_Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_PartNo",
                columns: table => new
                {
                    assyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assycode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    updatedBy = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    updateReason = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    tenID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__D043A4700AD2A005", x => x.assyID);
                    table.ForeignKey(
                        name: "FK__tbl_m_DQC__tenID__656C112C",
                        column: x => x.tenID,
                        principalTable: "tbl_m_DQCS_TEN",
                        principalColumn: "tenID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tbl_m_DQCS_Models",
                columns: table => new
                {
                    modelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    supplierID = table.Column<int>(type: "int", nullable: false),
                    modelcode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    updatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    updatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateReason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    tenID = table.Column<int>(type: "int", nullable: true),
                    assyID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tbl_m_DQ__0215CDB91FCDBCEB", x => x.modelID);
                    table.ForeignKey(
                        name: "FK__tbl_m_DQC__assyI__21B6055D",
                        column: x => x.assyID,
                        principalTable: "tbl_m_DQCS_PartNo",
                        principalColumn: "assyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__tbl_m_DQC__suppl__22AA2996",
                        column: x => x.supplierID,
                        principalTable: "tbl_m_DQCS_Suppliers",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__tbl_m_DQC__tenID__239E4DCF",
                        column: x => x.tenID,
                        principalTable: "tbl_m_DQCS_TEN",
                        principalColumn: "tenID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_DQCS_Models_assyID",
                table: "tbl_m_DQCS_Models",
                column: "assyID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_DQCS_Models_supplierID",
                table: "tbl_m_DQCS_Models",
                column: "supplierID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_DQCS_Models_tenID",
                table: "tbl_m_DQCS_Models",
                column: "tenID");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_m_DQCS_PartNo_tenID",
                table: "tbl_m_DQCS_PartNo",
                column: "tenID");

            migrationBuilder.CreateIndex(
                name: "NIX_SupplierPartNameUploadDate_incEPPIJudge",
                table: "tbl_t_DQCS_supplierUpload",
                columns: new[] { "supplier", "part_name", "upload_date" });

            migrationBuilder.CreateIndex(
                name: "NIX_uploadDate",
                table: "tbl_t_DQCS_supplierUpload",
                column: "upload_date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_Admin");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_Models");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_Notification");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_SupplierFTP");

            migrationBuilder.DropTable(
                name: "TBL_M_USERMASTER");

            migrationBuilder.DropTable(
                name: "tbl_t_DQCS_ICT");

            migrationBuilder.DropTable(
                name: "tbl_t_DQCS_QPIT");

            migrationBuilder.DropTable(
                name: "tbl_t_DQCS_supplierUpload");

            migrationBuilder.DropTable(
                name: "tbl_Users");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_PartNo");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_Suppliers");

            migrationBuilder.DropTable(
                name: "tbl_m_DQCS_TEN");
        }
    }
}
