using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;
using YipYip.Models;

namespace YipYip.Services
{
    public class PropertyService
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        //Create
        public bool CreateProperty(PropertyCreate model)
        {
            Property property = new Property
            {
                Title = model.Title,
                Location = model.Location,
                NumOfBeds = model.NumOfBeds,
                Desc = model.Desc,
                WeekdayRate = model.WeekDayRate,
                WeekendRate = model.WeekendRate,
                Rating = model.Rating
            };
            _context.Properties.Add(property);
            return _context.SaveChanges() == 1;
        }

        //Get By Id

        //Get All

    }
}
