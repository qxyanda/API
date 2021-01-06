using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerPartInfo
    {
        public int Id { get; set; }
        public string PartName { get; set; }
        public string PartModel { get; set; }
        public string Manufacturer { get; set; }
        public string Parameter { get; set; }
        public int? Amount { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
