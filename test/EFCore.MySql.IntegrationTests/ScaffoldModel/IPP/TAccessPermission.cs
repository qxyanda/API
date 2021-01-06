using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TAccessPermission
    {
        public int Id { get; set; }
        public string MenuName { get; set; }
        public string SubMenuName { get; set; }
        public string SubMenuCode { get; set; }
        public string FuncRange { get; set; }
        public string ModuleName { get; set; }
        public string SubModuleName { get; set; }
        public string SubModuleCode { get; set; }
        public string PermitBit { get; set; }
    }
}
