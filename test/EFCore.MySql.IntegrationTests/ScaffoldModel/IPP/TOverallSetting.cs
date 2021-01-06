using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TOverallSetting
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string ItemContent { get; set; }
        public string Remark { get; set; }
    }
}
