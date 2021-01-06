using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TInspectionPosition
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Major { get; set; }
        public string Model { get; set; }
    }
}
