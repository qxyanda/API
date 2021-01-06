using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerDailyMaintain
    {
        public int Id { get; set; }
        public string MaintainType { get; set; }
        public string MaintainDate { get; set; }
        public string MaintainContent { get; set; }
        public string MaintainData { get; set; }
        public string Parts { get; set; }
        public string OperatorN { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
