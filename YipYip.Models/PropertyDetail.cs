using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;

namespace YipYip.Models
{
    public class PropertyDetail
    {
        public int PropertyId { get; set; }
        public int OwnerId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int NumOfBeds { get; set; }
        public string Desc { get; set; }
        public double WeekDayRate { get; set; }
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public Location PropertyLocation { get; set; }
    }
}
