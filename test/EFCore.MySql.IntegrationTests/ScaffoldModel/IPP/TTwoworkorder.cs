using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TTwoworkorder
    {
        public int Id { get; set; }
        public string ChargeN { get; set; }
        public string LicensorN { get; set; }
        public string OperationN { get; set; }
        public string IssuerN { get; set; }
        public string Unit { get; set; }
        public string Num { get; set; }
        public string Groups { get; set; }
        public string GroupMembersNs { get; set; }
        public string GroupMembersNum { get; set; }
        public string DoubleName { get; set; }
        public string WorkTaskJson { get; set; }
        public string PlanStartDate { get; set; }
        public string PlanEndDate { get; set; }
        public string WorkRetainList { get; set; }
        public string SafeMeasureList { get; set; }
        public string IssuerSign { get; set; }
        public string IssuerDate { get; set; }
        public string AdditionalSafeMeasureJson { get; set; }
        public string PermitWorkDate { get; set; }
        public string LicensorSign { get; set; }
        public string ChargeSign { get; set; }
        public string GroupMembersSigns { get; set; }
        public string GroupMembersArray { get; set; }
        public string DelayDate { get; set; }
        public string DelayChargeSign { get; set; }
        public string DelayChargeDate { get; set; }
        public string DelayLicensorSign { get; set; }
        public string DelayLicensorDate { get; set; }
        public string EndDate { get; set; }
        public string EndChargeSign { get; set; }
        public string EndChargeDate { get; set; }
        public string EndLicensorSign { get; set; }
        public string EndLicensorDate { get; set; }
        public string Remark { get; set; }
        public string RelationId { get; set; }
        public string MediaList { get; set; }
        public string Statu { get; set; }
        public string Valid { get; set; }
        public string Next { get; set; }
        public string Quality { get; set; }
        public string CreateBy { get; set; }
    }
}
