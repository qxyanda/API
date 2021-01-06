using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TRelation
    {
        public int Id { get; set; }
        public string MainNum { get; set; }
        public int? EnclosureId { get; set; }
        public string EnclosureType { get; set; }
        public string EnclosureNum { get; set; }
        public string EnclosureDate { get; set; }
    }
}
