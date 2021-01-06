using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TOperShiftOrder
    {
        public int Id { get; set; }
        public string GroupNum { get; set; }
        public string Shift { get; set; }
        public string ShiftDate { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
