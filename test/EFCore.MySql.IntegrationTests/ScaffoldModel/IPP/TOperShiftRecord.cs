using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TOperShiftRecord
    {
        public int Id { get; set; }
        public string ShiftDate { get; set; }
        public string GroupNum { get; set; }
        public string Shift { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string ShiftCharge { get; set; }
        public string ModelCharges { get; set; }
        public string MainMembers { get; set; }
        public string SubMembers { get; set; }
        public string AdditionalMembers { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
