using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TEquipmentDefault
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string DefaultParameter { get; set; }
    }
}
