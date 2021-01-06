using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLimitSpace
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public string Unit { get; set; }
        public string Groups { get; set; }
        public string Content { get; set; }
        public string Address { get; set; }
        public string Charge { get; set; }
        public string Guardian { get; set; }
        public string GroupMembers { get; set; }
        public string WorkStartDate { get; set; }
        public string WorkEndDate { get; set; }
        public string SamplDataJson { get; set; }
        public string SafeMeasureJson { get; set; }
        public string ChargeSign { get; set; }
        public string GuardianSign { get; set; }
        public string WorkMemberSign { get; set; }
        public string IssuerSign { get; set; }
        public string UnitChargeSign { get; set; }
        public string EquipmentSign { get; set; }
        public string SafeSign { get; set; }
        public string LeaderSign { get; set; }
        public string CreateBy { get; set; }
        public string Statu { get; set; }
        public string Valid { get; set; }
        public string Next { get; set; }
    }
}
