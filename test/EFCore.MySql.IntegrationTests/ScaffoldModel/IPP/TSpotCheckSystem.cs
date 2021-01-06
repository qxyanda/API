using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSpotCheckSystem
    {
        public int Id { get; set; }
        public string System { get; set; }
        public int? PositionId { get; set; }
        public string Major { get; set; }
    }
}
