using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSpotCheck
    {
        public int Id { get; set; }
        public string System { get; set; }
        public string InspectionCycle { get; set; }
        public int? ContentJsonId { get; set; }
        public string InspectorList { get; set; }
        public string ValidFlag { get; set; }
        public int? PositionId { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateTime { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
