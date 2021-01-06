using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TInspectionKk
    {
        public int Id { get; set; }
        public string Kks { get; set; }
        public string Equipment { get; set; }
        public int? PositionId { get; set; }
    }
}
