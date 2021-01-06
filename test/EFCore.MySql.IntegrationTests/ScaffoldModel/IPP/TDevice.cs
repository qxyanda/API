using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDevice
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public string JobNumber { get; set; }
    }
}
