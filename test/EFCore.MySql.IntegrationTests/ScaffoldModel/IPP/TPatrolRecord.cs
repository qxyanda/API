using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TPatrolRecord
    {
        public int Id { get; set; }
        public string PatrolDate { get; set; }
        public string PatrolTime { get; set; }
        public string Unit { get; set; }
        public string PatrolerN { get; set; }
        public int? SystemId { get; set; }
        public string MediaList { get; set; }
        public string Remark { get; set; }
        public string ExceptionName { get; set; }
        public string ExceptionFlag { get; set; }
    }
}
