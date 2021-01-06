using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDigitalArchiveIndex
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string MainSys { get; set; }
        public int? ArchiveId { get; set; }
        public string Remark { get; set; }
    }
}
