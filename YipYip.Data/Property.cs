﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YipYip.Data
{
    public enum AttractionLocation
    {
        DowntownIndy,
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

    public enum Location
    {
        DowntownIndy,
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
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int NumOfBeds { get; set; }
        [Required]
        public string Desc { get; set; }
        [Required]
        public double WeekdayRate { get; set; }
        [Required]
        public double WeekendRate { get; set; }
        public int Rating { get; set; }
        public AttractionLocation AttractionLocation { get; set; }
    }
}