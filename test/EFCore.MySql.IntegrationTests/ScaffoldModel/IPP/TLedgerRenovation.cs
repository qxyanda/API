using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerRenovation
    {
        public int Id { get; set; }
        public string RenovationType { get; set; }
        public string BeginEndDate { get; set; }
        public string Investment { get; set; }
        public string ParticipantN { get; set; }
        public string RenovationReason { get; set; }
        public string RenovationContent { get; set; }
        public string SupplierConstructor { get; set; }
        public string RenovationResult { get; set; }
        public string Reference { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
