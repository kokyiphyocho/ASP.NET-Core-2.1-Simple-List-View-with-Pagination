using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleListView.Models
{
    public class Movie
    {
        [Key]
        [MaxLength(10)]
        public String MovieID       { get; set; }
        [MaxLength(200)]
        public string Title         { get; set; }
        [MaxLength(100)]
        public string Genre         { get; set; }
        public int Year             { get; set; }
        public int Duration         { get; set; }
        [MaxLength(50)]
        public string Category      { get; set; }
        [MaxLength(100)]
        public string Director      { get; set; }
        [MaxLength(200)]
        public string Cast          { get; set; }
        [MaxLength(4000)]
        public string BriefStory    { get; set; }
    }
}
