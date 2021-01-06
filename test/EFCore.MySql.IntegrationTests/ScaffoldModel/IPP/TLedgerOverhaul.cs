using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerOverhaul
    {
        public int Id { get; set; }
        public string OverhaulType { get; set; }
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
        public string PreCondition { get; set; }
        public string OverhaulContent { get; set; }
        public string TrialOperation { get; set; }
        public string PostCondition { get; set; }
        public string Parts { get; set; }
        public string OperatorN { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
