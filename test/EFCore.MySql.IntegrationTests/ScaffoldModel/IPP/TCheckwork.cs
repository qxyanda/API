using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TCheckwork
    {
        public int Id { get; set; }
        public string UserN { get; set; }
        public string Date { get; set; }
        public string ClockDateAmStart { get; set; }
        public string ClockDateAmEnd { get; set; }
        public string ClockDatePmStart { get; set; }
        public string ClockDatePmEnd { get; set; }
        public string SignDateAmStart { get; set; }
        public string SignDateAmEnd { get; set; }
        public string SignDatePmStart { get; set; }
        public string SignDatePmEnd { get; set; }
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
