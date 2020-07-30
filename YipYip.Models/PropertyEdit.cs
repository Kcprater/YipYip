using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Models
{
    public class PropertyEdit
    {
        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int NumOfBeds { get; set; }
        public string Desc { get; set; }
        public double WeekDayRate { get; set; }
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
    }
}
