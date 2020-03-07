using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class MovieInfo
    {
        public int Id { get; set; }
        [Required]
        public String MovieTitle { get; set; }
        [Required]
        public DateTime DateReleased { get; set; }
    
    }
}
