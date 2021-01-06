using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TTicketTemplate
    {
        public int Id { get; set; }
        public string TicketType { get; set; }
        public string TemplateUri { get; set; }
        public string Remark { get; set; }
    }
}
