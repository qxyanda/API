using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TProductSpec
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Model { get; set; }
        public string Unit { get; set; }
        public string InputMethod { get; set; }
        public string PointName { get; set; }
        public string ComputeFormula { get; set; }
        public string ConnectSpecIds { get; set; }
        public string ShowFlag { get; set; }
        public string Remark { get; set; }
        public string TypeFlag { get; set; }
        public string Record { get; set; }
        public string LastUpdated { get; set; }
    }
}
