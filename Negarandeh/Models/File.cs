namespace Negarandeh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class File
    {
        public int Id { get; set; }

        [Required]
        [StringLength(4000)]
        public string FileName { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public byte[] Value { get; set; }
    }
}
