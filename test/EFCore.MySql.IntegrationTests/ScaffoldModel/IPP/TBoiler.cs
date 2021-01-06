using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TBoiler
    {
        public int Id { get; set; }
        public string KksCode { get; set; }
        public string ValveName { get; set; }
        public string Place { get; set; }
        public string SysName { get; set; }
    }
}
