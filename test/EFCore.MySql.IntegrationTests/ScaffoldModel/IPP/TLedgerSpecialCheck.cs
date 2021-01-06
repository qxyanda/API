using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLedgerSpecialCheck
    {
        public int Id { get; set; }
        public string CheckUnit { get; set; }
        public string CheckDate { get; set; }
        public string CheckType { get; set; }
        public string RectifyPeriod { get; set; }
        public string ChargeN { get; set; }
        public string Problem { get; set; }
        public string RectifyCondition { get; set; }
        public string Reference { get; set; }
        public string Remark { get; set; }
        public int? EquipmentId { get; set; }
    }
}
