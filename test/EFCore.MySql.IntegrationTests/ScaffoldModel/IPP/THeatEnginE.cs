using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class THeatEnginE
    {
        public int Id { get; set; }
        public string KksSysCode { get; set; }
        public string KksValveCode { get; set; }
        public string SysSerialShort { get; set; }
        public string ValveName { get; set; }
        public string ValveModel { get; set; }
        public string PressureRating { get; set; }
        public string NominalDiameter { get; set; }
        public string PipePressure { get; set; }
        public string PipePressureUnit { get; set; }
        public string PipeTemp { get; set; }
        public int? Unit1Amount { get; set; }
        public int? Unit2Amount { get; set; }
        public int? TotalAmount { get; set; }
        public string InletPipeSpec { get; set; }
        public string OutletPipeSpec { get; set; }
        public string InterfaceForm { get; set; }
        public string Manufacturer { get; set; }
        public string SysName { get; set; }
        public string SysSerial { get; set; }
        public string KksCode { get; set; }
    }
}
