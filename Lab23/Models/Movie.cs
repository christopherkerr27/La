using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab23.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        [StringLength(20)]
        public string Genre { get; set; }
        [Required]
        public double RunTime { get; set; }
    }
}
