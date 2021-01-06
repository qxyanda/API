using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TOrderRecord
    {
        public int Id { get; set; }
        public string Num { get; set; }
        public string ChargeN { get; set; }
        public string OperationN { get; set; }
        public string WorkTaskJson { get; set; }
        public string PlanStartDate { get; set; }
        public string PlanEndDate { get; set; }
        public string EndDate { get; set; }
        public string Valid { get; set; }
    }
}
