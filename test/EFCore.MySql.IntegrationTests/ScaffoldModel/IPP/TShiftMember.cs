using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TShiftMember
    {
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public string ShiftName { get; set; }
        public string ShiftType { get; set; }
        public string GroupNum { get; set; }
        public string Identity { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
