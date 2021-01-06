using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TDcsApp
    {
        public int Id { get; set; }
        public string Point { get; set; }
        public string Description { get; set; }
        public string Node { get; set; }
        public string LiveValue { get; set; }
        public string Unit { get; set; }
        public string UpdateTime { get; set; }
    }
}
