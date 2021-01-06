using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TFault
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string RepairStatus { get; set; }
        public string ProcessStatus { get; set; }
        public string OutsourcingFlag { get; set; }
        public string OccurTime { get; set; }
        public string CreateTime { get; set; }
        public string RepairTeam { get; set; }
        public string FaultLevel { get; set; }
        public string FaultType { get; set; }
        public string EmergencyLevel { get; set; }
        public string OperatorPhone { get; set; }
        public string OperatorName { get; set; }
        public string StopFlag { get; set; }
        public string EmpiricalCode { get; set; }
        public string Description { get; set; }
        public string KksCode { get; set; }
        public string Othera { get; set; }
        public string Otherb { get; set; }
        public string Otherc { get; set; }
        public string Otherd { get; set; }
        public string Othere { get; set; }
    }
}
