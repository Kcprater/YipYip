using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public enum Location
    {
        DowntownIndy = 1,
        BroadRipple,
        Speedway,
        Carmel,
        Fishers,
        FountainSquare,
        Plainfield,
        Lawrence,
        BeachGrove,
        Greenwood,
        Avon,
        Brownsburg
    }

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