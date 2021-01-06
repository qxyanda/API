using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TTicketSupervise
    {
        public int Id { get; set; }
        public string PassType { get; set; }
        public int? TicketNum { get; set; }
        public int? SafePersonNum { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? RelationTicketNum { get; set; }
        public string ImageAdress { get; set; }
        public string SafeIs { get; set; }
        public string CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
