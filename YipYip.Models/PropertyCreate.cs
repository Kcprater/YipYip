using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;

namespace YipYip.Models
{
    public class PropertyCreate
    {
        [Required]
        //set min and max?
        public string Title { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public int NumOfBeds { get; set; }

        [Required]
        //set min and max?
        public string Desc { get; set; }

        [Required]
        public double WeekDayRate { get; set; }

        [Required]
        public double WeekendRate { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
