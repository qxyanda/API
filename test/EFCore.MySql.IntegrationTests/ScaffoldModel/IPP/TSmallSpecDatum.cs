using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSmallSpecDatum
    {
        public int Id { get; set; }
        public int? SmallSpecId { get; set; }
        public string RecordDate { get; set; }
        public string DayRecord { get; set; }
        public string MonthTotal { get; set; }
        public string YearTotal { get; set; }
    }
}
