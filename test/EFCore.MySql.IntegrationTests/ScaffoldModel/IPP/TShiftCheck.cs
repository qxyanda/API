using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TShiftCheck
    {
        public int Id { get; set; }
        public string JobNumber { get; set; }
        public string ShiftDate { get; set; }
        public string ClockStartTime { get; set; }
        public string ClockEndTime { get; set; }
        public string SignStartTime { get; set; }
        public string SignEndTime { get; set; }
        public string SignFlag { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
        public string SignValid { get; set; }
        public string SignPeriod { get; set; }
        public string SignType { get; set; }
    }
}
