using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerAuxiliaryInfo
    {
        public int Id { get; set; }
        public string AuxiliaryName { get; set; }
        public string AuxiliaryModel { get; set; }
        public string Parameter { get; set; }
        public string Manufacturer { get; set; }
        public string ManufactureSerial { get; set; }
        public int? Amount { get; set; }
        public string Technical { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
