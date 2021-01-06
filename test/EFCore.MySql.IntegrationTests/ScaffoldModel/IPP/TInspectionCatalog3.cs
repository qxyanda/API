using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TInspectionCatalog3
    {
        public int Id { get; set; }
        public string InspectionItem { get; set; }
        public string Flag { get; set; }
        public int? InspectionSystemId { get; set; }
    }
}
