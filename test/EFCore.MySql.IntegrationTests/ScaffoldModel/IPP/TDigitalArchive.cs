using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDigitalArchive
    {
        public int Id { get; set; }
        public string Filename { get; set; }
        public string Serial { get; set; }
        public string Url { get; set; }
        public string MainSys { get; set; }
        public string Remark { get; set; }
    }
}
