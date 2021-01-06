using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSpotCheckPlan
    {
        public int Id { get; set; }
        public int? StandardId { get; set; }
        public string InspectionCycle { get; set; }
        public string InspectionTime { get; set; }
        public string InspectorList { get; set; }
        public string ValidFlag { get; set; }
    }
}
