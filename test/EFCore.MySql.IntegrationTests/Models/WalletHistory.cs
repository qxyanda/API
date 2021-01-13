using System.ComponentModel.DataAnnotations;

namespace Pomelo.EntityFrameworkCore.MySql.IntegrationTests.Models
{
    public class WalletHistory
    {
        public int PersonId { get; set; }
        [Key]
        public int Id { get; set; }
        public int WalletId { get; set; }
        public string Status { get; set; }
        public int DateTime { get; set; }
    }
}
