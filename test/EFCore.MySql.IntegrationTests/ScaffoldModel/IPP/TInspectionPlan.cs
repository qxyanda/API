using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TInspectionPlan
    {
        public int Id { get; set; }
        public int? StandardId { get; set; }
        public string InspectionCycle { get; set; }
        public string TimeList { get; set; }
        public string InspectorList { get; set; }
        public string ValidFlag { get; set; }
        public int? Frequency { get; set; }
        public string StartTime { get; set; }
    }
}
