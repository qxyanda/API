using System.ComponentModel.DataAnnotations;

namespace Users.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [MaxLength(255)]
        public string user { get; set; }
        [MaxLength(255)]
        public string pw { get; set; }
        [MaxLength(255)]
        public string token { get; set; }
    }
}