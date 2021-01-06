using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TRiskRepair
    {
        public int Id { get; set; }
        public string WorkSeq { get; set; }
        public string DangerSource { get; set; }
        public string DangerFactor { get; set; }
        public string DangerResult { get; set; }
        public string RiskLevel { get; set; }
        public string WorkStandard { get; set; }
        public string Chapter { get; set; }
        public string Unit { get; set; }
    }
}
