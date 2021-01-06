using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string UserNum { get; set; }
    }
}
