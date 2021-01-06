using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TLogShiftSupervisor
    {
        public int Id { get; set; }
        public string FiveHundredKv { get; set; }
        public string ElecConsumption { get; set; }
        public string DesaltedIndustrialWater { get; set; }
        public string AirCompressor { get; set; }
        public string CirculatingFireWater { get; set; }
        public string MainIndicators { get; set; }
        public string CoalWeightIndicators { get; set; }
        public string GroundWire { get; set; }
        public string Signature { get; set; }
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
