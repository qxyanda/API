using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerEquipmentDefault
    {
        public int Id { get; set; }
        public string EquipmentName { get; set; }
        public string Model { get; set; }
        public string EquipmentState { get; set; }
        public string ManufactureDate { get; set; }
        public string OperateDate { get; set; }
        public string EquipmentType { get; set; }
        public string Manufacturer { get; set; }
        public string SystemName { get; set; }
        public int? SystemId { get; set; }
        public string LiableN { get; set; }
        public string EquipmentModel { get; set; }
        public string EquipmentLevel { get; set; }
        public string ManufactureSerial { get; set; }
        public string InstallPosition { get; set; }
        public string Major { get; set; }
        public string Department { get; set; }
        public string TechParamList { get; set; }
        public string TechDataList { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
