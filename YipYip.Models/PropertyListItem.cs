using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;

namespace YipYip.Models
{
    public class PropertyListItem
    {
        List<Location> _attractDirectory = new List<Location>();

        //Location _propDirectory = new Location();

        public int PropertyId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int NumOfBeds { get; set; }
        public string Desc { get; set; }
        public double WeekDayRate { get; set; }
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public Location Area { get; set; }
    }
}
