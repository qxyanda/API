using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSpotCheckRecord
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Period { get; set; }
        public string CheckTime { get; set; }
        public string Unit { get; set; }
        public string Groups { get; set; }
        public string Shift { get; set; }
        public string InspectorN { get; set; }
        public int? PlanId { get; set; }
        public string ContentJson { get; set; }
        public string MediaList { get; set; }
        public string InspectionFlag { get; set; }
        public string ExceptionFlag { get; set; }
        public string Remark { get; set; }
        public string ReviewFlag { get; set; }
        public string Approver1N { get; set; }
        public string Approval1 { get; set; }
        public string Approval1Time { get; set; }
        public string Approval1Remark { get; set; }
        public string Approver2N { get; set; }
        public string Approval2 { get; set; }
        public string Approval2Time { get; set; }
        public string Approval2Remark { get; set; }
    }
}
