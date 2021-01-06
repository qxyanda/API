using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TCoalTask
    {
        public int Id { get; set; }
        public string OrderNum { get; set; }
        public string EdtionN { get; set; }
        public string IssuerCheckN { get; set; }
        public string SafePersonCheckN { get; set; }
        public string Chapter { get; set; }
        public string WorkTask { get; set; }
        public string Edtion { get; set; }
        public string IssuerCheck { get; set; }
        public string SafePersonCheck { get; set; }
        public string RiskLevel { get; set; }
        public string WorkStandardId { get; set; }
        public string Statu { get; set; }
        public string Valid { get; set; }
        public string Next { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }
    }
}
