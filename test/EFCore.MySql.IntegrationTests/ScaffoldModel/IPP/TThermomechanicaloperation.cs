using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TThermomechanicaloperation
    {
        public int Id { get; set; }
        public string OrderN { get; set; }
        public string SuffeN { get; set; }
        public string OrderStartDate { get; set; }
        public string OperationStartDate { get; set; }
        public string OperationEndDate { get; set; }
        public string OperationTask { get; set; }
        public string Remark { get; set; }
        public int? IsMonitoredFlag { get; set; }
        public string OperationItemsJson { get; set; }
        public string SufferOperaterNum { get; set; }
        public string SufferOperaterSign { get; set; }
        public string SufferCustodyNum { get; set; }
        public string SufferCustodySign { get; set; }
        public string OrderDutyleaderNum { get; set; }
        public string OrderDutyleaderSign { get; set; }
        public string OrderShiftleaderNum { get; set; }
        public string OrderShiftleaderSign { get; set; }
        public string ErrorStatu { get; set; }
        public string Statu { get; set; }
        public string Unit { get; set; }
        public string Num { get; set; }
        public int? IsImportentFlag { get; set; }
        public string ImportentCustody { get; set; }
        public string ImportentCustodyProfessionaldirector { get; set; }
        public string ImportentCustodyDepartmentdeputydirector { get; set; }
        public string ImportentCustodyDepartmentdirector { get; set; }
        public string ImportentCustodyChiefengineer { get; set; }
        public string Next { get; set; }
        public string SufferOperaterSignDate { get; set; }
        public string SufferCustodySignDate { get; set; }
        public string OrderShiftleaderSignDate { get; set; }
        public string OrderDutyleaderSignDate { get; set; }
    }
}
