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
<<<<<<< HEAD
        public int Rating { get; set; }     
        [Required]
        public int PropertyId { get; set; }
        [ForeignKey(nameof(PropertyId))]
        public virtual Property Property { get; set; }
=======
        public int AttractionRating { get; set; }
        [Required]
        public Location AttractionLocation { get; set; }
>>>>>>> 73524be85bb9dd1ceb4d82f39f096219b9d47e35
    }
}