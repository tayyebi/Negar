using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Negarandeh.Models
{
    public partial class Section
    {
        [DataType(DataType.MultilineText)]
        [Required]
        public string Body_EN { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body_FA { get; set; }
    }
}