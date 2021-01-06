using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TEmergencyRepair
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string RepairChargeN { get; set; }
        public string LicensorN { get; set; }
        public string Unit { get; set; }
        public string Num { get; set; }
        public string Charge { get; set; }
        public string Groups { get; set; }
        public string GroupMembers { get; set; }
        public string GroupMen { get; set; }
        public string TaskJson { get; set; }
        public string SafeMeasureJson { get; set; }
        public string WorkRetainJson { get; set; }
        public string RepairCharge { get; set; }
        public string Arranger { get; set; }
        public string SupplementSafe { get; set; }
        public string Licensor { get; set; }
        public string LicensorDate { get; set; }
        public string PermitDate { get; set; }
        public string LicensorSign { get; set; }
        public string MediaList { get; set; }
        public string EndDate { get; set; }
        public string RetainSafe { get; set; }
        public string ChargeSign { get; set; }
        public string EndLicensorSign { get; set; }
        public string SignDate { get; set; }
        public string Next { get; set; }
        public string Statu { get; set; }
        public string Valid { get; set; }
    }
}
