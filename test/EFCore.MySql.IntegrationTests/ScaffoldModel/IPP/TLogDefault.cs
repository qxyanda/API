using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLogDefault
    {
        public int Id { get; set; }
        public string Modular { get; set; }
        public string Title { get; set; }
        public string Item { get; set; }
        public string LogFlag { get; set; }
    }
}
