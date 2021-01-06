using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TNotify
    {
        public int Id { get; set; }
        public string NotifyType { get; set; }
        public string Num { get; set; }
        public string Content { get; set; }
        public string NotifyMessage { get; set; }
        public string ReadIs { get; set; }
        public string Handle { get; set; }
        public string CreateBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public string UpdateDate { get; set; }
    }
}
