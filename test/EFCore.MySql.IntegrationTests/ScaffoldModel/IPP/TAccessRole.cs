using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TAccessRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Code { get; set; }
    }
}
