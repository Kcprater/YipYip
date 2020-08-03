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
        //List<Location> Attraction = new List<Location>();

        public int PropertyId { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public int NumOfBeds { get; set; }
        public string Desc { get; set; }
        public double WeekDayRate { get; set; }
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public ICollection<Attraction> Attraction { get; set; }
        public Location PropertyLocation { get; set; }
        public Location AttractionLocation { get; set; }

            //list of attractions - match property location to attraction location
        }
    }
