using System;
using System.Collections.Generic;

#nullable disable

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.ScaffoldModel
{
    public partial class TUser
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Initials { get; set; }
        public string PinYin { get; set; }
        public string JobNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }
        public string Post { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Level { get; set; }
        public string Major { get; set; }
        public string Token { get; set; }
        public string TokenUpdated { get; set; }
        public string PcToken { get; set; }
        public string CamId { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
