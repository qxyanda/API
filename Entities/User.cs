using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Users.Entitis
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