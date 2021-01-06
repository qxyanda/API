using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TBillboard
    {
        public int Id { get; set; }
        public string IssueDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TopFlag { get; set; }
        public string Issuer { get; set; }
        public string Importance { get; set; }
    }
}
