using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class camContext : DbContext
    {
        public camContext()
        {
        }

        public camContext(DbContextOptions<camContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAccessPermission> TAccessPermissions { get; set; }
        public virtual DbSet<TAccessRole> TAccessRoles { get; set; }
        public virtual DbSet<TBillboard> TBillboards { get; set; }
        public virtual DbSet<TBoiler> TBoilers { get; set; }
        public virtual DbSet<TBoilerRepair> TBoilerRepairs { get; set; }
        public virtual DbSet<TCam> TCams { get; set; }
        public virtual DbSet<TCameraAlarm> TCameraAlarms { get; set; }
        public virtual DbSet<TCameraInfo> TCameraInfos { get; set; }
        public virtual DbSet<TCheckwork> TCheckworks { get; set; }
        public virtual DbSet<TCoalTask> TCoalTasks { get; set; }
        public virtual DbSet<TConfirm48> TConfirm48s { get; set; }
        public virtual DbSet<TConfirm710> TConfirm710s { get; set; }
        public virtual DbSet<TContentJson> TContentJsons { get; set; }
        public virtual DbSet<TDaily> TDailies { get; set; }
        public virtual DbSet<TDc> TDcs { get; set; }
        public virtual DbSet<TDcsAlarm> TDcsAlarms { get; set; }
        public virtual DbSet<TDcsAll> TDcsAlls { get; set; }
        public virtual DbSet<TDcsApp> TDcsApps { get; set; }
        public virtual DbSet<TDefect> TDefects { get; set; }
        public virtual DbSet<TDefectInfo> TDefectInfos { get; set; }
        public virtual DbSet<TDefectRepair> TDefectRepairs { get; set; }
        public virtual DbSet<TDevice> TDevices { get; set; }
        public virtual DbSet<TDigitalArchive> TDigitalArchives { get; set; }
        public virtual DbSet<TDigitalArchiveIndex> TDigitalArchiveIndices { get; set; }
        public virtual DbSet<TElectricswitchingoperation> TElectricswitchingoperations { get; set; }
        public virtual DbSet<TEmergencyRepair> TEmergencyRepairs { get; set; }
        public virtual DbSet<TEquipmentDefault> TEquipmentDefaults { get; set; }
        public virtual DbSet<TEquipmentInfo> TEquipmentInfos { get; set; }
        public virtual DbSet<TFault> TFaults { get; set; }
        public virtual DbSet<TFaultiness> TFaultinesses { get; set; }
        public virtual DbSet<TFirstworkorder> TFirstworkorders { get; set; }
        public virtual DbSet<TH1> TH1s { get; set; }
        public virtual DbSet<TH2> TH2s { get; set; }
        public virtual DbSet<THeat> THeats { get; set; }
        public virtual DbSet<THeatEnginE> THeatEnginEs { get; set; }
        public virtual DbSet<THeatEngineB> THeatEngineBs { get; set; }
        public virtual DbSet<THeatPower> THeatPowers { get; set; }
        public virtual DbSet<TInspectionKk> TInspectionKks { get; set; }
        public virtual DbSet<TInspectionPlan> TInspectionPlans { get; set; }
        public virtual DbSet<TInspectionPosition> TInspectionPositions { get; set; }
        public virtual DbSet<TInspectionRecord> TInspectionRecords { get; set; }
        public virtual DbSet<TInspectionStandard> TInspectionStandards { get; set; }
        public virtual DbSet<TInspectionSystem> TInspectionSystems { get; set; }
        public virtual DbSet<TLedgerAuxiliaryInfo> TLedgerAuxiliaryInfos { get; set; }
        public virtual DbSet<TLedgerDailyMaintain> TLedgerDailyMaintains { get; set; }
        public virtual DbSet<TLedgerEquipmentDefault> TLedgerEquipmentDefaults { get; set; }
        public virtual DbSet<TLedgerEquipmentInfo> TLedgerEquipmentInfos { get; set; }
        public virtual DbSet<TLedgerMalfunction> TLedgerMalfunctions { get; set; }
        public virtual DbSet<TLedgerOverhaul> TLedgerOverhauls { get; set; }
        public virtual DbSet<TLedgerPartInfo> TLedgerPartInfos { get; set; }
        public virtual DbSet<TLedgerRenovation> TLedgerRenovations { get; set; }
        public virtual DbSet<TLedgerSpecialCheck> TLedgerSpecialChecks { get; set; }
        public virtual DbSet<TLimitSpace> TLimitSpaces { get; set; }
        public virtual DbSet<TLogDefault> TLogDefaults { get; set; }
        public virtual DbSet<TLogMachinesetLeader> TLogMachinesetLeaders { get; set; }
        public virtual DbSet<TLogShiftSupervisor> TLogShiftSupervisors { get; set; }
        public virtual DbSet<TMonitorProbeGai> TMonitorProbeGais { get; set; }
        public virtual DbSet<TMotor> TMotors { get; set; }
        public virtual DbSet<TNotify> TNotifies { get; set; }
        public virtual DbSet<TOpenDown> TOpenDowns { get; set; }
        public virtual DbSet<TOperShiftRecord> TOperShiftRecords { get; set; }
        public virtual DbSet<TOperationTicketPrecontrol> TOperationTicketPrecontrols { get; set; }
        public virtual DbSet<TOrderRecord> TOrderRecords { get; set; }
        public virtual DbSet<TOverallSetting> TOverallSettings { get; set; }
        public virtual DbSet<TPatrolRecord> TPatrolRecords { get; set; }
        public virtual DbSet<TProductSpec> TProductSpecs { get; set; }
        public virtual DbSet<TRelation> TRelations { get; set; }
        public virtual DbSet<TRiskManage> TRiskManages { get; set; }
        public virtual DbSet<TRiskManageTemp> TRiskManageTemps { get; set; }
        public virtual DbSet<TRiskRepair> TRiskRepairs { get; set; }
        public virtual DbSet<TSafeTechnical> TSafeTechnicals { get; set; }
        public virtual DbSet<TSamplDatum> TSamplData { get; set; }
        public virtual DbSet<TShiftCheck> TShiftChecks { get; set; }
        public virtual DbSet<TShiftMember> TShiftMembers { get; set; }
        public virtual DbSet<TSmallSpecDatum> TSmallSpecData { get; set; }
        public virtual DbSet<TSpotCheck> TSpotChecks { get; set; }
        public virtual DbSet<TSpotCheckKk> TSpotCheckKks { get; set; }
        public virtual DbSet<TSpotCheckPlan> TSpotCheckPlans { get; set; }
        public virtual DbSet<TSpotCheckPosition> TSpotCheckPositions { get; set; }
        public virtual DbSet<TSpotCheckRecord> TSpotCheckRecords { get; set; }
        public virtual DbSet<TSpotCheckStandard> TSpotCheckStandards { get; set; }
        public virtual DbSet<TSpotCheckSystem> TSpotCheckSystems { get; set; }
        public virtual DbSet<TThermomechanicaloperation> TThermomechanicaloperations { get; set; }
        public virtual DbSet<TTicket> TTickets { get; set; }
        public virtual DbSet<TTicketSupervise> TTicketSupervises { get; set; }
        public virtual DbSet<TTicketTemplate> TTicketTemplates { get; set; }
        public virtual DbSet<TTwoworkorder> TTwoworkorders { get; set; }
        public virtual DbSet<TUser> TUsers { get; set; }
        public virtual DbSet<TUserManagementPower> TUserManagementPowers { get; set; }
        public virtual DbSet<TValve> TValves { get; set; }
        public virtual DbSet<TWarnCameraGai> TWarnCameraGais { get; set; }
        public virtual DbSet<TWorkorder> TWorkorders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=49.232.51.71;port=8400;database=cam;user=root;password=root;treattinyasboolean=true", Microsoft.EntityFrameworkCore.ServerVersion.FromString("5.7.31-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAccessPermission>(entity =>
            {
                entity.ToTable("t_access_permission");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.FuncRange)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("func_range")
                    .HasComment("APP/PC/BOTH")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MenuName)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("menu_name")
                    .HasComment("目录")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ModuleName)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("module_name")
                    .HasComment("模块")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitBit)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("permit_bit")
                    .HasComment("比特位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubMenuCode)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("sub_menu_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubMenuName)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("sub_menu_name")
                    .HasComment("子目录")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubModuleCode)
                    .HasColumnType("varchar(120)")
                    .HasColumnName("sub_module_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubModuleName)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sub_module_name")
                    .HasComment("子模块")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TAccessRole>(entity =>
            {
                entity.ToTable("t_access_role");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("code")
                    .HasComment("角色关键字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Role)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("role")
                    .HasComment("角色名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TBillboard>(entity =>
            {
                entity.ToTable("t_billboard");

                entity.HasComment("厂内公告表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("content")
                    .HasComment("公告内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Importance)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("importance")
                    .HasComment("公告重要性级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("issue_date")
                    .HasComment("公告发布日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Issuer)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("issuer")
                    .HasComment("公告发布人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("title")
                    .HasComment("公告标题")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TopFlag)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("top_flag")
                    .HasComment("是否置顶")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TBoiler>(entity =>
            {
                entity.ToTable("t_boiler");

                entity.HasComment("锅炉阀门表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Place)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("place")
                    .HasComment("就地位置")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TBoilerRepair>(entity =>
            {
                entity.ToTable("t_boiler_repair");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.WorkSeq)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_seq")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TCam>(entity =>
            {
                entity.ToTable("t_cam");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ch)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("ch")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ip)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("ip")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Message)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("message")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TCameraAlarm>(entity =>
            {
                entity.ToTable("t_camera_alarm");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
            });

            modelBuilder.Entity<TCameraInfo>(entity =>
            {
                entity.ToTable("t_camera_info");

                entity.HasComment("摄像头信息表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id");

                entity.Property(e => e.Altitude)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("altitude")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CameraIndexCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("camera_index_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CameraName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("camera_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CameraName3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("camera_name3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CameraType)
                    .HasColumnType("int(11)")
                    .HasColumnName("camera_type");

                entity.Property(e => e.CameraTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("camera_type_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CapabilitySet)
                    .HasColumnType("varchar(2550)")
                    .HasColumnName("capability_set")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CapabilitySetName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("capability_set_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChannelNo)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("channel_no")
                    .HasComment("1普通/2红外")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChannelType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("channel_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChannelTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("channel_type_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.EncodeDevIndexCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("encode_dev_index_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EncodeDevResourceType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("encode_dev_resource_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EncodeDevResourceTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("encode_dev_resource_type_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GbIndexCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gb_index_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallLocation)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("install_location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IntelligentSet)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("intelligent_set")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IntelligentSetName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("intelligent_set_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KeyBoardCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("key_board_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Latitude)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("latitude")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Longitude)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("longitude")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("int(1)")
                    .HasColumnName("manufacturer")
                    .HasComment("宇视1/海康0");

                entity.Property(e => e.Pixel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pixel")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("position")
                    .HasComment("位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Ptz)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ptz")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PtzController)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ptz_controller")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PtzControllerName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ptz_controller_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PtzName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ptz_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RecordLocation)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("record_location")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RecordLocationName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("record_location_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Region)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("region")
                    .HasComment("区域")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegionIndexCode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("region_index_code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StatusName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("status_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TransType)
                    .HasColumnType("int(11)")
                    .HasColumnName("trans_type");

                entity.Property(e => e.TransTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("trans_type_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TreatyType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("treaty_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TreatyTypeName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("treaty_type_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新时间");

                entity.Property(e => e.Viewshed)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("viewshed")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TCheckwork>(entity =>
            {
                entity.ToTable("t_checkwork");

                entity.HasComment("人员值班签到表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ClockDateAmEnd)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_date_am_end")
                    .HasComment("上午规定打卡签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ClockDateAmStart)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_date_am_start")
                    .HasComment("上午规定打卡签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ClockDatePmEnd)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_date_pm_end")
                    .HasComment("下午规定打卡签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ClockDatePmStart)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_date_pm_start")
                    .HasComment("下午规定打卡签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("create_by")
                    .HasComment("值班项创建人的user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("create_date")
                    .HasComment("值班项创建时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("date")
                    .HasComment("打卡日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignDateAmEnd)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_date_am_end")
                    .HasComment("员工实际上午签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignDateAmStart)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_date_am_start")
                    .HasComment("员工实际上午签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignDatePmEnd)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_date_pm_end")
                    .HasComment("员工实际下午签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignDatePmStart)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_date_pm_start")
                    .HasComment("员工实际下午签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignFlag)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("sign_flag")
                    .HasComment("签到次数（应签4次）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignPeriod)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("sign_period")
                    .HasComment("值班打卡，3选1（早中晚）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignType)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("sign_type")
                    .HasComment("常规vs值班")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignValid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sign_valid")
                    .HasComment("是否考勤，记录常规打卡中是否请假")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("update_by")
                    .HasComment("值班项修改修改人的user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("update_date")
                    .HasComment("值班项最终修改时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserN)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("user_n")
                    .HasComment("应打卡人，外键：链接user表id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TCoalTask>(entity =>
            {
                entity.ToTable("t_coal_task");

                entity.HasComment("保德煤电作业任务风险预控票");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Chapter)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chapter")
                    .HasComment("目录")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("create_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Edtion)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("edtion")
                    .HasComment("编写人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EdtionN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("edtion_n")
                    .HasComment("编写人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerCheck)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("issuer_check")
                    .HasComment("工作票签发人审核")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerCheckN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("issuer_check_n")
                    .HasComment("工作票签发人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("order_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RiskLevel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("risk_level")
                    .HasComment("风险等级 高/中/低")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonCheck)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_person_check")
                    .HasComment("安监人员审核")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonCheckN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_person_check_n")
                    .HasComment("安检人员工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkStandardId)
                    .HasColumnType("text")
                    .HasColumnName("work_standard_id")
                    .HasComment("安全作业标准")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkTask)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_task")
                    .HasComment("工作任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TConfirm48>(entity =>
            {
                entity.ToTable("t_confirm48");

                entity.HasComment("四点八步确认卡");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Charge1Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge1_sign")
                    .HasComment("工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge2Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge2_sign")
                    .HasComment("工作负责人签名2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge3Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge3_sign")
                    .HasComment("工作负责人签字3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge5Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge5_sign")
                    .HasComment("工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge6Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge6_sign")
                    .HasComment("工作负责人签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge_n")
                    .HasComment("工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm1)
                    .HasColumnType("text")
                    .HasColumnName("confirm1")
                    .HasComment("确认为1，没填为0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirm2")
                    .HasComment("确认为1，没填为0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm3)
                    .HasColumnType("text")
                    .HasColumnName("confirm3")
                    .HasComment("任务分配，进度交底")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirm4")
                    .HasComment("安全技术交底")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm5)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirm5")
                    .HasComment("危险源辨识")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm6)
                    .HasColumnType("text")
                    .HasColumnName("confirm6")
                    .HasComment("现场工器具、施工机具及消防设施检查确认（包括安全带、工器具、脚手架、梯子、灭火器、交叉作业防护网等）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm7)
                    .HasColumnType("text")
                    .HasColumnName("confirm7")
                    .HasComment("作业过程监督检查")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm8)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirm8")
                    .HasComment("收工检查")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Confirm8ChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("confirm8_charge_sign")
                    .HasComment("收工负责人签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("content")
                    .HasComment("工作内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasComment("创建人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("create_date")
                    .HasComment("创建时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExecutionDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("execution_date")
                    .HasComment("执行时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_charge_sign")
                    .HasComment("班组负责人确认签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupChargeSign3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_charge_sign3")
                    .HasComment("班组负责人签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_n")
                    .HasComment("班组负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager1N)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager1_n")
                    .HasComment("厂级管理人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager1Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager1_sign")
                    .HasComment("厂级签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager2N)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager2_n")
                    .HasComment("车间管理人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager2Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager2_sign")
                    .HasComment("车间签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager3N)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager3_n")
                    .HasComment("班组管理人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager3Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager3_sign")
                    .HasComment("班组签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager61Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager61_sign")
                    .HasComment("厂级管理人员签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager62Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager62_sign")
                    .HasComment("车间管理人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manager63Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager63_sign")
                    .HasComment("班组管理人员签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasComment("要推送的下一个人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("order_num")
                    .HasComment("工作票号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RiskLevel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("risk_level")
                    .HasComment("1高2中3低")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasComment("当前状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否合格")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TConfirm710>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("t_confirm710");

                entity.HasComment("运行操作过程“七点十步”管控措施确认卡");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FarGuardianN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("far_guardian_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GuardianN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guardian_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.MainDutyN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("main_duty_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManagerN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("manager_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperaNum)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("opera_num")
                    .HasComment("操作票号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperatorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operator_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S101sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s10_1sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S101signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s10_1sign_num");

                entity.Property(e => e.S102sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s10_2sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S102signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s10_2sign_num");

                entity.Property(e => e.S1Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s1_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S2Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s2_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S3Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s3_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S4Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s4_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S51sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s5_1sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S51signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s5_1sign_num");

                entity.Property(e => e.S52sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s5_2sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S52signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s5_2sign_num");

                entity.Property(e => e.S61sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s6_1sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S61signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s6_1sign_num");

                entity.Property(e => e.S62sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s6_2sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S62signNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("s6_2sign_num");

                entity.Property(e => e.S7Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s7_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S8Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s8_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.S9Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("s9_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StartDate)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("start_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkNum)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("work_num")
                    .HasComment("工作票号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TContentJson>(entity =>
            {
                entity.ToTable("t_content_json");

                entity.HasComment("内容JSON总表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ContentJson)
                    .HasColumnType("text")
                    .HasColumnName("content_json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("update_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");
            });

            modelBuilder.Entity<TDaily>(entity =>
            {
                entity.ToTable("t_daily");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ContentDay)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("content_day")
                    .HasComment("今日工作")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasComment("创建者")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.Enclosure)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("enclosure")
                    .HasComment("附件地址")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Other)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("other")
                    .HasComment("其他事项")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanTomorrow)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("plan_tomorrow")
                    .HasComment("明日计划")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReadIs)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("read_is")
                    .HasDefaultValueSql("'0'")
                    .HasComment("已读1未读0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReportNum)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("report_num")
                    .HasComment("汇报给who")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("update_by")
                    .HasComment("更新人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");

                entity.Property(e => e.UserNum)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("user_num")
                    .HasComment("填写人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDc>(entity =>
            {
                entity.ToTable("t_dcs");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ad")
                    .HasComment("信号地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.An)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("an")
                    .HasComment("别名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ap)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ap")
                    .HasComment("报警级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ar)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ar")
                    .HasComment("归档")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("bp")
                    .HasComment("通道号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("bv")
                    .HasComment("量程下线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c1")
                    .HasComment("报警LL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c2")
                    .HasComment("报警ZL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c3")
                    .HasComment("报警L3限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c4")
                    .HasComment("报警L4限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C5)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c5")
                    .HasComment("报警HL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C6)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c6")
                    .HasComment("报警ZH限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C7)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c7")
                    .HasComment("报警H3限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C8)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c8")
                    .HasComment("报警H4限颜色说")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cd")
                    .HasComment("父设备")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cp")
                    .HasComment("设备号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct")
                    .HasComment("配置时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct4")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Db)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("db")
                    .HasComment("死区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Dt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("dt")
                    .HasComment("死区类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ed)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ed")
                    .HasComment("描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Eu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("eu")
                    .HasComment("量纲")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ex)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ex")
                    .HasComment("计算公式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fb)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fb")
                    .HasComment("偏移量")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fk)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fk")
                    .HasComment("比例系数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fl")
                    .HasComment("标志")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fm")
                    .HasComment("显示格式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fq)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fq")
                    .HasComment("分辨率")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gn)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gn")
                    .HasComment("全局名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.H3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("h3")
                    .HasComment("报警高3限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.H4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("h4")
                    .HasComment("报警高4限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hl")
                    .HasComment("报警高限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hw)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hw")
                    .HasComment("模块地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Iv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("iv")
                    .HasComment("初始值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kr")
                    .HasComment("特征字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kt")
                    .HasComment("计算类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kz)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kz")
                    .HasComment("压缩类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.L3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("l3")
                    .HasComment("报警低3限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.L4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("l4")
                    .HasComment("报警低4限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lc)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lc")
                    .HasComment("报警属性")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ll)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ll")
                    .HasComment("报警低限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("nd")
                    .HasComment("父节点")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Of)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("of")
                    .HasComment("离线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ot)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ot")
                    .HasComment("统计偏移s")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pn)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pn")
                    .HasComment("点名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pt")
                    .HasComment("点的来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rs")
                    .HasComment("复位描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rt")
                    .HasComment("点的类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sg)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sg")
                    .HasComment("安全组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sr")
                    .HasComment("信号类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.St)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("st")
                    .HasComment("设定描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysId)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("sys_id")
                    .HasComment("所属图纸id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tp")
                    .HasComment("统计周期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tt")
                    .HasComment("统计类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tv")
                    .HasComment("量程上线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ud)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ud")
                    .HasComment("uuid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zh)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zh")
                    .HasComment("报警高2限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zl")
                    .HasComment("报警低2限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TDcsAlarm>(entity =>
            {
                entity.ToTable("t_dcs_alarm");

                entity.HasComment("DCS 报警信息表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ac)
                    .HasColumnType("int(32)")
                    .HasColumnName("ac")
                    .HasComment("报警颜色");

                entity.Property(e => e.Al)
                    .HasColumnType("int(8)")
                    .HasColumnName("al")
                    .HasComment("报警优先级");

                entity.Property(e => e.Av)
                    .HasColumnType("blob")
                    .HasColumnName("av")
                    .HasComment("测点数值");

                entity.Property(e => e.Ds)
                    .HasColumnType("int(16)")
                    .HasColumnName("ds")
                    .HasComment("测点状态");

                entity.Property(e => e.Gn)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gn")
                    .HasComment("测点名称，如W3.TEST.AX001")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Rt)
                    .HasColumnType("int(8)")
                    .HasColumnName("rt")
                    .HasComment("测点类型：AX,DX,I2,I4,R8");

                entity.Property(e => e.Ta)
                    .HasColumnType("datetime")
                    .HasColumnName("ta")
                    .HasComment("报警时间");

                entity.Property(e => e.Tf)
                    .HasColumnType("datetime")
                    .HasColumnName("tf")
                    .HasComment("首次报警时间");

                entity.Property(e => e.Tm)
                    .HasColumnType("datetime")
                    .HasColumnName("tm")
                    .HasComment("测点更新时间，从1970-1-1到当前的秒数");
            });

            modelBuilder.Entity<TDcsAll>(entity =>
            {
                entity.ToTable("t_dcs_all");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ad)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ad")
                    .HasComment("信号地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.An)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("an")
                    .HasComment("别名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ap)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ap")
                    .HasComment("报警级别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ar)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ar")
                    .HasComment("归档")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("bp")
                    .HasComment("通道号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Bv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("bv")
                    .HasComment("量程下线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c1")
                    .HasComment("报警LL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c2")
                    .HasComment("报警ZL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c3")
                    .HasComment("报警L3限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c4")
                    .HasComment("报警L4限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C5)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c5")
                    .HasComment("报警HL限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C6)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c6")
                    .HasComment("报警ZH限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C7)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c7")
                    .HasComment("报警H3限颜色")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.C8)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("c8")
                    .HasComment("报警H4限颜色说")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cd")
                    .HasComment("父设备")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Cp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("cp")
                    .HasComment("设备号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct")
                    .HasComment("配置时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct1")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct2")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct3")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ct4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ct4")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Db)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("db")
                    .HasComment("死区")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DcsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("dcs_id")
                    .HasComment("W3库里的id");

                entity.Property(e => e.Dt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("dt")
                    .HasComment("死区类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ed)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ed")
                    .HasComment("描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Eu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("eu")
                    .HasComment("量纲")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ex)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ex")
                    .HasComment("计算公式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fb)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fb")
                    .HasComment("偏移量")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fk)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fk")
                    .HasComment("比例系数")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fl")
                    .HasComment("标志")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fm")
                    .HasComment("显示格式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Fq)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fq")
                    .HasComment("分辨率")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Gn)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("gn")
                    .HasComment("全局名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.H3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("h3")
                    .HasComment("报警高3限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.H4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("h4")
                    .HasComment("报警高4限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hl")
                    .HasComment("报警高限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Hw)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hw")
                    .HasComment("模块地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Iv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("iv")
                    .HasComment("初始值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kr")
                    .HasComment("特征字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kt")
                    .HasComment("计算类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Kz)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("kz")
                    .HasComment("压缩类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.L3)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("l3")
                    .HasComment("报警低3限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.L4)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("l4")
                    .HasComment("报警低4限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Lc)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("lc")
                    .HasComment("报警属性")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ll)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ll")
                    .HasComment("报警低限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Nd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("nd")
                    .HasComment("父节点")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Of)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("of")
                    .HasComment("离线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ot)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ot")
                    .HasComment("统计偏移s")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pn)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pn")
                    .HasComment("点名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PointInfo)
                    .HasColumnType("varchar(2550)")
                    .HasColumnName("point_info")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pt")
                    .HasComment("点的来源")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rs")
                    .HasComment("复位描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Rt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rt")
                    .HasComment("点的类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sg)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sg")
                    .HasComment("安全组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Sr)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sr")
                    .HasComment("信号类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.St)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("st")
                    .HasComment("设定描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysId)
                    .HasColumnType("int(11)")
                    .HasColumnName("sys_id")
                    .HasComment("所属图纸id");

                entity.Property(e => e.Tp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tp")
                    .HasComment("统计周期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tt)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tt")
                    .HasComment("统计类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Tv)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("tv")
                    .HasComment("量程上线")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Ud)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ud")
                    .HasComment("uuid")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zh)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zh")
                    .HasComment("报警高2限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Zl)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("zl")
                    .HasComment("报警低2限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TDcsApp>(entity =>
            {
                entity.ToTable("t_dcs_app");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("description")
                    .HasComment("描述")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiveValue)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("live_value")
                    .HasComment("实时值")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Node)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("node")
                    .HasComment("所属节点")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Point)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("point")
                    .HasComment("测点全局名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("update_time")
                    .HasComment("时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDefect>(entity =>
            {
                entity.ToTable("t_defect");

                entity.HasComment("缺陷单表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AcceptDepartment)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("accept_department")
                    .HasComment("缺陷验收人所在单位/部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("accept_description")
                    .HasComment("验收意见")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptHistory)
                    .HasColumnType("varchar(2550)")
                    .HasColumnName("accept_history")
                    .HasComment("验收历史")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("accept_op")
                    .HasComment("验收选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("accept_time")
                    .HasComment("验收时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("acceptor_n")
                    .HasComment("缺陷验收人：运行部机长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptorSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptor_sign")
                    .HasComment("验收签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChiefEngineerN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("chief_engineer_n")
                    .HasComment("总工程师")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("defect_description")
                    .HasComment("缺陷描述")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("defect_name")
                    .HasComment("缺陷种类")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectNum)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("defect_num")
                    .HasComment("缺陷编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectState)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("defect_state")
                    .HasComment("简略列表状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectStatus)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("defect_status")
                    .HasComment("状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectType)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("defect_type")
                    .HasDefaultValueSql("'99'")
                    .HasComment("缺陷级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscoverTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("discover_time")
                    .HasComment("缺陷发现时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererGroup)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("discoverer_group")
                    .HasComment("缺陷发现人所在班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("discoverer_n")
                    .HasComment("缺陷发现人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererPost)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("discoverer_post")
                    .HasComment("缺陷发现人岗位身份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustGroup)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("entrust_group")
                    .HasComment("消缺负责组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("entrust_list")
                    .HasComment("消缺负责人列表")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("entrust_n")
                    .HasComment("消缺负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("entrust_op")
                    .HasComment("消缺负责人选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("entrust_time")
                    .HasComment("外委单位负责人确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipment_id")
                    .HasComment("设备id");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备/系统/区域名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityDirectorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("facility_director_n")
                    .HasComment("设备部主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityMajorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("facility_major_n")
                    .HasComment("设备部分管主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityMajorOp)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("facility_major_op")
                    .HasComment("设备部分管主任选项：同意遗留1不同意0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FinalRepairN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("final_repair_n")
                    .HasComment("零类缺陷消缺人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableTime)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("liable_time")
                    .HasComment("责任人操作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(2550)")
                    .HasColumnName("media_list")
                    .HasComment("缺陷照片/视频list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("model")
                    .HasComment("机组号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PushNext)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("push_next")
                    .HasComment("推送人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverGroup)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("receiver_group")
                    .HasComment("缺陷接收组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("receiver_list")
                    .HasComment("缺陷可接收人列表")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverN)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("receiver_n")
                    .HasComment("缺陷实际接收人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverOp)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("receiver_op")
                    .HasComment("缺陷接收选项：驳回-1，接收1，上报0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverRemark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("receiver_remark")
                    .HasComment("驳回意见")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiverTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("receiver_time")
                    .HasComment("缺陷接收时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_description")
                    .HasComment("处理情况")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairEndTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("repair_end_time")
                    .HasComment("消缺终结时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("repair_n")
                    .HasComment("消缺专责")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_sign")
                    .HasComment("维护专责签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairStartTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("repair_start_time")
                    .HasComment("开始抢修时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDefectInfo>(entity =>
            {
                entity.ToTable("t_defect_info");

                entity.HasComment("缺陷单表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CeN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("ce_n")
                    .HasComment("总工程师")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("defect_description")
                    .HasComment("缺陷描述")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("defect_name")
                    .HasComment("缺陷种类")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectNum)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("defect_num")
                    .HasComment("缺陷编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectState)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("defect_state")
                    .HasComment("简略列表状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectType)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("defect_type")
                    .HasDefaultValueSql("'99'")
                    .HasComment("缺陷级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscoverTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("discover_time")
                    .HasComment("缺陷发现时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererGroup)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("discoverer_group")
                    .HasComment("缺陷发现人所在班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("discoverer_n")
                    .HasComment("缺陷发现人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DiscovererPost)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("discoverer_post")
                    .HasComment("缺陷发现人岗位身份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("entrust_n")
                    .HasComment("外委单位负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipment_id")
                    .HasComment("设备id");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备/系统/区域名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("facility_n")
                    .HasComment("设备部主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityViceN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("facility_vice_n")
                    .HasComment("设备部副主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FinalAcceptOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("final_accept_op")
                    .HasComment("最后验收选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FinalAcceptTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("final_accept_time")
                    .HasComment("最后验收时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FirefightN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("firefight_n")
                    .HasComment("消防大队")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("generate_n")
                    .HasComment("发电部主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("generate_op")
                    .HasComment("发电部主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("generate_time")
                    .HasComment("发电部主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateViceN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("generate_vice_n")
                    .HasComment("发电部副主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateViceOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("generate_vice_op")
                    .HasComment("发电部副主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GenerateViceTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("generate_vice_time")
                    .HasComment("发电部副主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableDepartment)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("liable_department")
                    .HasComment("责任部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableTime)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("liable_time")
                    .HasComment("责任人操作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(5550)")
                    .HasColumnName("media_list")
                    .HasComment("缺陷照片/视频list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MedicalN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("medical_n")
                    .HasComment("医务室")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("model")
                    .HasComment("机组号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PushNext)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("push_next")
                    .HasComment("推送人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairCount)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("repair_count")
                    .HasComment("消缺次数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("statu")
                    .HasComment("状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("supervise_n")
                    .HasComment("安监部主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("supervise_op")
                    .HasComment("安监部主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("supervise_time")
                    .HasComment("安监部主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseViceN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("supervise_vice_n")
                    .HasComment("安监部副主任")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseViceOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("supervise_vice_op")
                    .HasComment("安监部副主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SuperviseViceTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("supervise_vice_time")
                    .HasComment("安监部副主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDefectRepair>(entity =>
            {
                entity.ToTable("t_defect_repair");

                entity.HasComment("消缺单表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AcceptDepartment)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("accept_department")
                    .HasComment("单位/部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("accept_description")
                    .HasComment("验收意见")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("accept_op")
                    .HasComment("验收选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("accept_time")
                    .HasComment("验收时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("acceptor_n")
                    .HasComment("运行部机长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AcceptorSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptor_sign")
                    .HasComment("验收签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CeOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("ce_op")
                    .HasComment("总工程师选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CeTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("ce_time")
                    .HasComment("总工程师确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DefectId)
                    .HasColumnType("int(11)")
                    .HasColumnName("defect_id")
                    .HasComment("缺陷id");

                entity.Property(e => e.EmergencyRepairNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("emergency_repair_num")
                    .HasComment("应急抢修单号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("entrust_op")
                    .HasComment("外委单位负责人选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EntrustTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("entrust_time")
                    .HasComment("外委单位负责人确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("facility_op")
                    .HasComment("设备部主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("facility_time")
                    .HasComment("设备部主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityViceOp)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("facility_vice_op")
                    .HasComment("设备部副主任选择")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FacilityViceTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("facility_vice_time")
                    .HasComment("设备部副主任确认时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PushNext)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("push_next")
                    .HasComment("推送人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_description")
                    .HasComment("处理情况")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairEndTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("repair_end_time")
                    .HasComment("消缺终结时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("repair_n")
                    .HasComment("维护专责")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairNth)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("repair_nth")
                    .HasComment("第几次消缺")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_sign")
                    .HasComment("维护专责签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairStartTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("repair_start_time")
                    .HasComment("开始抢修时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairType)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("repair_type")
                    .HasComment("工作票/应急抢修单")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftChargeAgreeTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("shift_charge_agree_time")
                    .HasComment("值长确认开始抢修时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftChargeN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("shift_charge_n")
                    .HasComment("值班值长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("statu")
                    .HasComment("状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkOrderNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_order_num")
                    .HasComment("关联工作票票号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDevice>(entity =>
            {
                entity.ToTable("t_device");

                entity.HasComment("安卓设备码对应用户表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.DeviceId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("device_id")
                    .HasComment("安卓设备码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("job_number")
                    .HasComment("用户工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TDigitalArchive>(entity =>
            {
                entity.ToTable("t_digital_archive");

                entity.HasComment("数字档案（汽机/锅炉/电气系统图）表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.Filename)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("filename")
                    .HasComment("图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainSys)
                    .HasColumnType("varchar(6)")
                    .HasColumnName("main_sys")
                    .HasComment("汽机/锅炉/电气")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serial)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("serial")
                    .HasComment("图号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Url)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("url")
                    .HasComment("文件地址")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TDigitalArchiveIndex>(entity =>
            {
                entity.ToTable("t_digital_archive_index");

                entity.HasComment("数字档案表内容索引表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ArchiveId)
                    .HasColumnType("int(5)")
                    .HasColumnName("archive_id")
                    .HasComment("图册id（外键）");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("content")
                    .HasComment("图册内容项目")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MainSys)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("main_sys")
                    .HasComment("主系统名称（汽机/电气/锅炉）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TElectricswitchingoperation>(entity =>
            {
                entity.ToTable("t_electricswitchingoperation");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ErrorStatu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("error_statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("作废状态码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustody)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("importent_custody")
                    .HasComment("重大操作监护人们")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyChiefengineer)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("importent_custody_chiefengineer")
                    .HasComment("重大操作监护总工程师")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyDepartmentdeputydirector)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("importent_custody_departmentdeputydirector")
                    .HasComment("重大操作监护运行部副主任")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyDepartmentdirector)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("importent_custody_departmentdirector")
                    .HasComment("重大操作监护运行部主任")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyProfessionaldirector)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("importent_custody_professionaldirector")
                    .HasComment("重大操作监护运行部专业主管")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsImportentFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_importent_flag")
                    .HasComment("是否属于重大操作 0f 1t");

                entity.Property(e => e.IsMonitoredFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_monitored_flag")
                    .HasComment("是否处于监护人监护下操作 0-false 1-true");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("next")
                    .HasComment("下一步推送人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationEndDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("operation_end_date")
                    .HasComment("操作结束时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationItemsJson)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("Operation_items_json")
                    .HasComment("操作项目")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("operation_start_date")
                    .HasComment("操作开始时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationTask)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("operation_task")
                    .HasComment("操作任务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("order_dutyleader_num")
                    .HasComment("值班负责人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderNumDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("order_dutyleader_num_date")
                    .HasComment("值班负责人签名时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("order_dutyleader_sign")
                    .HasComment("值班负责人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("order_n")
                    .HasComment("发令人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("order_shiftleader_num")
                    .HasComment("值长工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("order_shiftleader_sign")
                    .HasComment("值长签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderSignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("order_shiftleader_sign_date")
                    .HasComment("值长签名时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("order_start_date")
                    .HasComment("发令时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("状态码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuffeN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffe_n")
                    .HasComment("受令人工号(值长）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodyNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffer_custody_num")
                    .HasComment("监护人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodySign)
                    .HasColumnType("varchar(600)")
                    .HasColumnName("suffer_custody_sign")
                    .HasComment("监护人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodySignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("suffer_custody_sign_date")
                    .HasComment("监护人签名时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffer_operater_num")
                    .HasComment("操作人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterSign)
                    .HasColumnType("varchar(600)")
                    .HasColumnName("suffer_operater_sign")
                    .HasComment("操作人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterSignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("suffer_operater_sign_date")
                    .HasComment("操作人签名时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TEmergencyRepair>(entity =>
            {
                entity.ToTable("t_emergency_repair");

                entity.HasComment("事故应急抢修单");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Arranger)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("arranger")
                    .HasComment("抢修任务布置人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge")
                    .HasComment("抢修工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndLicensorSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("end_licensor_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembers)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_members")
                    .HasComment("抢修班人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMen)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_men")
                    .HasComment("人数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("groups")
                    .HasComment("班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("licensor")
                    .HasComment("许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("licensor_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("licensor_n")
                    .HasComment("许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("licensor_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_list")
                    .HasComment("文件存储类型，位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasComment("下一步推送")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("order_id");

                entity.Property(e => e.PermitDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("permit_date")
                    .HasComment("许可抢修时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairCharge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_charge")
                    .HasComment("抢修工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_charge_n")
                    .HasComment("抢修工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RetainSafe)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("retain_safe")
                    .HasComment("保留安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeMeasureJson)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_measure_json")
                    .HasComment("安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("sign_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasComment("状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SupplementSafe)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("supplement_safe")
                    .HasComment("7补充安全")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TaskJson)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("task_json")
                    .HasComment("抢修任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("报废冲红")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkRetainJson)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_retain_json")
                    .HasComment("注意事项")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TEquipmentDefault>(entity =>
            {
                entity.ToTable("t_equipment_default");

                entity.HasComment("设备基础台账模板");

                entity.Property(e => e.Id)
                    .HasColumnType("int(8)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("department")
                    .HasComment("所属部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentLevel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_level")
                    .HasComment("设备级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentModel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_model")
                    .HasComment("设备型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentState)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_state")
                    .HasComment("设备状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentType)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("equipment_type")
                    .HasComment("设备类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人 工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("manufacture_date")
                    .HasComment("出厂日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureSerial)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("manufacture_serial")
                    .HasComment("出厂编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("机组号：1号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperateDate)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("operate_date")
                    .HasComment("投运日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SystemId)
                    .HasColumnType("int(6)")
                    .HasColumnName("system_id")
                    .HasComment("所属系统id");

                entity.Property(e => e.SystemName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("system_name")
                    .HasComment("所属系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechDataList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_data_list")
                    .HasComment("技术资料url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechParamList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_param_list")
                    .HasComment("设备技术参数 list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<TEquipmentInfo>(entity =>
            {
                entity.ToTable("t_equipment_info");

                entity.HasComment("设备基础台账");

                entity.Property(e => e.Id)
                    .HasColumnType("int(8)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("department")
                    .HasComment("所属部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentLevel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_level")
                    .HasComment("设备级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentModel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_model")
                    .HasComment("设备型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentState)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_state")
                    .HasComment("设备状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentType)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("equipment_type")
                    .HasComment("设备类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人 工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("manufacture_date")
                    .HasComment("出厂日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureSerial)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("manufacture_serial")
                    .HasComment("出厂编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("机组号：1号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperateDate)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("operate_date")
                    .HasComment("投运日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SystemId)
                    .HasColumnType("int(6)")
                    .HasColumnName("system_id")
                    .HasComment("所属系统id");

                entity.Property(e => e.SystemName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("system_name")
                    .HasComment("所属系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechDataList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_data_list")
                    .HasComment("技术资料url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechParamList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_param_list")
                    .HasComment("设备技术参数 list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<TFault>(entity =>
            {
                entity.ToTable("t_fault");

                entity.HasComment("故障检修报备信息");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("create_time")
                    .HasComment("创建时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("description")
                    .HasComment("故障描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmergencyLevel)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("emergency_level")
                    .HasComment("紧急程度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EmpiricalCode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("empirical_code")
                    .HasComment("经验代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultLevel)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("fault_level")
                    .HasComment("故障等级")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultType)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("fault_type")
                    .HasComment("故障类别")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_code")
                    .HasComment("故障设备KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OccurTime)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("occur_time")
                    .HasComment("发生时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperatorName)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("operator_name")
                    .HasComment("操作人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperatorPhone)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("operator_phone")
                    .HasComment("操作人电话")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Othera)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("othera")
                    .HasComment("其他a")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otherb)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("otherb")
                    .HasComment("其他b")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otherc)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("otherc")
                    .HasComment("其他c")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Otherd)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("otherd")
                    .HasComment("其他d")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Othere)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("othere")
                    .HasComment("其他e")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutsourcingFlag)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("outsourcing_flag")
                    .HasComment("外委维修")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ProcessStatus)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("process_status")
                    .HasComment("处理状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepairStatus)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("repair_status")
                    .HasComment("报修状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepairTeam)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("repair_team")
                    .HasComment("维修组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Serial)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("serial")
                    .HasComment("故障编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StopFlag)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("stop_flag")
                    .HasComment("是否停机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TFaultiness>(entity =>
            {
                entity.ToTable("t_faultiness");

                entity.Property(e => e.Id)
                    .HasColumnType("int(255)")
                    .HasColumnName("id")
                    .HasComment("id");

                entity.Property(e => e.AcceptanceComment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptance_comment")
                    .HasComment("验收意见")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AcceptanceDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptance_date")
                    .HasComment("验收时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AcceptanceDepartment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptance_department")
                    .HasComment("验收单位/部门")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AcceptorNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptor_num")
                    .HasComment("验收人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.AcceptorSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("acceptor_sign")
                    .HasComment("验收人签字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChiefEngineerIs0)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer_is_0")
                    .HasComment("总工程师是否同意0类缺陷")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChiefEngineerNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer_num")
                    .HasComment("总工程师工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ChiefEngineerStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer_statu")
                    .HasComment("总工程师确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Confirmer)
                    .HasColumnType("varchar(255)")
                    .HasComment("确认分类人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("creation_date")
                    .HasComment("创建日期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DiscovererNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("discoverer_num")
                    .HasComment("发现人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Elimination)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("elimination")
                    .HasComment("缺陷消除情况")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("end_date")
                    .HasComment("消缺终止日期")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentMIs0)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_M_is_0")
                    .HasComment("设备部主任是否同意0类缺陷")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentMNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_M_num")
                    .HasComment("设备部主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentMStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_M_statu")
                    .HasComment("设备部主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentSpecialistNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_specialist_num")
                    .HasComment("设备部专工工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_statu")
                    .HasComment("设备部确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentVmIs0)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_VM_is_0")
                    .HasComment("设备部副主任是否同意0类缺陷")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentVmNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_VM_num")
                    .HasComment("设备部副主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EquipmentVmStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_VM_statu")
                    .HasComment("设备部副主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_description")
                    .HasComment("缺陷描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessMajor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_major")
                    .HasComment("所属专业")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_name")
                    .HasComment("缺陷名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessPosition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_position")
                    .HasComment("所属区域")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessSystem)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_system")
                    .HasComment("所属系统或设备")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FaultinessType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("faultiness_type")
                    .HasComment("缺陷类型")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HeadNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("head_num")
                    .HasComment("消缺负责人(维护专责)工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRepairOvertime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("is_repair_overtime")
                    .HasComment("抢修是否超时")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsRushToRepair)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("is_rush_to_repair")
                    .HasComment("是否抢修")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MachineUnitNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("machine_unit_num")
                    .HasComment("机组号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasComment("推送人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutsourcingNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("outsourcing_num")
                    .HasComment("外委负责人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutsourcingStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("outsourcing_statu")
                    .HasComment("外委负责人确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("position")
                    .HasComment("所属岗位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PowerGenerationMNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("power_generation_M_num")
                    .HasComment("发电部主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PowerGenerationMStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("power_generation_M_statu")
                    .HasComment("发电部主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PowerGenerationStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("power_generation_statu")
                    .HasComment("发电部确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PowerGenerationVmNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("power_generation_VM_num")
                    .HasComment("发电部副主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PowerGenerationVmStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("power_generation_VM_statu")
                    .HasComment("发电部副主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Pushsetting)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("pushsetting")
                    .HasComment("推送确认设置")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepairEndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_end_date")
                    .HasComment("抢修结束时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepairStartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_start_date")
                    .HasComment("抢修开始时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.RepairTime)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_time")
                    .HasComment("抢修计时")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ResponsibleDepartment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("responsible_department")
                    .HasComment("责任部门")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafetyMNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safety_M_num")
                    .HasComment("安监部主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafetyMStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safety_M_statu")
                    .HasComment("安监部主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafetyStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safety_statu")
                    .HasComment("安监部确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafetyVmNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safety_VM_num")
                    .HasComment("安监部副主任工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SafetyVmStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safety_VM_statu")
                    .HasComment("安监部副主任确认状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShiftleaderDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("shiftleader_date")
                    .HasComment("值长审核时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ShiftleaderNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("shiftleader_num")
                    .HasComment("值长工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasComment("状态码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.StatuDescription)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu_description")
                    .HasComment("状态描述")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TeamOfDiscoverer)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("team_of_discoverer")
                    .HasComment("发现人所在班组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Treatment)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("treatment")
                    .HasComment("处理情况")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.WorkTicketNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_ticket_num")
                    .HasComment("对应工作票编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TFirstworkorder>(entity =>
            {
                entity.ToTable("t_firstworkorder");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovalEndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval_end_date")
                    .HasComment("批准结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ApprovalStartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval_start_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge")
                    .HasComment("工作监护人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge11Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge11_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge11Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("charge11_sign")
                    .HasComment("11工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge12Date)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge12_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge12Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge12_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge12Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("charge12_sign")
                    .HasComment("12工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge14Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge14_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge14Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("charge14_sign")
                    .HasComment("14工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge7Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge7_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge7Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("charge7_sign")
                    .HasComment("7工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge8Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge8_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge8Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("charge8_sign")
                    .HasComment("8工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeBefore)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge_before")
                    .HasComment("原工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge_n")
                    .HasDefaultValueSql("''")
                    .HasComment("工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeNow)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("charge_now")
                    .HasComment("现负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ConfirmContent)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("confirm_content")
                    .HasDefaultValueSql("''")
                    .HasComment("确认本工作票上述各项内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ConfirmWorkSafe)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("confirm_work_safe")
                    .HasComment("确认工作负责人布置的工作任务和安全措施：")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DayDateJson)
                    .HasColumnType("text")
                    .HasColumnName("day_date_json")
                    .HasComment("每日开关和收工时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DoubleName)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("double_name")
                    .HasComment("工作的机组、变配电站名称及设备双重名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroundWireGroup)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("ground_wire_group")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroundWireNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("ground_wire_num")
                    .HasComment("接地线编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembers)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("group_members")
                    .HasComment("班(组)成员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMen)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("group_men")
                    .HasComment("人数")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("groups")
                    .HasComment("班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GuardianN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("guardian_n")
                    .HasComment("指定专责监护人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Issuer10Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("issuer10_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Issuer10Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("issuer10_sign")
                    .HasComment("10工作票签发人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Issuer6Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("issuer6_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Issuer6Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("issuer6_sign")
                    .HasComment("6工作票签发人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("issuer_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("issuer_n")
                    .HasComment("工作票签发人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerSignDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("issuer_sign_date")
                    .HasComment("签发日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licens_date")
                    .HasComment("许可日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor10Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor10_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor10Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("licensor10_sign")
                    .HasComment("10工作许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor12Date)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor12_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor12Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor12_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor12Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("licensor12_sign")
                    .HasComment("12工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor14Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor14_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor14Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("licensor14_sign")
                    .HasComment("14工作许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor15Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor15_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor15Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("licensor15_sign")
                    .HasComment("15工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor8Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor8_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Licensor8Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("licensor8_sign")
                    .HasComment("8工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("licensor_n")
                    .HasComment("工作许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperationDuty7Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("operation_duty7_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperationDuty7Sign)
                    .HasColumnType("varchar(225)")
                    .HasColumnName("operation_duty7_sign")
                    .HasComment("7运行值班人员签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperationN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("operation_n")
                    .HasComment("运行值班人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Other)
                    .HasColumnType("text")
                    .HasColumnName("other")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitEndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("permit_end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitStartDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("permit_start_date")
                    .HasComment("许可工作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PersonChange)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("person_change")
                    .HasComment("工作人员变动情况（变动人员姓名、日期及时间）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("plan_end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("plan_start_date")
                    .HasComment("计划工作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiveWorkOrderDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("receive_work_order_date")
                    .HasComment("收到工作票时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RelationId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("relation_id")
                    .HasComment("关联票id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RemarkContent)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("remark_content")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RemarkGuardian)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("remark_guardian")
                    .HasComment("监护人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeMeasureJson)
                    .HasColumnType("text")
                    .HasColumnName("safe_measure_json")
                    .HasComment("安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("shift_charge_n")
                    .HasComment("值长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("shift_charge_sign")
                    .HasComment("值长签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("10:生成,20:工作签发(注意事项),30:收到工作票,31:全部签名,40:确认票内容,41:工作负责人,42:变更签发人签名,43:许可人签名,50:班成员,51:班成员变动签名,60:开收工,61:延期,70:终结,80:恢复安全")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SupplementRetainJson)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("supplement_retain_json")
                    .HasComment("补充工作地点保留带电部分和安全措施（由工作许可人填写）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TrolleyNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("trolley_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkEndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_end_date")
                    .HasComment("工作终结日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkGroup9Num)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_group9_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkGroup9SignArray)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("work_group9_sign_array")
                    .HasComment("9工作班组人员签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkGroupN)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_group_n")
                    .HasComment("工作班组人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkOrderDelayDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_order_delay_date")
                    .HasComment("工作票延期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkOrderEndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_order_end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkRetainJson)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("work_retain_json")
                    .HasComment("工作地点保留带电部分或注意事项（由工作票签发人填写）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkTaskJson)
                    .HasColumnType("text")
                    .HasColumnName("work_task_json")
                    .HasComment("工作任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TH1>(entity =>
            {
                entity.ToTable("t_h1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ApprovalEndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval_end_date")
                    .HasComment("批准动火结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ApprovalStartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval_start_date")
                    .HasComment("批准动火开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckConfirm)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("check_confirm")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckJson)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("check_json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("check_n")
                    .HasComment("测定人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChiefEngineer11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer11_sign")
                    .HasComment("总工程师")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChiefEngineerN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer_n")
                    .HasComment("总工程师")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChiefEngineerSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chief_engineer_sign")
                    .HasComment("总工程师签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("create_by")
                    .HasComment("创建者")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("date")
                    .HasColumnName("create_date");

                entity.Property(e => e.FireGuardian11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fire_guardian11_sign")
                    .HasComment("消防监护人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FireGuardian12Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fire_guardian12_sign")
                    .HasComment("消防监护人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FireGuardianN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fire_guardian_n")
                    .HasComment("消防监护人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FireManagerChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fire_manager_charge_n")
                    .HasComment("消防管理负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FireManagerChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("fire_manager_charge_sign")
                    .HasComment("消防管理负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("groups")
                    .HasComment("班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkAddress)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_address")
                    .HasComment("动火地点及设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkCharge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_charge")
                    .HasComment("动火负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkCharge11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_charge11_sign")
                    .HasComment("动火工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkCharge12Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_charge12_sign")
                    .HasComment("动火工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_charge_n")
                    .HasComment("动火工作负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkContent)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_content")
                    .HasComment("动火工作内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkEnd12Date)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_end12_date")
                    .HasComment("动火工作终结时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkEndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_end_date")
                    .HasComment("申请动火结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkExecutor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_executor")
                    .HasComment("动火执行人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkExecutor11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_executor11_sign")
                    .HasComment("动火执行人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkExecutor12Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_executor12_sign")
                    .HasComment("动火执行人签字")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkExecutorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_executor_n")
                    .HasComment("动火执行人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkIssuerN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_issuer_n")
                    .HasComment("动火工作票签发人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkIssuerSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_issuer_sign")
                    .HasComment("动火工作票签发人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkMode)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_mode")
                    .HasComment("动火方式（可填写焊接、切割、打磨、电钻、使用喷灯等）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkPicture)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_picture")
                    .HasComment("动火附图说明")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkStartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_start_date")
                    .HasComment("申请动火开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkUnitCharge11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_unit_charge11_sign")
                    .HasComment("动火部门（或单位）负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HotWorkUnitChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("hot_work_unit_charge_n")
                    .HasComment(" 动火部门（或单位）负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerSignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("issuer_sign_date")
                    .HasComment("签发日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasComment("下一个签名人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Orther)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("orther")
                    .HasComment("其他")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Permit11Date)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("permit11_date")
                    .HasComment("许可动火时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("permit_date")
                    .HasComment("许可时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairSafeMeasure)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_safe_measure")
                    .HasComment("检修应采取的安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RunLicensor10Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("run_licensor10_sign")
                    .HasComment("运行许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RunLicensor12Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("run_licensor12_sign")
                    .HasComment("工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RunLicensorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("run_licensor_n")
                    .HasComment("运行许可人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RunSafeMeasure)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("run_safe_measure")
                    .HasComment("运行应采取的安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonCheck11Sign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_person_check11_sign")
                    .HasComment("安检部门负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonCheckN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_person_check_n")
                    .HasComment("安检部门负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonCheckSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_person_check_sign")
                    .HasComment("安检部门负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasComment("票流程状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TicketType)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("ticket_type")
                    .HasComment("票类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("是否合格")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TH2>(entity =>
            {
                entity.ToTable("t_h2");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");
            });

            modelBuilder.Entity<THeat>(entity =>
            {
                entity.ToTable("t_heat");

                entity.HasComment("热机阀门表～改");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(6)")
                    .HasColumnName("group_id")
                    .HasComment("未拆之前的id，现作为kks组id");

                entity.Property(e => e.InletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("inlet_pipe_spec")
                    .HasComment("连接管道规格 阀门入口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InterfaceForm)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("interface_form")
                    .HasComment("接口形式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("manufacturer")
                    .HasComment("生产厂家/备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NominalDiameter)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("nominal_diameter")
                    .HasComment("公称直径(DN/NPS)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OfUnit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("of_unit")
                    .HasComment("所属机位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("outlet_pipe_spec")
                    .HasComment("连接管道规格 阀门出口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressure)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_pressure")
                    .HasComment("管道设计参数 压力值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressureUnit)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("pipe_pressure_unit")
                    .HasComment("管道设计参数 压力单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipeTemp)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_temp")
                    .HasComment("管道设计参数 温度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PressureRating)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("pressure_rating")
                    .HasComment("压力等级(PN/ANSI)(MPa)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerial)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial")
                    .HasComment("安装图卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerialShort)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial_short")
                    .HasComment("卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("int(4)")
                    .HasColumnName("total_amount")
                    .HasComment("数量（件） 总计");

                entity.Property(e => e.Unit1Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_1_amount")
                    .HasComment("数量（件） 1号机");

                entity.Property(e => e.Unit2Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_2_amount")
                    .HasComment("数量（件） 2号机");

                entity.Property(e => e.ValveModel)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("valve_model")
                    .HasComment("型号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<THeatEnginE>(entity =>
            {
                entity.ToTable("t_heat_engin_e");

                entity.HasComment("热机阀门表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.InletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("inlet_pipe_spec")
                    .HasComment("连接管道规格 阀门入口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InterfaceForm)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("interface_form")
                    .HasComment("接口形式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码 完整，数组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksSysCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_sys_code")
                    .HasComment("KKS编码 系统代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksValveCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_valve_code")
                    .HasComment("KKS编码 阀门代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("manufacturer")
                    .HasComment("生产厂家/备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NominalDiameter)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("nominal_diameter")
                    .HasComment("公称直径(DN/NPS)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("outlet_pipe_spec")
                    .HasComment("连接管道规格 阀门出口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressure)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_pressure")
                    .HasComment("管道设计参数 压力值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressureUnit)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("pipe_pressure_unit")
                    .HasComment("管道设计参数 压力单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipeTemp)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_temp")
                    .HasComment("管道设计参数 温度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PressureRating)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("pressure_rating")
                    .HasComment("压力等级(PN/ANSI)(MPa)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerial)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial")
                    .HasComment("安装图卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerialShort)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial_short")
                    .HasComment("卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("int(4)")
                    .HasColumnName("total_amount")
                    .HasComment("数量（件） 总计");

                entity.Property(e => e.Unit1Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_1_amount")
                    .HasComment("数量（件） 1号机");

                entity.Property(e => e.Unit2Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_2_amount")
                    .HasComment("数量（件） 2号机");

                entity.Property(e => e.ValveModel)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("valve_model")
                    .HasComment("型号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<THeatEngineB>(entity =>
            {
                entity.ToTable("t_heat_engine_b");

                entity.HasComment("热机阀门表～改");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(6)")
                    .HasColumnName("group_id")
                    .HasComment("未拆之前的id，现作为kks组id");

                entity.Property(e => e.InletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("inlet_pipe_spec")
                    .HasComment("连接管道规格 阀门入口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InterfaceForm)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("interface_form")
                    .HasComment("接口形式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCodeGroup)
                    .HasColumnType("varchar(400)")
                    .HasColumnName("kks_code_group")
                    .HasComment("KKS编码 完整，数组")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksSysCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_sys_code")
                    .HasComment("KKS编码 系统代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksValveCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_valve_code")
                    .HasComment("KKS编码 阀门代码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("manufacturer")
                    .HasComment("生产厂家/备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NominalDiameter)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("nominal_diameter")
                    .HasComment("公称直径(DN/NPS)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("outlet_pipe_spec")
                    .HasComment("连接管道规格 阀门出口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressure)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_pressure")
                    .HasComment("管道设计参数 压力值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressureUnit)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("pipe_pressure_unit")
                    .HasComment("管道设计参数 压力单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipeTemp)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_temp")
                    .HasComment("管道设计参数 温度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PressureRating)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("pressure_rating")
                    .HasComment("压力等级(PN/ANSI)(MPa)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerial)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial")
                    .HasComment("安装图卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerialShort)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial_short")
                    .HasComment("卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("int(4)")
                    .HasColumnName("total_amount")
                    .HasComment("数量（件） 总计");

                entity.Property(e => e.Unit1Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_1_amount")
                    .HasComment("数量（件） 1号机");

                entity.Property(e => e.Unit2Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_2_amount")
                    .HasComment("数量（件） 2号机");

                entity.Property(e => e.ValveModel)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("valve_model")
                    .HasComment("型号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<THeatPower>(entity =>
            {
                entity.ToTable("t_heat_power");

                entity.HasComment("停送电");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Charge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DutyMonitor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("duty_monitor")
                    .HasComment("值长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Executor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("executor")
                    .HasComment("措施执行人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExecutorN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("executor_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.HeatChargeDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("heat_charge_date")
                    .HasComment("热机负责人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("order_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReceiveN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("receive_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Receiver)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("receiver")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("start_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StopGive)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("stop_give")
                    .HasComment("停或送(1/0)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TInspectionKk>(entity =>
            {
                entity.ToTable("t_inspection_kks");

                entity.HasComment("设备kks码关联巡检区域表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Equipment)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("equipment")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Kks)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("kks")
                    .HasComment("设备KKS码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(5)")
                    .HasColumnName("position_id")
                    .HasComment("巡检区域id");
            });

            modelBuilder.Entity<TInspectionPlan>(entity =>
            {
                entity.ToTable("t_inspection_plan");

                entity.HasComment("巡检计划表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(7)")
                    .HasColumnName("id")
                    .HasComment("计划编号");

                entity.Property(e => e.Frequency)
                    .HasColumnType("int(4)")
                    .HasColumnName("frequency")
                    .HasComment("巡检频次");

                entity.Property(e => e.InspectionCycle)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("inspection_cycle")
                    .HasComment("巡检周期 每天/每周")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectorList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("inspector_list")
                    .HasComment("巡检人员工号list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StandardId)
                    .HasColumnType("int(7)")
                    .HasColumnName("standard_id")
                    .HasComment("标准编号");

                entity.Property(e => e.StartTime)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("start_time")
                    .HasComment("开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TimeList)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("time_list")
                    .HasComment("时刻list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ValidFlag)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("valid_flag")
                    .HasDefaultValueSql("'1'")
                    .HasComment("计划生效 1是/0否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TInspectionPosition>(entity =>
            {
                entity.ToTable("t_inspection_position");

                entity.HasComment("巡检区域表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("区域id");

                entity.Property(e => e.Instruction)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("instruction")
                    .HasComment("区域巡检项目说明")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("model")
                    .HasComment("1号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("position")
                    .HasComment("位点")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TInspectionRecord>(entity =>
            {
                entity.ToTable("t_inspection_record");

                entity.HasComment("巡检记录表");

                entity.HasIndex(e => new { e.Date, e.Period, e.Shift, e.InspectorN, e.PlanId }, "idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("巡检记录编号");

                entity.Property(e => e.Approval1)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("approval1")
                    .HasComment("审批人1机长审批合格与否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval1Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval1_remark")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval1Time)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("approval1_time")
                    .HasComment("审批人1机长审批时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("approval2")
                    .HasComment("审批人2运行专工审批合格与否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval2_remark")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2Time)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("approval2_time")
                    .HasComment("审批人2运行专工审批时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approver1N)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("approver1_n")
                    .HasComment("审批人1 机长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approver2N)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("approver2_n")
                    .HasComment("审批人2运行专工")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("check_time")
                    .HasComment("实际巡检时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentJson)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("content_json")
                    .HasComment("巡检内容 json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("date")
                    .HasComment("巡检日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExceptionFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("exception_flag")
                    .HasComment("是否正常：是1 否0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("groups")
                    .HasComment("班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectionFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("inspection_flag")
                    .HasComment("巡检项目选项是否正常：是1 否0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectorN)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("inspector_n")
                    .HasComment("实际巡检人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("media_list")
                    .HasComment("照片/视频 url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Period)
                    .HasColumnType("varchar(6)")
                    .HasColumnName("period")
                    .HasComment("巡检时刻")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasComment("巡检所用计划编号");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReviewFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("review_flag")
                    .HasComment("未审核0， 不合格-1， 合格1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Shift)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("shift")
                    .HasComment("轮班")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TInspectionStandard>(entity =>
            {
                entity.ToTable("t_inspection_standard");

                entity.HasComment("巡检标准表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(7)")
                    .HasColumnName("id")
                    .HasComment("标准编号");

                entity.Property(e => e.ContentJson)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("content_json")
                    .HasComment("标准内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(7)")
                    .HasColumnName("equipment_id")
                    .HasComment("设备台帐编号");

                entity.Property(e => e.StandardType)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("standard_type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("标准类型 运行中（默认）/投运前/其他")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ValidFlag)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("valid_flag")
                    .HasDefaultValueSql("'1'")
                    .HasComment("标准生效 1是/0否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TInspectionSystem>(entity =>
            {
                entity.ToTable("t_inspection_system");

                entity.HasComment("巡检系统表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(4)")
                    .HasColumnName("position_id")
                    .HasComment("巡检区域id");

                entity.Property(e => e.System)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("system")
                    .HasComment("巡检系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerAuxiliaryInfo>(entity =>
            {
                entity.ToTable("t_ledger_auxiliary_info");

                entity.HasComment("B2附属设备清单记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(10)")
                    .HasColumnName("amount")
                    .HasComment("数量");

                entity.Property(e => e.AuxiliaryModel)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("auxiliary_model")
                    .HasComment("型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AuxiliaryName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("auxiliary_name")
                    .HasComment("附属设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.ManufactureSerial)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacture_serial")
                    .HasComment("出厂编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Parameter)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("parameter")
                    .HasComment("技术参数 map")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Technical)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("technical")
                    .HasComment("技术资料 url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerDailyMaintain>(entity =>
            {
                entity.ToTable("t_ledger_daily_maintain");

                entity.HasComment("D设备日常维护记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.MaintainContent)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("maintain_content")
                    .HasComment("维护内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MaintainData)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("maintain_data")
                    .HasComment("维护数据（索引或超链接）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MaintainDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("maintain_date")
                    .HasComment("维护时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MaintainType)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("maintain_type")
                    .HasComment("维护性质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperatorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("operator_n")
                    .HasComment("维护人员 工号 list吗？")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Parts)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("parts")
                    .HasComment("维护备件")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerEquipmentDefault>(entity =>
            {
                entity.ToTable("t_ledger_equipment_default");

                entity.HasComment("设备基础台账模板");

                entity.Property(e => e.Id)
                    .HasColumnType("int(8)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("department")
                    .HasComment("所属部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentLevel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_level")
                    .HasComment("设备级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentModel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_model")
                    .HasComment("设备型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentState)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_state")
                    .HasComment("设备状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentType)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("equipment_type")
                    .HasComment("设备类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人 工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("manufacture_date")
                    .HasComment("出厂日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureSerial)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("manufacture_serial")
                    .HasComment("出厂编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("机组号：1号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperateDate)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("operate_date")
                    .HasComment("投运日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SystemId)
                    .HasColumnType("int(6)")
                    .HasColumnName("system_id")
                    .HasComment("所属系统id");

                entity.Property(e => e.SystemName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("system_name")
                    .HasComment("所属系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechDataList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_data_list")
                    .HasComment("技术资料url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechParamList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_param_list")
                    .HasComment("设备技术参数 list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<TLedgerEquipmentInfo>(entity =>
            {
                entity.ToTable("t_ledger_equipment_info");

                entity.HasComment("设备基础台账");

                entity.Property(e => e.Id)
                    .HasColumnType("int(8)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建时间");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("department")
                    .HasComment("所属部门")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentLevel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_level")
                    .HasComment("设备级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentModel)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_model")
                    .HasComment("设备型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("equipment_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentState)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("equipment_state")
                    .HasComment("设备状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentType)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("equipment_type")
                    .HasComment("设备类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LiableN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("liable_n")
                    .HasComment("责任人 工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("manufacture_date")
                    .HasComment("出厂日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ManufactureSerial)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("manufacture_serial")
                    .HasComment("出厂编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("机组号：1号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperateDate)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("operate_date")
                    .HasComment("投运日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SystemId)
                    .HasColumnType("int(6)")
                    .HasColumnName("system_id")
                    .HasComment("所属系统id");

                entity.Property(e => e.SystemName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("system_name")
                    .HasComment("所属系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechDataList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_data_list")
                    .HasComment("技术资料url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TechParamList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("tech_param_list")
                    .HasComment("设备技术参数 list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_time")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新时间");
            });

            modelBuilder.Entity<TLedgerMalfunction>(entity =>
            {
                entity.ToTable("t_ledger_malfunction");

                entity.HasComment("E设备事故事件记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.CauseAnalysis)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("cause_analysis")
                    .HasComment("原因分析")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ClearDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("clear_date")
                    .HasComment("消除时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.EventDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("event_date")
                    .HasComment("事件时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EventName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("event_name")
                    .HasComment("事件名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EventType)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("event_type")
                    .HasComment("事件性质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperatorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("operator_n")
                    .HasComment("处理人员 工号 list吗？")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Overview)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("overview")
                    .HasComment("事件简述")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Precaution)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("precaution")
                    .HasComment("防范措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Process)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("process")
                    .HasComment("处理过程")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Technical)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("technical")
                    .HasComment("技术资料url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerOverhaul>(entity =>
            {
                entity.ToTable("t_ledger_overhaul");

                entity.HasComment("C设备检修记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.BeginDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("begin_date")
                    .HasComment("检修开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("end_date")
                    .HasComment("检修结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.OperatorN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("operator_n")
                    .HasComment("检修人员 工号 list吗？")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OverhaulContent)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("overhaul_content")
                    .HasComment("检修主要内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OverhaulType)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("overhaul_type")
                    .HasComment("检修性质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Parts)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("parts")
                    .HasComment("备品配件")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PostCondition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("post_condition")
                    .HasComment("修后状况")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PreCondition)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("pre_condition")
                    .HasComment("修前状况")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TrialOperation)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("trial_operation")
                    .HasComment("试运情况（索引或超链接）list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerPartInfo>(entity =>
            {
                entity.ToTable("t_ledger_part_info");

                entity.HasComment("B3备品配件清单记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(10)")
                    .HasColumnName("amount")
                    .HasComment("数量");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("manufacturer")
                    .HasComment("制造厂家")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Parameter)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("parameter")
                    .HasComment("技术参数 map")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PartModel)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("part_model")
                    .HasComment("型号（图号）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PartName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("part_name")
                    .HasComment("部件名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerRenovation>(entity =>
            {
                entity.ToTable("t_ledger_renovation");

                entity.HasComment("H设备更新改造记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.BeginEndDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("begin_end_date")
                    .HasComment("起止时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.Investment)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("investment")
                    .HasComment("更改投资")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ParticipantN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("participant_n")
                    .HasComment("参与人员 工号 list？")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Reference)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("reference")
                    .HasComment("更改技术资料（索引或超链接）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RenovationContent)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("renovation_content")
                    .HasComment("更改内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RenovationReason)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("renovation_reason")
                    .HasComment("更改原因")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RenovationResult)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("renovation_result")
                    .HasComment("更改效果")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RenovationType)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("renovation_type")
                    .HasComment("更改性质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SupplierConstructor)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("supplier_constructor")
                    .HasComment("主要供货厂家及施工单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLedgerSpecialCheck>(entity =>
            {
                entity.ToTable("t_ledger_special_check");

                entity.HasComment("F设备专项检查记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("charge_n")
                    .HasComment("整改责任人 工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckDate)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("check_date")
                    .HasComment("检查时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckType)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("check_type")
                    .HasComment("检查性质")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckUnit)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("check_unit")
                    .HasComment("检查单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(10)")
                    .HasColumnName("equipment_id")
                    .HasComment("所属设备 id");

                entity.Property(e => e.Problem)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("problem")
                    .HasComment("发现问题")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RectifyCondition)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("rectify_condition")
                    .HasComment("整改情况")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RectifyPeriod)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("rectify_period")
                    .HasComment("整改期限")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Reference)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("reference")
                    .HasComment("相关资料（索引或超链接）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLimitSpace>(entity =>
            {
                entity.ToTable("t_limit_space");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("address")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("content")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembers)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_members")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("groups")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Guardian)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guardian")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GuardianSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guardian_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("issuer_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LeaderSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("leader_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("order_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeMeasureJson)
                    .HasColumnType("varchar(3000)")
                    .HasColumnName("safe_measure_json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SamplDataJson)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("sampl_data_json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UnitChargeSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit_charge_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkEndDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_end_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkMemberSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_member_sign")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkStartDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_start_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLogDefault>(entity =>
            {
                entity.ToTable("t_log_default");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Item)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("item")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LogFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("log_flag")
                    .HasComment("值长日志1/机长日志2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Modular)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("modular")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Title)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("title")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TLogMachinesetLeader>(entity =>
            {
                entity.ToTable("t_log_machineset_leader");

                entity.HasComment("机长日志");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.Conveyor)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("conveyor")
                    .HasComment("输机运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("create_date")
                    .HasComment("创建时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DayHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("day_handover")
                    .HasComment("白班交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DayTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("day_takeover")
                    .HasComment("白班接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElecConsumption)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("elec_consumption")
                    .HasComment("厂用电系统运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EveHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("eve_handover")
                    .HasComment("前夜交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EveTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("eve_takeover")
                    .HasComment("前夜接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroundwireNum)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("groundwire_num")
                    .HasComment("检修设备已封接地刀闸（接地线）编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.HydrogenOil)
                    .HasColumnType("varchar(1500)")
                    .HasColumnName("hydrogen_oil")
                    .HasComment("补氢量和油箱油位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("job_number")
                    .HasComment("工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LateNightHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("late_night_handover")
                    .HasComment("后夜交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LateNightTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("late_night_takeover")
                    .HasComment("后夜接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Matters)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("matters")
                    .HasComment("交代事项")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("机组号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PushNext)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("push_next")
                    .HasComment("接收人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Records)
                    .HasColumnType("text")
                    .HasColumnName("records")
                    .HasComment("记事")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Signature)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("signature")
                    .HasComment("交接班签字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("update_date")
                    .HasComment("修改时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TLogShiftSupervisor>(entity =>
            {
                entity.ToTable("t_log_shift_supervisor");

                entity.HasComment("值长日志");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id");

                entity.Property(e => e.AirCompressor)
                    .HasColumnType("varchar(800)")
                    .HasColumnName("air_compressor")
                    .HasComment("空压机系统")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CirculatingFireWater)
                    .HasColumnType("varchar(800)")
                    .HasColumnName("circulating_fire_water")
                    .HasComment("循环水、消防水系统运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CoalWeightIndicators)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("coal_weight_indicators")
                    .HasComment("煤量指标情况")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("create_date")
                    .HasComment("创建时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DayHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("day_handover")
                    .HasComment("白班交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DayTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("day_takeover")
                    .HasComment("白班接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DesaltedIndustrialWater)
                    .HasColumnType("varchar(800)")
                    .HasColumnName("desalted_industrial_water")
                    .HasComment("除盐水、工业水系统运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ElecConsumption)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("elec_consumption")
                    .HasComment("厂用电系统运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EveHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("eve_handover")
                    .HasComment("前夜交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.EveTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("eve_takeover")
                    .HasComment("前夜接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.FiveHundredKv)
                    .HasColumnType("varchar(1500)")
                    .HasColumnName("five_hundred_kv")
                    .HasComment("500kV系统运行方式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.GroundWire)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("ground_wire")
                    .HasComment("地线装设情况")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("job_number")
                    .HasComment("工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LateNightHandover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("late_night_handover")
                    .HasComment("后夜交班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LateNightTakeover)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("late_night_takeover")
                    .HasComment("后夜接班人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainIndicators)
                    .HasColumnType("varchar(3000)")
                    .HasColumnName("main_indicators")
                    .HasComment("主要指标完成情况")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PushNext)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("push_next")
                    .HasComment("接收人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Records)
                    .HasColumnType("text")
                    .HasColumnName("records")
                    .HasComment("记事")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Signature)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("signature")
                    .HasComment("交接班签字")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("update_date")
                    .HasComment("修改时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TMonitorProbeGai>(entity =>
            {
                entity.ToTable("t_monitor_probe_gai");

                entity.HasComment("特种检测探头表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.AccessMode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("access_mode")
                    .HasComment("接入方式")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AccessPoint)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("access_point")
                    .HasComment("接入点")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AccessPositon)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("access_positon")
                    .HasComment("接入位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Address)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("address")
                    .HasComment("地址")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertBelow)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("alert_below")
                    .HasComment("低于该值则发出警报")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertFlag)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("alert_flag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertOver)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("alert_over")
                    .HasComment("高于该值则发出警报")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Converge)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("converge")
                    .HasComment("汇聚点位置位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DataAddress)
                    .HasColumnType("int(255)")
                    .HasColumnName("data_address")
                    .HasComment("数据地址");

                entity.Property(e => e.Features)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("features")
                    .HasComment("功能")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Grade)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("grade")
                    .HasComment("信号标号/线号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstrumentLabel)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("instrument_label")
                    .HasDefaultValueSql("''")
                    .HasComment("设备标号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstrumentName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("instrument_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegisterData)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("register_data")
                    .HasComment("从寄存器读取的内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("remarks")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SwitchPositon)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("switch_positon")
                    .HasComment("转换模块位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("workshop")
                    .HasComment("所属工房")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TMotor>(entity =>
            {
                entity.ToTable("t_motor");

                entity.HasComment("汽机阀门表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TNotify>(entity =>
            {
                entity.ToTable("t_notify");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Content)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("content")
                    .HasComment("票名称或其他消息类型内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasComment("创建者")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("create_date")
                    .HasComment("创建时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Handle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("handle")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否办理  1/0")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotifyMessage)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("notify_message")
                    .HasComment("推送内容")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NotifyType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("notify_type")
                    .HasComment("消息类型 0/待办，1/公告，2/系统通知")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("num")
                    .HasComment("票号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ReadIs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("read_is")
                    .HasDefaultValueSql("'0'")
                    .HasComment("是否已读   1/0")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("update_by")
                    .HasComment("办理者")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("update_date")
                    .HasComment("办理时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TOpenDown>(entity =>
            {
                entity.ToTable("t_open_down");

                entity.HasComment("开关停电风险预控票");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Approver)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approver")
                    .HasComment("批准人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Author)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("author")
                    .HasComment("编写人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe1s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_1s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe1s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_1s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe2s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_2s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe2s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_2s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe3s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_3s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe3s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_3s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe4s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_4s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe4s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_4s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe5s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_5s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe5s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_5s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe6s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_6s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe6s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_6s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe7s1)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_7s1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.BookSafe7s2)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("book_safe_7s2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Charge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("charge")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckStatu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("check_statu")
                    .HasComment("审核状态")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateUpdate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_update");

                entity.Property(e => e.Guardian)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("guardian")
                    .HasComment("监护人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LevelCheck)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("level_check")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperaNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("opera_num")
                    .HasComment("操作票编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Operator)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operator")
                    .HasComment("操作人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Reviewer)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("reviewer")
                    .HasComment("审核人")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RiskLevel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("risk_level")
                    .HasComment("风险级别")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeCharge)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_charge")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeGuardian)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_guardian")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeOperator)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_operator")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Version)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("version")
                    .HasComment("版本")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TOperShiftRecord>(entity =>
            {
                entity.ToTable("t_oper_shift_record");

                entity.HasComment("运行部值班人员安排表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalMembers)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("additional_members")
                    .HasComment("机动人员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.EndTime)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("end_time")
                    .HasComment("结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("group_num")
                    .HasComment("班组号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MainMembers)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("main_members")
                    .HasComment("主值班员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ModelCharges)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("model_charges")
                    .HasComment("机长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Shift)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("shift")
                    .HasComment("班次")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftCharge)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("shift_charge")
                    .HasComment("值长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftDate)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("shift_date")
                    .HasComment("值班日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StartTime)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("start_time")
                    .HasComment("起始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SubMembers)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("sub_members")
                    .HasComment("值班员")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");
            });

            modelBuilder.Entity<TOperationTicketPrecontrol>(entity =>
            {
                entity.ToTable("t_operation_ticket_precontrol");

                entity.HasComment("操作票危险点分析与风险预控措施单");

                entity.Property(e => e.Id)
                    .HasColumnType("int(5)")
                    .HasColumnName("id")
                    .HasComment("id");

                entity.Property(e => e.AppendixJson)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("appendix_json")
                    .HasComment("操作票危险点分析与风险预控措施")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CommonFlag)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("common_flag")
                    .HasComment("备用flag")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustodyNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("custody_num")
                    .HasComment("监护人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustodySign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("custody_sign")
                    .HasComment("监护人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CustodySignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("custody_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsEndFlag)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("is_end_flag")
                    .HasComment("是否完成")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperaterNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operater_num")
                    .HasComment("操作人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperaterSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operater_sign")
                    .HasComment("操作人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperaterSignDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operater_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operation_num")
                    .HasComment("操作票编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationTask)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("operation_task")
                    .HasComment("操作任务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasComment("状态")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TOrderRecord>(entity =>
            {
                entity.ToTable("t_order_record");

                entity.HasComment("工作票记录本");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("charge_n")
                    .HasComment("工作负责人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("end_date")
                    .HasComment("工作票终结")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("num")
                    .HasComment("工作票编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperationN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("operation_n")
                    .HasComment("值班人员工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_end_date")
                    .HasComment("计划工作结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_start_date")
                    .HasComment("计划工作开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("（1有效0作废）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkTaskJson)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("work_task_json")
                    .HasComment("工作任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TOverallSetting>(entity =>
            {
                entity.ToTable("t_overall_settings");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ItemContent)
                    .HasColumnType("varchar(2550)")
                    .HasColumnName("item_content")
                    .HasComment("设置内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ItemName)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("item_name")
                    .HasComment("设置名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注说明")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TPatrolRecord>(entity =>
            {
                entity.ToTable("t_patrol_record");

                entity.HasComment("巡查记录表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("巡查记录编号");

                entity.Property(e => e.ExceptionFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("exception_flag")
                    .HasComment("是否正常：是1 否0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExceptionName)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("exception_name")
                    .HasComment("异常名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("media_list")
                    .HasComment("照片/视频 url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PatrolDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("patrol_date")
                    .HasComment("巡查日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PatrolTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("patrol_time")
                    .HasComment("巡查时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PatrolerN)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("patroler_n")
                    .HasComment("巡查人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SystemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("system_id")
                    .HasComment("设备id");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TProductSpec>(entity =>
            {
                entity.ToTable("t_product_spec");

                entity.HasComment("生产指标表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ComputeFormula)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("compute_formula")
                    .HasComment("计算：计算公式")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ConnectSpecIds)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("connect_spec_ids")
                    .HasComment("与之相关的要涉及计算的指标id列表")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InputMethod)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("input_method")
                    .HasComment("录入方式：采集1 / 录入2 / 计算3")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ItemName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("item_name")
                    .HasComment("项目名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LastUpdated)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("last_updated")
                    .HasComment("最近一次更新时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("model")
                    .HasComment("所属机组：1 / 2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PointName)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("point_name")
                    .HasComment("采集：对应的 sis 的全局点名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Record)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("record")
                    .HasComment("本日 / 实时 数据")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShowFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("show_flag")
                    .HasComment("是否在主页上显示：显示1 / 不显示0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TypeFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("type_flag")
                    .HasComment("指标类型：大指标1 / 小指标2")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TRelation>(entity =>
            {
                entity.ToTable("t_relation");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.EnclosureDate)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("enclosure_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EnclosureId)
                    .HasColumnType("int(11)")
                    .HasColumnName("enclosure_id");

                entity.Property(e => e.EnclosureNum)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("enclosure_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EnclosureType)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("enclosure_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MainNum)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("main_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TRiskManage>(entity =>
            {
                entity.ToTable("t_risk_manage");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RepairContent)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("repair_content")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TRiskManageTemp>(entity =>
            {
                entity.ToTable("t_risk_manage_temp");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.RepairContent)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("repair_content")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RepairName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("repair_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TRiskRepair>(entity =>
            {
                entity.ToTable("t_risk_repair");

                entity.HasComment("风险预控");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Chapter)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("chapter")
                    .HasComment("章节")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DangerFactor)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("danger_factor")
                    .HasComment("危害因素(外因)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DangerResult)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("danger_result")
                    .HasComment("危害后果")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DangerSource)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("danger_source")
                    .HasComment("危险源(能量及载体)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RiskLevel)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("risk_level")
                    .HasComment("风险等级")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasColumnName("unit")
                    .HasComment("单元")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkSeq)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_seq")
                    .HasComment("工序")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkStandard)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("work_standard")
                    .HasComment("作业标准(典型控制措施)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSafeTechnical>(entity =>
            {
                entity.ToTable("t_safe_technical");

                entity.HasComment("安全交底");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_date")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMemberDivision)
                    .HasColumnType("text")
                    .HasColumnName("group_member_division")
                    .HasComment("班组成员及分工")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupN)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_n")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("next")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OrderNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("order_num")
                    .HasComment("工作票编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Sequence)
                    .HasColumnType("text")
                    .HasColumnName("sequence")
                    .HasComment("序列内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("statu")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkGroupNum)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_group_num")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkGroupSign)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("work_group_sign")
                    .HasComment("成员签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSamplDatum>(entity =>
            {
                entity.ToTable("t_sampl_data");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");
            });

            modelBuilder.Entity<TShiftCheck>(entity =>
            {
                entity.ToTable("t_shift_check");

                entity.HasComment("人员值班签到表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ClockEndTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_end_time")
                    .HasComment("规定打卡签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ClockStartTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("clock_start_time")
                    .HasComment("规定打卡签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("create_by")
                    .HasComment("值班项创建人的user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("create_date")
                    .HasComment("值班项创建时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("job_number")
                    .HasComment("应打卡人，外键：链接user表id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("shift_date")
                    .HasComment("打卡日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignEndTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_end_time")
                    .HasComment("员工实际签退时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignFlag)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("sign_flag")
                    .HasComment("签到次数（应签2次）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignPeriod)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("sign_period")
                    .HasComment("值班打卡，3选1（早中晚）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignStartTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("sign_start_time")
                    .HasComment("员工实际签到时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignType)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("sign_type")
                    .HasComment("常规vs值班")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SignValid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("sign_valid")
                    .HasComment("是否考勤，记录常规打卡中是否请假")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("update_by")
                    .HasComment("值班项修改修改人的user_id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("update_date")
                    .HasComment("值班项最终修改时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TShiftMember>(entity =>
            {
                entity.ToTable("t_shift_member");

                entity.HasComment("全厂值班人员安排表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.GroupNum)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("group_num")
                    .HasComment("组号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Identity)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("identity")
                    .HasComment("岗位身份")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("job_number")
                    .HasComment("工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ShiftType)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("shift_type")
                    .HasComment("轮班制度")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");
            });

            modelBuilder.Entity<TSmallSpecDatum>(entity =>
            {
                entity.ToTable("t_small_spec_data");

                entity.HasComment("小指标数据表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.DayRecord)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("day_record")
                    .HasComment("当日数据")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MonthTotal)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("month_total")
                    .HasComment("月累计")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RecordDate)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("record_date")
                    .HasComment("记录日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SmallSpecId)
                    .HasColumnType("int(11)")
                    .HasColumnName("small_spec_id")
                    .HasComment("小指标基本信息表id");

                entity.Property(e => e.YearTotal)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("year_total")
                    .HasComment("年累计")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheck>(entity =>
            {
                entity.ToTable("t_spot_check");

                entity.HasComment("点检聚合表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ContentJsonId)
                    .HasColumnType("int(5)")
                    .HasColumnName("content_json_id")
                    .HasComment("点检标准内容");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("create_time");

                entity.Property(e => e.InspectionCycle)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("inspection_cycle")
                    .HasComment("点检周期 每天/每周/每月")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectorList)
                    .HasColumnType("varchar(1000)")
                    .HasColumnName("inspector_list")
                    .HasComment("点检人员工号list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(5)")
                    .HasColumnName("position_id")
                    .HasComment("点检区域id");

                entity.Property(e => e.System)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("system")
                    .HasComment("点检系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("update_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_time");

                entity.Property(e => e.ValidFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("valid_flag")
                    .HasComment("计划生效 1是/0否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheckKk>(entity =>
            {
                entity.ToTable("t_spot_check_kks");

                entity.HasComment("设备kks码关联巡检区域表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Equipment)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("equipment")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Kks)
                    .HasColumnType("varchar(25)")
                    .HasColumnName("kks")
                    .HasComment("设备KKS码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(5)")
                    .HasColumnName("position_id")
                    .HasComment("巡检区域id");
            });

            modelBuilder.Entity<TSpotCheckPlan>(entity =>
            {
                entity.ToTable("t_spot_check_plan");

                entity.HasComment("点检计划表");

                entity.HasIndex(e => e.StandardId, "tk_standard")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(7)")
                    .HasColumnName("id")
                    .HasComment("计划编号");

                entity.Property(e => e.InspectionCycle)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("inspection_cycle")
                    .HasComment("点检周期 每天/每周/每月")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectionTime)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("inspection_time")
                    .HasComment("点检时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectorList)
                    .HasColumnType("varchar(4000)")
                    .HasColumnName("inspector_list")
                    .HasComment("点检人员工号list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StandardId)
                    .HasColumnType("int(7)")
                    .HasColumnName("standard_id")
                    .HasComment("标准编号");

                entity.Property(e => e.ValidFlag)
                    .HasColumnType("varchar(4)")
                    .HasColumnName("valid_flag")
                    .HasDefaultValueSql("'1'")
                    .HasComment("计划生效 1是/0否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheckPosition>(entity =>
            {
                entity.ToTable("t_spot_check_position");

                entity.HasComment("巡检区域表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("区域id");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业code")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Model)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("model")
                    .HasComment("!号机/2号机/共用")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("position")
                    .HasComment("位点")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheckRecord>(entity =>
            {
                entity.ToTable("t_spot_check_record");

                entity.HasComment("点检记录表");

                entity.HasIndex(e => new { e.Date, e.Period, e.Shift, e.InspectorN, e.PlanId }, "idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("点检记录编号");

                entity.Property(e => e.Approval1)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("approval1")
                    .HasComment("审批人1机长审批合格与否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval1Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval1_remark")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval1Time)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("approval1_time")
                    .HasComment("审批人1机长审批时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2)
                    .HasColumnType("varchar(8)")
                    .HasColumnName("approval2")
                    .HasComment("审批人2运行专工审批合格与否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2Remark)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("approval2_remark")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approval2Time)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("approval2_time")
                    .HasComment("审批人2运行专工审批时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approver1N)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("approver1_n")
                    .HasComment("审批人1 机长")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Approver2N)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("approver2_n")
                    .HasComment("审批人2运行专工")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CheckTime)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("check_time")
                    .HasComment("实际点检时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ContentJson)
                    .HasColumnType("varchar(8000)")
                    .HasColumnName("content_json")
                    .HasComment("点检内容 json")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Date)
                    .HasColumnType("varchar(12)")
                    .HasColumnName("date")
                    .HasComment("点检日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ExceptionFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("exception_flag")
                    .HasComment("是否正常：是1 否0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("groups")
                    .HasComment("班组")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectionFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("inspection_flag")
                    .HasComment("点检项目选项是否有异常：是1 否0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InspectorN)
                    .HasColumnType("varchar(7)")
                    .HasColumnName("inspector_n")
                    .HasComment("实际点检人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("media_list")
                    .HasComment("照片/视频 url list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Period)
                    .HasColumnType("varchar(6)")
                    .HasColumnName("period")
                    .HasComment("点检时刻")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanId)
                    .HasColumnType("int(11)")
                    .HasColumnName("plan_id")
                    .HasComment("点检所用计划编号");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ReviewFlag)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("review_flag")
                    .HasComment("未审核0， 不合格-1， 合格1")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Shift)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("shift")
                    .HasComment("轮班")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheckStandard>(entity =>
            {
                entity.ToTable("t_spot_check_standard");

                entity.Property(e => e.Id)
                    .HasColumnType("int(7)")
                    .HasColumnName("id")
                    .HasComment("标准编号");

                entity.Property(e => e.ContentJson)
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("content_json")
                    .HasComment("标准内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("int(7)")
                    .HasColumnName("equipment_id")
                    .HasComment("设备台帐编号");

                entity.Property(e => e.InspectorList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("inspector_list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.StandardType)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("standard_type")
                    .HasDefaultValueSql("'1'")
                    .HasComment("标准类型 运行中（默认）/投运前/其他")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ValidFlag)
                    .HasColumnType("varchar(3)")
                    .HasColumnName("valid_flag")
                    .HasDefaultValueSql("'1'")
                    .HasComment("标准生效 1是/0否")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TSpotCheckSystem>(entity =>
            {
                entity.ToTable("t_spot_check_system");

                entity.HasComment("巡检系统表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PositionId)
                    .HasColumnType("int(4)")
                    .HasColumnName("position_id")
                    .HasComment("巡检区域id");

                entity.Property(e => e.System)
                    .HasColumnType("varchar(55)")
                    .HasColumnName("system")
                    .HasComment("巡检系统名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TThermomechanicaloperation>(entity =>
            {
                entity.ToTable("t_thermomechanicaloperation");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.ErrorStatu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("error_statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("作废状态码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustody)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("importent_custody")
                    .HasComment("重大操作监护人们")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyChiefengineer)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("importent_custody_chiefengineer")
                    .HasComment("重大操作监护总工程师")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyDepartmentdeputydirector)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("importent_custody_departmentdeputydirector")
                    .HasComment("重大操作监护运行部副主任")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyDepartmentdirector)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("importent_custody_departmentdirector")
                    .HasComment("重大操作监护运行部主任")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ImportentCustodyProfessionaldirector)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("importent_custody_professionaldirector")
                    .HasComment("重大操作监护运行部专业主管")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsImportentFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_importent_flag")
                    .HasComment("是否属于重大操作 0f 1t");

                entity.Property(e => e.IsMonitoredFlag)
                    .HasColumnType("int(11)")
                    .HasColumnName("is_monitored_flag")
                    .HasComment("是否处于监护人监护下操作 0-false 1-true");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("next")
                    .HasComment("下一步推送人")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("num")
                    .HasComment("编号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationEndDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("operation_end_date")
                    .HasComment("操作结束时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationItemsJson)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("Operation_items_json")
                    .HasComment("操作项目")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("operation_start_date")
                    .HasComment("操作开始时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OperationTask)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("operation_task")
                    .HasComment("操作任务")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("order_dutyleader_num")
                    .HasComment("值班负责人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("order_dutyleader_sign")
                    .HasComment("值班负责人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderDutyleaderSignDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("order_dutyleader_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("order_n")
                    .HasComment("发令人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderNum)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("order_shiftleader_num")
                    .HasComment("值长工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("order_shiftleader_sign")
                    .HasComment("值长签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderShiftleaderSignDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("order_shiftleader_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OrderStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("order_start_date")
                    .HasComment("发令时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("状态码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SuffeN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffe_n")
                    .HasComment("受令人工号(值长）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodyNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffer_custody_num")
                    .HasComment("监护人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodySign)
                    .HasColumnType("varchar(600)")
                    .HasColumnName("suffer_custody_sign")
                    .HasComment("监护人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferCustodySignDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("suffer_custody_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("suffer_operater_num")
                    .HasComment("操作人工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterSign)
                    .HasColumnType("varchar(600)")
                    .HasColumnName("suffer_operater_sign")
                    .HasComment("操作人签名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SufferOperaterSignDate)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("suffer_operater_sign_date")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("unit")
                    .HasComment("单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TTicket>(entity =>
            {
                entity.ToTable("t_ticket");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.TicketName)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ticket_name")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TicketType)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ticket_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TTicketSupervise>(entity =>
            {
                entity.ToTable("t_ticket_supervise");

                entity.HasIndex(e => e.TicketNum, "index_code1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ArrivalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("arrival_date")
                    .HasComment("到场时间");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date");

                entity.Property(e => e.ImageAdress)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("image_adress")
                    .HasComment("图片地址")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PassType)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("pass_type")
                    .HasComment("通道类型")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RelationTicketNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("relation_ticket_num")
                    .HasComment("关联票号");

                entity.Property(e => e.SafeIs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("safe_is")
                    .HasComment("是否安全  1/0")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafePersonNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("safe_person_num")
                    .HasComment("安全专工工号");

                entity.Property(e => e.TicketNum)
                    .HasColumnType("int(11)")
                    .HasColumnName("ticket_num")
                    .HasComment("票号");

                entity.Property(e => e.UpdateBy)
                    .HasColumnType("datetime")
                    .HasColumnName("update_by");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("update_date");
            });

            modelBuilder.Entity<TTicketTemplate>(entity =>
            {
                entity.ToTable("t_ticket_template");

                entity.HasComment("工作票、操作票模板信息存放表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(3)")
                    .HasColumnName("id");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("remark")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TemplateUri)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("template_uri")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TicketType)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("ticket_type")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TTwoworkorder>(entity =>
            {
                entity.ToTable("t_twoworkorder");

                entity.HasComment("电气第二类工作票");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalSafeMeasureJson)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("additional_safe_measure_json")
                    .HasComment("补充安全措施（值班人员填写）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("charge_n")
                    .HasComment("工作负责人（监护人）工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("charge_sign")
                    .HasComment("工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.CreateBy)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("create_by")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayChargeDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("delay_charge_date")
                    .HasComment("延期工作负责人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayChargeSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("delay_charge_sign")
                    .HasComment("延期工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("delay_date")
                    .HasComment("工作票有效期延长到")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayLicensorDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("delay_licensor_date")
                    .HasComment("延期工作许可人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayLicensorSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("delay_licensor_sign")
                    .HasComment("延期工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DoubleName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("double_name")
                    .HasComment("工作的机组、变、配电站名称及设备双重名称（即设备名称和编号）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndChargeDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("end_charge_date")
                    .HasComment("终结工作负责人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndChargeSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("end_charge_sign")
                    .HasComment("终结工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("end_date")
                    .HasComment("工作票终结")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndLicensorDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("end_licensor_date")
                    .HasComment("终结工作许可人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndLicensorSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("end_licensor_sign")
                    .HasComment("终结工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersArray)
                    .HasColumnType("text")
                    .HasColumnName("group_members_array")
                    .HasComment("工作班成员签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersNs)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("group_members_ns")
                    .HasComment("工作班成员（不包括工作负责人）工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersNum)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("group_members_num")
                    .HasComment("工作班成员数量（包括工作负责人）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersSigns)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("group_members_signs")
                    .HasComment("工作班成员签名工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("groups")
                    .HasComment("班组（作业队）：工作班组全称/检修部门（或单位）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("issuer_date")
                    .HasComment("工作票签发日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerN)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("issuer_n")
                    .HasComment("工作票签发人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("issuer_sign")
                    .HasComment("工作票签发人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorN)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("licensor_n")
                    .HasComment("工作许可人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorSign)
                    .HasColumnType("varchar(500)")
                    .HasColumnName("licensor_sign")
                    .HasComment("工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.MediaList)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("media_list")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("next")
                    .HasComment("接下来要推送的员工工号（1 or n）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("num")
                    .HasComment("工作票编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OperationN)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("operation_n")
                    .HasComment("值班人员工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitWorkDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("permit_work_date")
                    .HasComment("许可开始工作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_end_date")
                    .HasComment("计划工作结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_start_date")
                    .HasComment("计划工作开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Quality)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("quality")
                    .HasDefaultValueSql("'1'")
                    .HasComment("（1合格0不合格）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RelationId)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("relation_id")
                    .HasComment("关联附件id")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("text")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeMeasureList)
                    .HasColumnType("text")
                    .HasColumnName("safe_measure_list")
                    .HasComment("注意事项（安全措施）：应注意的事项及采取的安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("unit")
                    .HasComment("工作票签发单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("（1有效0作废）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkRetainList)
                    .HasColumnType("text")
                    .HasColumnName("work_retain_list")
                    .HasComment("工作条件（停电或不停电，或邻近及保留带电设备名称）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkTaskJson)
                    .HasColumnType("text")
                    .HasColumnName("work_task_json")
                    .HasComment("工作任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TUser>(entity =>
            {
                entity.ToTable("t_user");

                entity.HasComment("员工表");

                entity.HasIndex(e => e.JobNumber, "tk_jn")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AccessCode)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("access_code")
                    .HasComment("权限")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CamId)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("cam_id")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("创建日期");

                entity.Property(e => e.Department)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("department")
                    .HasComment("部门")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Email)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("email")
                    .HasComment("邮箱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Initials)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("initials")
                    .HasComment("首字母")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IsDeleted)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("is_deleted")
                    .HasComment("1 删除 / 0 未删除");

                entity.Property(e => e.JobNumber)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("job_number")
                    .HasComment("工号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("major")
                    .HasDefaultValueSql("'NIL'")
                    .HasComment("专业")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NickName)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("nick_name")
                    .HasComment("别名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Password)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("password")
                    .HasComment("密码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PcToken)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("pc_token")
                    .HasComment("PC token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Phone)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("phone")
                    .HasComment("手机")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PinYin)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("pin_yin")
                    .HasComment("拼音")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Post)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("post")
                    .HasComment("岗位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Telephone)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("telephone")
                    .HasComment("电话")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Token)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("token")
                    .HasComment("安卓 token")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TokenUpdated)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("token_updated")
                    .HasComment("安卓 token 上次刷新时间")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasColumnName("update_date")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP")
                    .HasComment("更新日期");

                entity.Property(e => e.UserName)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("user_name")
                    .HasComment("用户名")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TUserManagementPower>(entity =>
            {
                entity.ToTable("t_user_management_power");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10)")
                    .HasColumnName("id")
                    .HasComment("id");

                entity.Property(e => e.DigitalFileQuery)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("digital_file_query")
                    .HasComment("数字档案查询")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EquipmentInspection)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("equipment_inspection")
                    .HasComment("设备巡检")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.FaultDefectManagement)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Fault_defect_management")
                    .HasComment("故障缺陷管理")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IntelligentSecurityPrediction)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("Intelligent_security_prediction")
                    .HasComment("智能安全预测系统")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ModelFlag)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("model_flag")
                    .HasComment("模板标志")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("num")
                    .HasComment("工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PersonnelPositionManagement)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("personnel_position_management")
                    .HasComment("人员岗位管理(不包括生成签到二维码)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ProductionInformationQuery)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("production_information_query")
                    .HasComment("生产信息综合查询")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.QrcodeManagement)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("qrcode_management")
                    .HasComment("二维码管理")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SigninCodeManagement)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("signin_code_management")
                    .HasComment("签到二维码管理")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.TicketSystem)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("ticket_system")
                    .HasComment("两票系统")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserManagement)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_management")
                    .HasComment("用户管理")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.UserManagementPower)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("user_management_power")
                    .HasComment("用户权限管理(用不到)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.VideoQuery)
                    .HasColumnType("varchar(255)")
                    .HasColumnName("video_query")
                    .HasComment("视频查询(用不到)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TValve>(entity =>
            {
                entity.ToTable("t_valve");

                entity.HasComment("阀门信息汇总表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(6)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.InletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("inlet_pipe_spec")
                    .HasComment("连接管道规格 阀门入口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.InterfaceForm)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("interface_form")
                    .HasComment("接口形式")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.KksCode)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("kks_code")
                    .HasComment("KKS编码")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MainSysName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("main_sys_name")
                    .HasComment("阀门所属主系统（热机、汽机、锅炉，3选1）")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Manufacturer)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("manufacturer")
                    .HasComment("生产厂家/备注")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NominalDiameter)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("nominal_diameter")
                    .HasComment("公称直径(DN/NPS)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OfUnit)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("of_unit")
                    .HasComment("所属机位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.OutletPipeSpec)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("outlet_pipe_spec")
                    .HasComment("连接管道规格 阀门出口")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressure)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_pressure")
                    .HasComment("管道设计参数 压力值")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipePressureUnit)
                    .HasColumnType("varchar(10)")
                    .HasColumnName("pipe_pressure_unit")
                    .HasComment("管道设计参数 压力单位")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PipeTemp)
                    .HasColumnType("varchar(15)")
                    .HasColumnName("pipe_temp")
                    .HasComment("管道设计参数 温度")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Position)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("position")
                    .HasComment("阀门所在位置")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PressureRating)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("pressure_rating")
                    .HasComment("压力等级(PN/ANSI)(MPa)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SubSysName)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("sub_sys_name")
                    .HasComment("安装图册名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerial)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial")
                    .HasComment("安装图卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SysSerialShort)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("sys_serial_short")
                    .HasComment("卷册号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("int(4)")
                    .HasColumnName("total_amount")
                    .HasComment("数量（件） 总计（弃用数据）");

                entity.Property(e => e.Unit1Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_1_amount")
                    .HasComment("数量（件） 1号机（弃用数据）");

                entity.Property(e => e.Unit2Amount)
                    .HasColumnType("int(4)")
                    .HasColumnName("unit_2_amount")
                    .HasComment("数量（件） 2号机（弃用数据）");

                entity.Property(e => e.ValveModel)
                    .HasColumnType("varchar(40)")
                    .HasColumnName("valve_model")
                    .HasComment("型号")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ValveName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("valve_name")
                    .HasComment("阀门名称")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TWarnCameraGai>(entity =>
            {
                entity.ToTable("t_warn_camera_gai");

                entity.HasComment("预警摄像机表");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("序号");

                entity.Property(e => e.AccessMode)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("access_mode")
                    .HasComment("接入方式")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AccessPoint)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("access_point")
                    .HasComment("接入点")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AccessPositon)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("access_positon")
                    .HasComment("接入位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertBelow)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("alert_below")
                    .HasComment("低于该值则发出警报")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertFlag)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("alert_flag")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.AlertOver)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("alert_over")
                    .HasComment("高于该值则发出警报")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Features)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("features")
                    .HasComment("功能")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Grade)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("grade")
                    .HasComment("信号标号/线号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstallPosition)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("install_position")
                    .HasComment("安装位置")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstrumentLabel)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("instrument_label")
                    .HasComment("设备标号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstrumentModel)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("instrument_model")
                    .HasComment("设备型号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.InstrumentName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("instrument_name")
                    .HasComment("设备名称")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Major)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("major")
                    .HasComment("专业")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.OpticalFiber)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("optical_fiber")
                    .HasComment("光纤号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.RegisterData)
                    .HasColumnType("varchar(20)")
                    .HasColumnName("register_data")
                    .HasComment("从寄存器读取的内容")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remarks)
                    .HasColumnType("varchar(100)")
                    .HasColumnName("remarks")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Workshop)
                    .HasColumnType("varchar(50)")
                    .HasColumnName("workshop")
                    .HasComment("所属工房")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<TWorkorder>(entity =>
            {
                entity.ToTable("t_workorder");

                entity.HasComment("工作任务单");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.AdditionalSafeMeasureList)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("additional_safe_measure_list")
                    .HasComment("已采取的安全措施和其他安全注意事项交代（由工作许可人填写）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("charge_n")
                    .HasComment("工作负责人（监护人）工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.ChargeSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("charge_sign")
                    .HasComment("工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayChargeDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("delay_charge_date")
                    .HasComment("延期工作负责人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayChargeSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("delay_charge_sign")
                    .HasComment("延期工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("delay_date")
                    .HasComment("工作票有效期延长到")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayLicensorDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("delay_licensor_date")
                    .HasComment("延期工作许可人签名日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DelayLicensorSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("delay_licensor_sign")
                    .HasComment("延期工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.DoubleName)
                    .HasColumnType("varchar(80)")
                    .HasColumnName("double_name")
                    .HasComment("工作的机组、变、配电站名称及设备双重名称（即设备名称和编号）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndChargeSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("end_charge_sign")
                    .HasComment("终结工作负责人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndDate)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("end_date")
                    .HasComment("工作票终结")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.EndLicensorSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("end_licensor_sign")
                    .HasComment("终结工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersArray)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("group_members_array")
                    .HasComment("工作班成员签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersNs)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("group_members_ns")
                    .HasComment("工作班成员（不包括工作负责人）工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersNum)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("group_members_num")
                    .HasComment("工作班成员数量（包括工作负责人）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.GroupMembersNums)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("group_members_nums")
                    .HasComment("工作班成员签名工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Groups)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("groups")
                    .HasComment("班组（作业队）：工作班组全称/检修部门（或单位）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("issuer_date")
                    .HasComment("工作票签发日期")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("issuer_n")
                    .HasComment("工作票签发人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.IssuerSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("issuer_sign")
                    .HasComment("工作票签发人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorN)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("licensor_n")
                    .HasComment("工作许可人工号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.LicensorSign)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("licensor_sign")
                    .HasComment("工作许可人签名")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Next)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("next")
                    .HasComment("接下来要推送的员工工号（1 or n）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Num)
                    .HasColumnType("varchar(11)")
                    .HasColumnName("num")
                    .HasComment("工作票编号")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PermitWorkDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("permit_work_date")
                    .HasComment("许可开始工作时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanEndDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_end_date")
                    .HasComment("计划工作结束时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.PlanStartDate)
                    .HasColumnType("varchar(30)")
                    .HasColumnName("plan_start_date")
                    .HasComment("计划工作开始时间")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Quality)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("quality")
                    .HasDefaultValueSql("'1'")
                    .HasComment("（1合格0不合格）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Remark)
                    .HasColumnType("varchar(300)")
                    .HasColumnName("remark")
                    .HasComment("备注")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.SafeMeasureList)
                    .HasColumnType("varchar(2000)")
                    .HasColumnName("safe_measure_list")
                    .HasComment("注意事项（安全措施）：应注意的事项及采取的安全措施")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Statu)
                    .HasColumnType("varchar(5)")
                    .HasColumnName("statu")
                    .HasDefaultValueSql("'00'")
                    .HasComment("状态码")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Unit)
                    .HasColumnType("varchar(60)")
                    .HasColumnName("unit")
                    .HasComment("工作票签发单位")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Valid)
                    .HasColumnType("varchar(2)")
                    .HasColumnName("valid")
                    .HasDefaultValueSql("'1'")
                    .HasComment("（1有效0作废）")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.WorkTaskJson)
                    .HasColumnType("varchar(200)")
                    .HasColumnName("work_task_json")
                    .HasComment("工作任务")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
