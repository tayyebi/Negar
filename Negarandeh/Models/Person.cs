namespace Negarandeh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Person
    {
        [Key]
        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(150)]
        public string Fullname { get; set; }

        [Required]
        [StringLength(300)]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public byte[] Image { get; set; }
    }
}
