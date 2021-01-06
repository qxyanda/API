using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TTicket
    {
        public int Id { get; set; }
        public string TicketType { get; set; }
        public string TicketName { get; set; }
    }
}
