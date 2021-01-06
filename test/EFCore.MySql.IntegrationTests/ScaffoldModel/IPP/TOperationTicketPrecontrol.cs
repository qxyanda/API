using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TOperationTicketPrecontrol
    {
        public int Id { get; set; }
        public string Unit { get; set; }
        public string OperationNum { get; set; }
        public string OperationTask { get; set; }
        public string AppendixJson { get; set; }
        public string OperaterNum { get; set; }
        public string OperaterSign { get; set; }
        public string CustodyNum { get; set; }
        public string CustodySign { get; set; }
        public string Statu { get; set; }
        public string IsEndFlag { get; set; }
        public string CommonFlag { get; set; }
        public string OperaterSignDate { get; set; }
        public string CustodySignDate { get; set; }
    }
}
