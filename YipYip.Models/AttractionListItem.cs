﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YipYip.Data;

namespace YipYip.Models
{
    public class AttractionListItem
    {

        public int AttractionId { get; set; }

        [Display(Name = "Type of Attraction")]
        public string Type { get; set; }

        [Display(Name = "Name of Attraction")]
        public string Name { get; set; }

        [Display(Name = "Rating")]
        public int AttractionRating { get; set; }
        [Display(Name = "Location of Attraction")]
        public Location Area { get; set; }
    }
}