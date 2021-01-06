using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerMalfunction
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventType { get; set; }
        public string Overview { get; set; }
        public string CauseAnalysis { get; set; }
        public string Process { get; set; }
        public string Precaution { get; set; }
        public string OperatorN { get; set; }
        public string ClearDate { get; set; }
        public string Remark { get; set; }
        public string Technical { get; set; }
        public int? EquipmentId { get; set; }
    }
}
