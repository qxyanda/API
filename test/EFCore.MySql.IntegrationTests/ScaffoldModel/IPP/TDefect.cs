using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDefect
    {
        public int Id { get; set; }
        public string DiscovererN { get; set; }
        public string DiscovererGroup { get; set; }
        public string DiscovererPost { get; set; }
        public int? EquipmentId { get; set; }
        public string Model { get; set; }
        public string Major { get; set; }
        public string InstallPosition { get; set; }
        public string EquipmentName { get; set; }
        public string DefectNum { get; set; }
        public string DiscoverTime { get; set; }
        public string DefectName { get; set; }
        public string MediaList { get; set; }
        public string DefectDescription { get; set; }
        public string LiableN { get; set; }
        public string LiableTime { get; set; }
        public string DefectType { get; set; }
        public string ReceiverGroup { get; set; }
        public string ReceiverList { get; set; }
        public string ReceiverN { get; set; }
        public string ReceiverRemark { get; set; }
        public string ReceiverOp { get; set; }
        public string ReceiverTime { get; set; }
        public string FacilityDirectorN { get; set; }
        public string ChiefEngineerN { get; set; }
        public string EntrustList { get; set; }
        public string EntrustGroup { get; set; }
        public string EntrustN { get; set; }
        public string EntrustOp { get; set; }
        public string EntrustTime { get; set; }
        public string RepairN { get; set; }
        public string FinalRepairN { get; set; }
        public string RepairStartTime { get; set; }
        public string RepairEndTime { get; set; }
        public string RepairDescription { get; set; }
        public string RepairSign { get; set; }
        public string AcceptDepartment { get; set; }
        public string AcceptorN { get; set; }
        public string AcceptOp { get; set; }
        public string AcceptDescription { get; set; }
        public string AcceptorSign { get; set; }
        public string AcceptHistory { get; set; }
        public string AcceptTime { get; set; }
        public string Remark { get; set; }
        public string FacilityMajorN { get; set; }
        public string FacilityMajorOp { get; set; }
        public string DefectStatus { get; set; }
        public string DefectState { get; set; }
        public string PushNext { get; set; }
    }
}
