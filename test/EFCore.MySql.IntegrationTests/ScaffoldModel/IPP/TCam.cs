using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TCam
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public string Ch { get; set; }
        public string Message { get; set; }
    }
}
