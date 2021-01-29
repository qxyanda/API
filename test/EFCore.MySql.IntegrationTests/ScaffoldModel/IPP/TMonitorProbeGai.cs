﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TMonitorProbeGai
    {
        public int Id { get; set; }
        public string Grade { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentLabel { get; set; }
        public string Features { get; set; }
        public string InstallPosition { get; set; }
        public string Major { get; set; }
        public string Workshop { get; set; }
        public string AlertOver { get; set; }
        public string AlertBelow { get; set; }
        public string AlertFlag { get; set; }
        public string AccessPoint { get; set; }
        public string AccessPositon { get; set; }
        public string AccessMode { get; set; }
        public string Address { get; set; }
        public string Remarks { get; set; }
        public string Converge { get; set; }
        public string SwitchPositon { get; set; }
        public string RegisterData { get; set; }
        public int DataAddress { get; set; }
    }
}