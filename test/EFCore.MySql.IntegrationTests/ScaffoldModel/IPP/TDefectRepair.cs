using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDefectRepair
    {
        public int Id { get; set; }
        public int? DefectId { get; set; }
        public string FacilityViceTime { get; set; }
        public string FacilityViceOp { get; set; }
        public string FacilityTime { get; set; }
        public string FacilityOp { get; set; }
        public string CeTime { get; set; }
        public string CeOp { get; set; }
        public string EntrustTime { get; set; }
        public string EntrustOp { get; set; }
        public string RepairN { get; set; }
        public string WorkOrderNum { get; set; }
        public string EmergencyRepairNum { get; set; }
        public string ShiftChargeN { get; set; }
        public string ShiftChargeAgreeTime { get; set; }
        public string RepairStartTime { get; set; }
        public string RepairEndTime { get; set; }
        public string RepairDescription { get; set; }
        public string RepairSign { get; set; }
        public string AcceptDepartment { get; set; }
        public string AcceptorN { get; set; }
        public string AcceptOp { get; set; }
        public string AcceptDescription { get; set; }
        public string AcceptorSign { get; set; }
        public string AcceptTime { get; set; }
        public string RepairNth { get; set; }
        public string Statu { get; set; }
        public string PushNext { get; set; }
        public string RepairType { get; set; }
        public string Remark { get; set; }
    }
}
