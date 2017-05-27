namespace Negarandeh.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Section
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title_EN { get; set; }

        [Required]
        [StringLength(200)]
        public string Title_FA { get; set; }

        public int SeasonId { get; set; }

        public int? Index { get; set; }

        public virtual Season Season { get; set; }
    }
}
