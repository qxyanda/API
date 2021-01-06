using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TInspectionStandard
    {
        public int Id { get; set; }
        public int? EquipmentId { get; set; }
        public string StandardType { get; set; }
        public string ContentJson { get; set; }
        public string ValidFlag { get; set; }
    }
}
