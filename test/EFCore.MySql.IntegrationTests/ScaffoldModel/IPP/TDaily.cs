using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDaily
    {
        public int Id { get; set; }
        public string UserNum { get; set; }
        public string ContentDay { get; set; }
        public string PlanTomorrow { get; set; }
        public string ReportNum { get; set; }
        public string Enclosure { get; set; }
        public string Other { get; set; }
        public string ReadIs { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
