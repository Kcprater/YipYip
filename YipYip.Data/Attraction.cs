using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public class Attraction 
    {
        [Key]
        public int AttractionId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public int AttractionRating { get; set; }
        [Required]
        public Location AttractionLocation { get; set; }

    }
}
//Create enum for type?