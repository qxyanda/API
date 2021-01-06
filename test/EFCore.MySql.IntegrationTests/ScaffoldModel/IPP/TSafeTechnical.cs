using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TSafeTechnical
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public string GroupN { get; set; }
        public string GroupMemberDivision { get; set; }
        public string Sequence { get; set; }
        public string WorkGroupSign { get; set; }
        public string WorkGroupNum { get; set; }
        public string Statu { get; set; }
        public string Valid { get; set; }
        public string Next { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }
    }
}
