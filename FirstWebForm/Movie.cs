using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebForm
{
    public class Movie
    {
        [Required]
         public int MovieId { get; set; }
        [Required]
        public string MovieName  {get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}