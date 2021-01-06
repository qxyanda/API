using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TRiskManage
    {
        public int Id { get; set; }
        public string RepairName { get; set; }
        public string RepairContent { get; set; }
    }
}
