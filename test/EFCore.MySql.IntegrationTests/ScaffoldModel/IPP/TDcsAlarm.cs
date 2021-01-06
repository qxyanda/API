using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDcsAlarm
    {
        public int Id { get; set; }
        public string Gn { get; set; }
        public int? Rt { get; set; }
        public int? Al { get; set; }
        public int? Ac { get; set; }
        public DateTime? Tf { get; set; }
        public DateTime? Ta { get; set; }
        public DateTime? Tm { get; set; }
        public int? Ds { get; set; }
        public byte[] Av { get; set; }
    }
}
