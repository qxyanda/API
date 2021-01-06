using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDefectInfo
    {
        public int Id { get; set; }
        public string DiscovererN { get; set; }
        public string DiscovererGroup { get; set; }
        public string DiscovererPost { get; set; }
        public int? EquipmentId { get; set; }
        public string DefectNum { get; set; }
        public string DiscoverTime { get; set; }
        public string DefectName { get; set; }
        public string MediaList { get; set; }
        public string DefectDescription { get; set; }
        public string LiableN { get; set; }
        public string LiableDepartment { get; set; }
        public string DefectType { get; set; }
        public string GenerateViceN { get; set; }
        public string FacilityViceN { get; set; }
        public string SuperviseViceN { get; set; }
        public string GenerateN { get; set; }
        public string FacilityN { get; set; }
        public string SuperviseN { get; set; }
        public string EntrustN { get; set; }
        public string CeN { get; set; }
        public string FirefightN { get; set; }
        public string MedicalN { get; set; }
        public string GenerateViceTime { get; set; }
        public string GenerateViceOp { get; set; }
        public string GenerateTime { get; set; }
        public string GenerateOp { get; set; }
        public string SuperviseViceTime { get; set; }
        public string SuperviseViceOp { get; set; }
        public string SuperviseTime { get; set; }
        public string SuperviseOp { get; set; }
        public string FinalAcceptOp { get; set; }
        public string RepairCount { get; set; }
        public string FinalAcceptTime { get; set; }
        public string Statu { get; set; }
        public string PushNext { get; set; }
    }
}
