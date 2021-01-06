using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLogMachinesetLeader
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string ElecConsumption { get; set; }
        public string Conveyor { get; set; }
        public string HydrogenOil { get; set; }
        public string Signature { get; set; }
        public string Matters { get; set; }
        public string GroundwireNum { get; set; }
        public string Records { get; set; }
        public string PushNext { get; set; }
        public string JobNumber { get; set; }
        public string LateNightHandover { get; set; }
        public string LateNightTakeover { get; set; }
        public string DayHandover { get; set; }
        public string DayTakeover { get; set; }
        public string EveHandover { get; set; }
        public string EveTakeover { get; set; }
        public string CreateDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
